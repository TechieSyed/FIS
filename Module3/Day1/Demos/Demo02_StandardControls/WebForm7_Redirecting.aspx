<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7_Redirecting.aspx.cs" Inherits="Demo02_StandardControls.WebForm7_Redirecting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="lnkGoToWebform1" runat="server" NavigateUrl="~/WebForm1_LabelAndTextBox.aspx">Navigate to Web Form 1</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnGoToWebForm1" runat="server" OnClick="btnGoToWebForm1_Click" Text="Go To Web Form 1" />
        </div>

    </form>
</body>
</html>
