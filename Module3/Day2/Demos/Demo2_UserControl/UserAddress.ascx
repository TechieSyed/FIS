<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserAddress.ascx.cs" Inherits="Demo2_UserControl.UserAddress" %>
<style type="text/css">
    .auto-style1 {
        width: 383px;
    }
    .auto-style2 {
        width: 179px;
    }
    .auto-style4 {
        width: 188px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="AddressLine 1"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtAddressLine1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Address Line 2"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtAddressLine2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="State"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="Country"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Postal Code"></asp:Label>
        </td>
        <td class="auto-style4">
            <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>

