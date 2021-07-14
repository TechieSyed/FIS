<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6_IsPostBack.aspx.cs" Inherits="Demo02_StandardControls.WebForm6_IsPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDateTime" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <br />
            <asp:DropDownList ID="ddlDepartments" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
