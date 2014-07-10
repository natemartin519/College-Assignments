<!--
Nathan Martin
PROG1410 - ASP.NET
Assignment 2
UserInformation.aspx
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInformation.aspx.cs" Inherits="UserInformation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enter User Information</title>
    <style type="text/css">
        .colWidth
        {
            width: 125px;
        }
    </style>
</head>
<body>
    <form id="userInformation" runat="server">
    <div>
        <h3>Input User Information</h3>
        <table>
            <tr>
                <td class="colWidth">
                    First Name:
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First name is required."
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="colWidth">
                    Last Name:
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Last name is required."
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="colWidth">
                    Phone Number:
                </td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" Display="Dynamic" ErrorMessage="Phone number is required."
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rexPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" Display="Dynamic" ErrorMessage="Invalid phone number; Please use (999) 999-9999"
                        ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="colWidth">
                    Email Address:
                </td>
                <td>
                    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic" ErrorMessage="Email address is required."
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rexEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic"
                        ErrorMessage="Invalid email address; Please use username@domain.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="vsumSummary" runat="server" HeaderText="<br />Please correct the following errors:" />
    </div>
    </form>
</body>
</html>
