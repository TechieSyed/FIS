using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo2_UserControl
{
    public partial class UserAddress : System.Web.UI.UserControl
    {
        public string AddressLine1
        {
            get { return txtAddressLine1.Text; }
            set { txtAddressLine1.Text = value; }
        }
        public string AddressLine2
        {
            get { return txtAddressLine2.Text; }
            set { txtAddressLine2.Text = value; }
        }
        public string City
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }
        public string State
        {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }
        public string Country
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }
        public string PostalCode
        {

            get { return txtPostalCode.Text; }
            set { txtPostalCode.Text = value; }
        }

        public void CopyAddress(UserAddress other)
        {
            this.AddressLine1 = other.AddressLine1;
            this.AddressLine2 = other.AddressLine2;
            this.State = other.State;
            this.City = other.City;
            this.Country = other.Country;
            this.PostalCode = other.PostalCode;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}