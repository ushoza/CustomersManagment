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
        id = Guid.Parse(Request["id"]);
        context = new CustomerManagementEntities();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Customer customer = getCustomerById();
            tbFirstName.Text = customer.FirstName;
            tbLastName.Text = customer.LastName;
            tbAdress.Text = customer.Address;

        }
    }

    private Customer getCustomerById()
    {
        return context.Customers.Where(x => x.ID == id).FirstOrDefault<Customer>();
    }

}