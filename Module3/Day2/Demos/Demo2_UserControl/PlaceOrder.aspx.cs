using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo2_UserControl
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cboxSameAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxSameAddress.Checked)
            {
                //DeliveryAddress.AddressLine1 = BillingAddress.AddressLine1;
                //DeliveryAddress.AddressLine2 = BillingAddress.AddressLine2;
                //DeliveryAddress.City = BillingAddress.City;
                //DeliveryAddress.State = BillingAddress.State;
                //DeliveryAddress.Country = BillingAddress.Country;
                //DeliveryAddress.PostalCode = BillingAddress.PostalCode;
                DeliveryAddress.CopyAddress(BillingAddress);
            }
        }
    }
}