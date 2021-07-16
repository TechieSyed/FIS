using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm2_HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            var value = txtInput.Text;
            hfUserInput.Value = value;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            var value = hfUserInput.Value;
            txtInput.Text = value;
        }
    }
}