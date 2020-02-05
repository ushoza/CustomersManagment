using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ColorChooser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnColor_Click(object sender, EventArgs e)
    {
        if(!string.IsNullOrWhiteSpace(tbColor.Text))
        {
            Session["userColor"] = tbColor.Text;
        }
    }
}