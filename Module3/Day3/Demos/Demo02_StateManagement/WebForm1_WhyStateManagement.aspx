<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1_WhyStateManagement.aspx.cs" Inherits="Demo02_StateManagement.WebForm1_WhyStateManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNumber" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnIncrement" runat="server" OnClick="btnIncrement_Click" Text="Increment" />
            <br />
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" />
        </div>
    </form>
</body>
</html>
