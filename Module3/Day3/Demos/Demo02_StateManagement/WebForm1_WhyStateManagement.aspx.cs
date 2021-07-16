using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo02_StateManagement
{
    public partial class WebForm1_WhyStateManagement : System.Web.UI.Page
    {
        int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HiddenField1.Value = counter.ToString();
            }
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            counter = Convert.ToInt32(HiddenField1.Value);
            counter++;
            lblNumber.Text = counter.ToString();
            HiddenField1.Value = counter.ToString();
        }
    }
}