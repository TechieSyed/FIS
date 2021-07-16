using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm4_QueryString2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["useremail"] != null)
            {
                var value = Request.QueryString["useremail"];
                lblEmailAddress.Text = value;
            }
        }
    }
}