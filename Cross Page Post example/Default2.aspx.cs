using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    int count;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            count = 1;
        }
        else
        {
            count = (int)ViewState["theCount"] + 1;
            Response.Write("Count is " + count);
        }

    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        ViewState["theCount"] = count;
    }
}