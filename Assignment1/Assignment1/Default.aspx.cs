using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentDate.Text = DateTime.Today.ToString();
        }

        protected void Calculate_Age_Button_Click(object sender, EventArgs e)
        {
            AgeLabel.Text = DateTime.Now.ToString();
        }
    }
}