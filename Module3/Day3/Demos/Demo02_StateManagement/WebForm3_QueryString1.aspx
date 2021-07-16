<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3_QueryString1.aspx.cs" Inherits="Demo02_StateManagement.WebForm3_QueryString1" %>

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
&nbsp;<asp:Button ID="btnSubs" runat="server" OnClick="btnSubs_Click" Text="Subscribe" />
        </div>
    </form>
</body>
</html>
