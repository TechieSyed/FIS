<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6_SessionObject.aspx.cs" Inherits="Demo02_StateManagement.WebForm6_SessionObject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter some text"></asp:Label>
&nbsp;<asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnStore" runat="server" OnClick="btnStore_Click" Text="Store" />
&nbsp;<asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" />
&nbsp;<asp:Button ID="btnResetSession" runat="server" OnClick="btnResetSession_Click" Text="Abandon" />
        </div>
    </form>
</body>
</html>
