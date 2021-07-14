<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4_Button.aspx.cs" Inherits="Demo02_StandardControls.WebForm4_Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Click Me !!" />
        </div>
    </form>
</body>
</html>
