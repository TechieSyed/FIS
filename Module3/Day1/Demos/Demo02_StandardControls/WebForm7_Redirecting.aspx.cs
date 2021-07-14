using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StandardControls
{
    public partial class WebForm7_Redirecting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoToWebForm1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1_LabelAndTextBox.aspx");
        }
    }
}