using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StandardControls
{
    public partial class WebForm6_IsPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack == false)     //returns true for HttpPost request else false
            if (!IsPostBack)
            {
                lblDateTime.Text = DateTime.Now.ToString();

                ddlDepartments.Items.Add(new ListItem { Text = "HR", Value = "101" });
                ddlDepartments.Items.Add(new ListItem { Text = "Accounts", Value = "102" });
                ddlDepartments.Items.Add(new ListItem { Text = "IT", Value = "103" });
            }           
        }
    }
}