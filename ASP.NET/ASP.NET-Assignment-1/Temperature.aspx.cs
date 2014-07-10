// Nathan Martin
// PROG1410 - ASP.NET
// Assignment 1
// Temperature.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Temperature : System.Web.UI.Page
{

    protected void Convert_Temperature(object sender, EventArgs e)
    {

        int fahrenheit = 0;

        if (Int32.TryParse(txtFahrenheit.Text, out fahrenheit))
        {
            int celsius = 5 * (fahrenheit - 32) / 9;
            txtCelsius.Text = celsius.ToString();
        }
        else 
        {
            txtCelsius.Text = "Error";
        }
    }
}