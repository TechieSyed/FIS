<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2_RadioButtons.aspx.cs" Inherits="Demo02_StandardControls.WebForm1_RadioButtons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Are you Vegetarion :
            <asp:RadioButton ID="rbtnVeg" runat="server" GroupName="VegNonVeg" OnCheckedChanged="rbtnVeg_CheckedChanged" Text="Yes" AutoPostBack="True" />
&nbsp;
            <asp:RadioButton ID="rbtnNonVeg" runat="server" GroupName="VegNonVeg" OnCheckedChanged="rbtnNonVeg_CheckedChanged" Text="No" AutoPostBack="True" />
            <br />
            <asp:Panel ID="pnlLifeStyle" runat="server">
                <br />
            <br />
            Vegetarion is a healthy life style :&nbsp; 
            <asp:RadioButton ID="rbtnYes" runat="server" Checked="True" GroupName="LifeStyleChoice" Text="I Agree" />
&nbsp;
            <asp:RadioButton ID="rbtnNo" runat="server" GroupName="LifeStyleChoice" Text="I Don't Agree" />
            <br />
            </asp:Panel>
            
        </div>
    </form>
</body>
</html>
