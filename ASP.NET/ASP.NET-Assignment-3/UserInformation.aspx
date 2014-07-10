<%--
Nathan Martin
PROG1410 - ASP.NET
Assignment 3
UserInformation.aspx
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInformation.aspx.cs" Inherits="UserInformation" MasterPageFile="Default.master" %>

<asp:Content ID="Body" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <h3>User Information Survey</h3>

    <asp:Label ID="lblFirstName" runat="server" Text="First Name:" />
    <asp:TextBox ID="txtFirstName" runat="server" />
    <asp:RequiredFieldValidator ID="reqFirstName" runat="server" ControlToValidate="txtFirstName" 
        Display="Dynamic" ErrorMessage="First name is required.">*
    </asp:RequiredFieldValidator>
    <br />


    <asp:Label ID="lblLastName" runat="server" Text="Last Name:" />
    <asp:TextBox ID="txtLastName" runat="server" />
    <asp:RequiredFieldValidator ID="reqLastName" runat="server" ControlToValidate="txtLastName" 
        Display="Dynamic" ErrorMessage="Last name is required.">*
    </asp:RequiredFieldValidator>
    <br />


    <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:" />
    <asp:TextBox ID="txtPhoneNumber" runat="server" />
    <asp:RequiredFieldValidator ID="reqPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" 
        Display="Dynamic" ErrorMessage="Phone number is required.">*
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="rexPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber" 
        Display="Dynamic" ErrorMessage="Invalid phone number; Please use (999) 999-9999"
        ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">*
    </asp:RegularExpressionValidator>
    <br />


    <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:" />
    <asp:TextBox ID="txtEmailAddress" runat="server" />
    <asp:RequiredFieldValidator ID="reqEmailAddress" runat="server" ControlToValidate="txtEmailAddress" 
        Display="Dynamic" ErrorMessage="Email address is required.">*
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="rexEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic"
        ErrorMessage="Invalid email address; Please use username@domain.com" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*
    </asp:RegularExpressionValidator>
    <br />


    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    <br />

    <asp:ValidationSummary ID="vsumSummary" runat="server" HeaderText="<br />Please correct the following errors:" />
</asp:Content>