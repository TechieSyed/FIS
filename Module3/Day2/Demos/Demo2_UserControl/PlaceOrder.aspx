<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="Demo2_UserControl.PlaceOrder" %>

<%@ Register Src="UserAddress.ascx" TagName="Address" TagPrefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Place your order here</h1>
            <p>&nbsp;</p>
            <p>
                <h2>Provide billing address</h2>
                <uc:Address ID="BillingAddress" runat="server" />
            </p>
            <p>
               
                <asp:CheckBox ID="cboxSameAddress" runat="server" AutoPostBack="True" Font-Size="15pt" OnCheckedChanged="cboxSameAddress_CheckedChanged" Text="Same as Billing Address" />
               
            </p>
            <p>
                <h2>Provide Delivery address</h2>
                <uc:Address ID="DeliveryAddress" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
