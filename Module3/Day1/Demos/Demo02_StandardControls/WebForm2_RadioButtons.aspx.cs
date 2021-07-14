using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StandardControls
{
    public partial class WebForm1_RadioButtons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbtnVeg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVeg.Checked)
            {
                pnlLifeStyle.Visible = true;
            }
        }

        protected void rbtnNonVeg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNonVeg.Checked)
            {
                pnlLifeStyle.Visible = false;
            }
        }
    }
}