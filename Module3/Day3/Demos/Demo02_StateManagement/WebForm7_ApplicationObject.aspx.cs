using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm7_ApplicationObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            //Application["val1"] = new DataSet();
            Application["val1"] = txtInput.Text;
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            if (Application["val1"] != null)
            {
               // txtInput.Text = Application["val1"].ToString();
                txtInput.Text = Application["val2"].ToString();
            }
        }

        protected void btnResetSession_Click(object sender, EventArgs e)
        {
            Application.Remove("val1");
            //Application.Clear();
        }
    }
}