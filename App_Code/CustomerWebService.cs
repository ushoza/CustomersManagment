using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for CustomerWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CustomerWebService : System.Web.Services.WebService
{

    public CustomerWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public List<string> GetContries()
    {
        using (CustomerManagementEntities customerManagementEntities =
            new CustomerManagementEntities())
        {
            var contry = from c in customerManagementEntities.Countries
                         orderby c.Name
                         select c.Name;
            return contry.ToList();
        }
    }
    [WebMethod]
    public List<string> GetCustomersByCountry(string countryName)
    {
        using (CustomerManagementEntities context = 
            new CustomerManagementEntities())
        {
            var r = from c in context.Countries
                    where c.Name == countryName
                    select c.ID;
            Guid idCountry = r.FirstOrDefault<Guid>();
            var customers = from f in context.Customers
                            where f.CountryID == idCountry
                            select f.LastName;
            
            return customers.ToList();
        }
    }

}
