<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3_ViewState.aspx.cs" Inherits="Demo01_EFCodeFirst.WebForm3_ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter name (ASP.Net)"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter name (HTML)"></asp:Label>
&nbsp;<input id="Text1" type="text" /><br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter some text"></asp:Label>
&nbsp;<asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Store" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Read" />
        </div>
    </form>
</body>
</html>
