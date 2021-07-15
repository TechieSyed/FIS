using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo01_ValidationControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Validate();
            //Page.Validate("LoginValidations");
            if (Page.IsValid)
            {
                lblOutput.Text = "Registration Successfull !!";
            }
        }

        protected void cusValDateOfBirth_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime dt = Convert.ToDateTime(args.Value);
            if (DateTime.Now.Year - dt.Year >= 18)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}