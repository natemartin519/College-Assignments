<!--
Nathan Martin
PROG1410 - ASP.NET
Assignment 1
Temperature.aspx
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Temperature.aspx.cs" Inherits="Temperature" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmConvert" runat="server">
    <div style="padding: 5px 10px 10px 5px; border-style: solid; border-width: thin; position: absolute;">
        <h2 style="margin-top: 0px">Temperature Conversion<br /></h2>

        <span>Enter the temperature:</span>&nbsp;
        <asp:TextBox ID="txtFahrenheit" runat="server" style="text-align:right" Width="50px"></asp:TextBox> &#176F&nbsp;
        <asp:Button ID="btnConvert" runat="server" Text="=" onclick="Convert_Temperature" />&nbsp;
        <asp:TextBox ID="txtCelsius" runat="server" style="text-align:right" Width="50px" Enabled="False"></asp:TextBox> &#176C
    </div>
    </form>   
</body>
</html>
