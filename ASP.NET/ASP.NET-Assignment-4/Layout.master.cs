/*
Nathan Martin
PROG1410 - ASP.NET
Assignment 4
Layout.master.cs
*/

using System;

public partial class Layout : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e) 
    {
        Session["SearchString"] = String.Empty;
    }
}
