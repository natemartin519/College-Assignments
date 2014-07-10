//Nathan Martin
//PROG1410 - ASP.NET
//Assignment 2
//Summary.aspx.cs

using System;
using System.Web;

public partial class Summary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User userSummary = (User)HttpContext.Current.Session["User"];

        if (userSummary != null)
        {
            lblFirstName.Text = userSummary.FirstName;
            lblLastName.Text = userSummary.LastName;
            lblPhoneNumber.Text = userSummary.PhoneNumber;
            lblEmailAddress.Text = userSummary.EmailAddress;
        }
        else
        {
            Response.Redirect("UserInformation.aspx");
        }
    }
}