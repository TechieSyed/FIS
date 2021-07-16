using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo01_EFCodeFirst
{
    public partial class WebForm3_ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var value = txtInput.Text;
            ViewState["K1"] = value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (ViewState["K1"] != null)
            {
                var value = ViewState["K1"].ToString();
                txtInput.Text = value;
            }
        }
    }
}