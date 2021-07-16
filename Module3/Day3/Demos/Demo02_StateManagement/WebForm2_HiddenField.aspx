<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2_HiddenField.aspx.cs" Inherits="Demo02_StateManagement.WebForm2_HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter a value"></asp:Label>
&nbsp;<asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnStore" runat="server" OnClick="btnStore_Click" Text="Store" />
&nbsp;<asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show Value" />
            <br />
            <br />
            <asp:HiddenField ID="hfUserInput" runat="server" />
        </div>
    </form>
</body>
</html>
