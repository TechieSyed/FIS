<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5_DropDownList.aspx.cs" Inherits="Demo02_StandardControls.WebForm5_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlTechnologies" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTechnologies_SelectedIndexChanged">
                <asp:ListItem Value="101">Microsoft .NET</asp:ListItem>
                <asp:ListItem Value="102">Java</asp:ListItem>
                <asp:ListItem Value="103">C Sharp</asp:ListItem>
                <asp:ListItem Value="104">Python</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Selected Text = <asp:Label ID="lblText" runat="server"></asp:Label>
            <br />
            Selected Value =
            <asp:Label ID="lblValue" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
