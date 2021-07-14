using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StandardControls
{
    public partial class WebForm5_DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlTechnologies_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Item = ddlTechnologies.SelectedItem;
            lblText.Text = Item.Text;
            lblValue.Text = Item.Value;
        }
    }
}