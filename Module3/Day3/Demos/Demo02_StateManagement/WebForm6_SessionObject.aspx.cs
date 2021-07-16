using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm6_SessionObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            Session["Key1"] = txtInput.Text;
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            if (Session["Key1"] != null)
            {
                txtInput.Text = Session["Key1"].ToString();
            }
        }

        protected void btnResetSession_Click(object sender, EventArgs e)
        {
            Session.Remove("Key1");
            Session.Clear();
            Session.Abandon();
        }
    }
}