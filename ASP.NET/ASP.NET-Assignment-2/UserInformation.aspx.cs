//Nathan Martin
//PROG1410 - ASP.NET
//Assignment 2
//UserInformation.aspx.cs

using System;
using System.Web;

public partial class UserInformation : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Clear();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            HttpContext.Current.Session["User"] = new User(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmailAddress.Text);
            Response.Redirect("Summary.aspx");
        }
    }
}