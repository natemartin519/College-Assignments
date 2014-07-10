/*
Nathan Martin
PROG1410 - ASP.NET
Assignment 4
Default.aspx.cs
*/

using System;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MessageLabel.Text = String.Empty;
    }


    protected void SearchButton_Click(object sender, EventArgs e)
    {
        Session["SearchString"] = SearchTextBox.Text.Trim();
        SearchTextBox.Text = String.Empty;
    }


    protected void AddressesListView_ItemDeleted(object sender, System.Web.UI.WebControls.ListViewDeletedEventArgs e)
    {
        if (e.Exception != null)
        {
            MessageLabel.Text = "A database error has occurred.<br /><br />Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else if (e.AffectedRows == 0)
        {
            MessageLabel.Text = "Unable to delete record; please try agian.";
        }
        else
        {
            MessageLabel.Text = "Record deleted.";
        }
    }    
    

    protected void AddressesListView_ItemInserting(object sender, System.Web.UI.WebControls.ListViewInsertEventArgs e)
    {
        if (!IsValid)
        {
            e.Cancel = true;
            MessageLabel.Text = "Unable to insert record; please try agian.";
        }
    }

    protected void AddressesListView_ItemInserted(object sender, System.Web.UI.WebControls.ListViewInsertedEventArgs e)
    {
        if (e.Exception != null)
        {
            MessageLabel.Text = "A database error has occurred.<br />Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            MessageLabel.Text = "Record created.";
        }
    }


    protected void AddressesListView_ItemUpdating(object sender, System.Web.UI.WebControls.ListViewUpdateEventArgs e)
    {
        if (!IsValid)
        {
            e.Cancel = true;
            MessageLabel.Text = "Unable to update record; please try agian.";
        }
    }

    protected void AddressesListView_ItemUpdated(object sender, System.Web.UI.WebControls.ListViewUpdatedEventArgs e)
    {
        if (e.Exception != null)
        {
            MessageLabel.Text = "A database error has occurred.<br />Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
            e.KeepInEditMode = true;
        }
        else if (e.AffectedRows == 0)
        {
            MessageLabel.Text = "Unable to update record; please try agian.";
        }
        else
        {
            MessageLabel.Text = "Record updated.";
        }
    }
}