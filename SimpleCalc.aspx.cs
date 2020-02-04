using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SimpleCalc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSum_Click(object sender, EventArgs e)
    {
        if(IsValid)
        {
            lbResult.Text = (Convert.ToDouble(tbOp1.Text) + Convert.ToDouble(tbOp2.Text)).ToString();
        }
    }
}