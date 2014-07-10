//Nathan Martin
//PROG1410 - ASP.NET
//Assignment 3
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
            lblDisplayFirstName.Text = userSummary.FirstName;
            lblDisplayLastName.Text = userSummary.LastName;
            lblDisplayPhoneNumber.Text = userSummary.PhoneNumber;
            lblDisplayEmailAddress.Text = userSummary.EmailAddress;
        }
        else
        {
            Response.Redirect("UserInformation.aspx");
        }
    }
}