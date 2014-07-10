<%--
Nathan Martin
PROG1410 - ASP.NET
Assignment 3
Summary.aspx
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="Summary" MasterPageFile="Default.master" %>

<asp:Content ID="Body" ContentPlaceHolderID="BodyContentPlaceHolder" runat="server">
    <h3>Survey Summary</h3>

    <asp:Label ID="lblFirstName" runat="server" Text="First Name:" />
    <asp:Label ID="lblDisplayFirstName" runat="server" SkinID="Display" Text="Label" />
    <br />

    <asp:Label ID="lblLastName" runat="server" Text="Last Name:" />
    <asp:Label ID="lblDisplayLastName" runat="server" SkinID="Display" Text="Label" />
    <br />

    <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:" />
    <asp:Label ID="lblDisplayPhoneNumber" runat="server" SkinID="Display" Text="Label" />
    <br />

    <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:" />
    <asp:Label ID="lblDisplayEmailAddress" runat="server" SkinID="Display" Text="Label" />
</asp:Content>
