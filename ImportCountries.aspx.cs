﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class ImportCountries : System.Web.UI.Page
{
    static private IEnumerable<XElement> countriesWithPhNoFormat = null;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FilterButton_Click(object sender, EventArgs e)
    {
        XElement countries = loadCountries("Countries.xml");
        countriesWithPhNoFormat = filterCountries(countries);
        XmlDataSource1.Data = buildXmlString(countriesWithPhNoFormat);
        XmlDataSource1.DataFile = "";
    }

    private XElement loadCountries(string fileName)
    {
        return XElement.Load(Server.MapPath(fileName));

    }

    private IEnumerable<XElement> filterCountries(XElement countries)
    {
        return from c in countries.Elements()
        where c.Attribute("PhoneNoFormat") != null && c.Attribute("PhoneNoFormat").Value.ToString() != ""
        select c;
    }

    private string buildXmlString(IEnumerable<XElement> countriesWithPhNoFormat)
    {
        return "<Countries>" + string.Join("", countriesWithPhNoFormat.Select(x => x.ToString()).ToArray()) + "</Countries>";
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            using (CustomerManagementEntities context = new CustomerManagementEntities())
            {
                foreach (XElement country in countriesWithPhNoFormat)
                {
                    Guid g = new Guid(country.Attribute("ID").Value);
                    Country c = context.Countries.Where(x => x.ID == g).FirstOrDefault<Country>();
                    c.PhoneNoFormat = country.Attribute("PhoneNoFormat").Value;
                }
                context.SaveChanges();
                ImportResultLabel.Text = "Импорт завершен успешно";
            }
        }
        catch (Exception ex)
        {

            ImportResultLabel.Text = ex.Message;
        }
        
    }
}