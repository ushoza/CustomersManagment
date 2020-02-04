using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFillCountries_Click(object sender, EventArgs e)
        {
            using (ProxyCustomerWebService.CustomerWebService customerWebService =
                new ProxyCustomerWebService.CustomerWebService())
            {
                cmbCountries.DataSource = customerWebService.GetContries();
            }
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ProxyCustomerWebService.CustomerWebService customerWebService =
                new ProxyCustomerWebService.CustomerWebService())
            {
                string country = cmbCountries.SelectedValue.ToString();
                string[] res = customerWebService.GetCustomersByCountry(country);
                cmbCustomers.DataSource = res;
            }
        }
    }
}
