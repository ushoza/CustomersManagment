using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userColor"] != null)
        {
            this.divHeader.Style.Add(HtmlTextWriterStyle.BackgroundColor,
                "#" + Session["userColor"].ToString());
        }
    }
}
