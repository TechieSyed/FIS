using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StandardControls
{
    public partial class WebForm3_CheckBoxes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cboxYesNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxYesNo.Checked)
            {
                lblMessage.Text = "Good for you";
            }
            else
            {
                lblMessage.Text = "Wish you all the best";
            }
        }
    }
}