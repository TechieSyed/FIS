using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm5_Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            var cookie = new HttpCookie("UserDetailsCookie");
            cookie["email"] = txtEmail.Text;
            if (cbox10Minutes.Checked)
            {
                cookie.Expires = DateTime.Now.AddMinutes(10);
            }
            Response.Cookies.Add(cookie);
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserDetailsCookie"] != null)
            {
                var cookie = Request.Cookies["UserDetailsCookie"];
                txtEmail.Text = cookie["email"];
            }
        }
    }
}