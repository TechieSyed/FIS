<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1_LabelAndTextBox.aspx.cs" Inherits="Demo02_StandardControls.WebForm1_LabelAndTextBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 214px;
        }
        .textbox{
            padding:2px 4px;
            border:1px solid #aeaeae;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblName" runat="server" Text="Enter name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" AutoPostBack="True" CssClass="textbox" OnTextChanged="txtName_TextChanged"></asp:TextBox>
                    &nbsp;<asp:Label ID="lblCount" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblEmail" runat="server" Text="Enter Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblAddress" runat="server" Text="Enter Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" Height="80px" TextMode="MultiLine" Width="255px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblPassword" runat="server" Text="Enter Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDateOfBirth" runat="server" Text="Enter Date Of Birth"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            &nbsp;
        </div>
    </form>
</body>
</html>
