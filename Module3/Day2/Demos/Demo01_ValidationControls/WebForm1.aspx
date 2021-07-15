<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo01_ValidationControls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 209px;
        }
        .auto-style3 {
            width: 327px;
        }
        .auto-style4 {
            width: 209px;
            height: 33px;
        }
        .auto-style5 {
            width: 327px;
            height: 33px;
        }
        .auto-style6 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rvfName" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is required" ForeColor="#FF3300" ValidationGroup="RegisterValidations">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Enter Age"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvAge" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Age is required" ForeColor="#FF3300" ValidationGroup="RegisterValidations">*</asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Must be between 18 and 58" ForeColor="#FF3300" MaximumValue="58" MinimumValue="18" Type="Integer" ValidationGroup="RegisterValidations">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Enter Email"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid email address" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="RegisterValidations">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Enter password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="TextBox4" ErrorMessage="Password is mandatory" ForeColor="#FF3300" ValidationGroup="RegisterValidations">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="cvConfirmPassword" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Password mis-match" ForeColor="#FF3300" ValidationGroup="RegisterValidations">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label6" runat="server" Text="Enter Date of Birth"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:CustomValidator ID="cusValDateOfBirth" runat="server" ControlToValidate="TextBox6" ErrorMessage="Must be 18 years old" ForeColor="#FF3300" OnServerValidate="cusValDateOfBirth_ServerValidate" ValidationGroup="RegisterValidations">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Choose City"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Bengaluru</asp:ListItem>
                        <asp:ListItem>Kolkata</asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="DropDownList1" ErrorMessage="City is required" ForeColor="#FF3300" InitialValue="--Select--" ValidationGroup="RegisterValidations">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" ValidationGroup="RegisterValidations" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="RegisterValidations" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Enter Username"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox7" ErrorMessage="RequiredFieldValidator" ValidationGroup="LoginValidation"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text="Enter password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox8" ErrorMessage="RequiredFieldValidator" ValidationGroup="LoginValidation"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" Text="Login" ValidationGroup="LoginValidation" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Reset" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
