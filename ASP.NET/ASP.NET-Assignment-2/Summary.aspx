<!--
Nathan Martin
PROG1410 - ASP.NET
Assignment 2
Summary.aspx
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="Summary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Information Summary</title>
    <style type="text/css">
        .colWidth
        {
            width: 125px;
        }
    </style>
</head>
<body>
    <form id="summary" runat="server">
    <h3>User Information Summary</h3>
    <div>
        <table>
            <tr>
                <td class="colWidth">
                    First Name:
                </td>
                <td>
                    <asp:Label ID="lblFirstName" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="colWidth">
                    Last Name:
                </td>
                <td>
                    <asp:Label ID="lblLastName" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="colWidth">
                    Phone Number:
                </td>
                <td>
                    <asp:Label ID="lblPhoneNumber" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="colWidth">
                    Email Address:
                </td>
                <td>
                    <asp:Label ID="lblEmailAddress" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
