using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditCustomer : System.Web.UI.Page
{
    private Guid id;
    CustomerManagementEntities context;
    protected void Page_Init(object sender, EventArgs e)
    {
        if(Request["id"] != null)
            id = Guid.Parse(Request["id"]);
        context = new CustomerManagementEntities();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Customer customer = getCustomer();
            tbFirstName.Text = customer.FirstName;
            tbLastName.Text = customer.LastName;
            tbAdress.Text = customer.Address;
            ddlCountry.DataSource = context.Countries.ToList();
            ddlCountry.DataValueField = "ID";
            ddlCountry.DataTextField = "Name";
            if(customer.CountryID != Guid.Empty)
                ddlCountry.SelectedValue = customer.CountryID.ToString();
            ddlCountry.DataBind();

        }
    }

    private Customer getCustomer()
    {
        if (Request["id"] != null)
            return context.Customers.Where(x => x.ID == id).FirstOrDefault<Customer>();
        else
        {
            Customer customer = new Customer();
            customer.ID = Guid.NewGuid();
            context.Customers.Add(customer);
            return customer;
        }
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        if(IsValid)
        {
            Customer customer = getCustomer();
            customer.FirstName = tbFirstName.Text;
            customer.LastName = tbLastName.Text;
            customer.Address = tbAdress.Text;
            customer.CountryID = Guid.Parse(ddlCountry.SelectedValue);
            context.SaveChanges();
            Response.Redirect("~/Customers.aspx");
        }
    }
}