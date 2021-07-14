<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3_CheckBoxes.aspx.cs" Inherits="Demo02_StandardControls.WebForm3_CheckBoxes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="cboxHindi" runat="server" Checked="True" Text="Hindi" />
            <asp:CheckBox ID="cboxEnglish" runat="server" Text="English" />
            <asp:CheckBox ID="cboxTelugu" runat="server" Text="Telugu" />
            <br />
            <br />
            <asp:CheckBox ID="cboxYesNo" runat="server" AutoPostBack="True" OnCheckedChanged="cboxYesNo_CheckedChanged" Text="Web Forms is amazing (Yes/No)" />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
