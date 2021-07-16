<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5_Cookies.aspx.cs" Inherits="Demo02_StateManagement.WebForm5_Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your email"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnStore" runat="server" OnClick="btnStore_Click" Text="Store" />
&nbsp;<asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" />
            <br />
            <br />
            <asp:CheckBox ID="cbox10Minutes" runat="server" Text="Store for 10 minutes" />
        </div>
    </form>
</body>
</html>
