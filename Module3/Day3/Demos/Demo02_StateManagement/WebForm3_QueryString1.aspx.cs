using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm3_QueryString1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubs_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            Response.Redirect("~/Webform4_querystring2.aspx?useremail=" + email);
        }
    }
}