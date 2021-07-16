<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7_ApplicationObject.aspx.cs" Inherits="Demo02_StateManagement.WebForm7_ApplicationObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter some text"></asp:Label>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnStore" runat="server" OnClick="btnStore_Click" Text="Store" />
            <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnResetSession_Click" Text="Remove all" />
        </div>
    </form>
</body>
</html>
