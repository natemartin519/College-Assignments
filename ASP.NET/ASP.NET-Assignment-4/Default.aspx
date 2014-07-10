<%--
Nathan Martin
PROG1410 - ASP.NET
Assignment 4
Default.aspx
--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<asp:Content ID="Body" ContentPlaceHolderID="BodyContentPlaceHolder" Runat="Server">   
    
    <ul>
        <li class="searchRow">
            <asp:Label ID="SearchLabel" runat="server" Text="Last Name:" />
            <asp:TextBox ID="SearchTextBox" runat="server" />
            <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" />
        </li>
        <li class="messageRow">
            <asp:Label ID="MessageLabel" runat="server" SkinID="Message" />
        </li>
    </ul>
     
    <asp:ListView 
        ID="AddressesListView" 
        runat="server" 
        DataSourceID="AddressesSqlDataSource" 
        DataKeyNames="AddressID" 
        InsertItemPosition="LastItem" 
        OnItemDeleted="AddressesListView_ItemDeleted" 
        OnItemInserted="AddressesListView_ItemInserted" 
        OnItemInserting="AddressesListView_ItemInserting" 
        OnItemUpdated="AddressesListView_ItemUpdated" 
        OnItemUpdating="AddressesListView_ItemUpdating"
    >       
          <ItemTemplate>
            <li class="row">
                <asp:Label ID="AddressLabel" runat="server" Text="Address ID:" />
                <asp:Label ID="AddressIDField" SkinID="Long" runat="server" Text='<%# Bind("AddressID") %>' />
                <br />
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:" />
                <asp:Label ID="FirstNameField" SkinID="Long" runat="server" Text='<%# Bind("FirstName") %>' />

                <asp:Label ID="EmailLabel" runat="server" Text="Email:" />
                <asp:Label ID="EmailField" SkinID="Long" runat="server" Text='<%# Bind("Email") %>' />
                <br />
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:" />
                <asp:Label ID="LastNameField" SkinID="Long" runat="server" Text='<%# Bind("LastName") %>' />

                <asp:Label ID="PhoneNumberLabel" runat="server" Text="Phone #:" />
                <asp:Label ID="PhoneNumberField" SkinID="Long" runat="server" Text='<%# Bind("PhoneNumber") %>' />
                <br /><br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </li>
        </ItemTemplate>
        
        <AlternatingItemTemplate>
            <li class="altRow">
                <asp:Label ID="AddressLabel" runat="server" Text="Address ID:" />
                <asp:Label ID="AddressIDField" SkinID="Long" runat="server" Text='<%# Bind("AddressID") %>' />
                <br />
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:" />
                <asp:Label ID="FirstNameField" SkinID="Long" runat="server" Text='<%# Bind("FirstName") %>' />

                <asp:Label ID="EmailLabel" runat="server" Text="Email:" />
                <asp:Label ID="EmailField" SkinID="Long" runat="server" Text='<%# Bind("Email") %>' />
                <br />
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:" />
                <asp:Label ID="LastNameField" SkinID="Long" runat="server" Text='<%# Bind("LastName") %>' />

                <asp:Label ID="PhoneNumberLabel" runat="server" Text="Phone #:" />
                <asp:Label ID="PhoneNumberField" SkinID="Long" runat="server" Text='<%# Bind("PhoneNumber") %>' />
                <br /><br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </li>
        </AlternatingItemTemplate>

        <EditItemTemplate>
            <li class="editRow">
                <asp:Label ID="AddressLabel" runat="server" Text="Address ID:" />
                <asp:Label ID="AddressIDField" runat="server" Text='<%# Eval("AddressID") %>' />
                <br />
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:" />
                <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                <asp:RequiredFieldValidator ID="FirstNameRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="FirstNameTextBox" ValidationGroup="Update" />

                <asp:Label ID="EmailLabel" runat="server" Text="Email:" />
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="EmailTextBox" ValidationGroup="Update" Display="Dynamic" />               
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="Format: name@domain.com" ControlToValidate="EmailTextBox" ValidationGroup="Update" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />

                <br />
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:" />
                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="LastNameTextBox" ValidationGroup="Update" />

                <asp:Label ID="PhoneNumberLabel" runat="server" Text="Phone #:" />
                <asp:TextBox ID="PhoneNumberTextBox" runat="server" Text='<%# Bind("PhoneNumber") %>' />
                <asp:RequiredFieldValidator ID="PhoneNumberRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="PhoneNumberTextBox" ValidationGroup="Update" Display="Dynamic" />               
                <asp:RegularExpressionValidator ID="PhoneNumberRegularExpressionValidator" runat="server" ErrorMessage="Format: (###) ###-####" ControlToValidate="PhoneNumberTextBox" ValidationGroup="Update" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" />
          
                <br /><br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" ValidationGroup="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </li>
        </EditItemTemplate>
        
        <EmptyDataTemplate>
            <li>
                <h3>No data was returned.</h3>
            </li>          
        </EmptyDataTemplate>
        
        <InsertItemTemplate>
            <li class="insertRow">
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name:" />
                <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
                <asp:RequiredFieldValidator ID="FirstNameRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="FirstNameTextBox" ValidationGroup="Insert" />
                
                <asp:Label ID="EmailLabel" runat="server" Text="Email:" />
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="EmailTextBox" ValidationGroup="Insert" Display="Dynamic" />               
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="Format: name@domain.com" ControlToValidate="EmailTextBox" ValidationGroup="Insert" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                
                <br />
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name:" />
                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="LastNameTextBox" ValidationGroup="Insert" />
                
                <asp:Label ID="PhoneNumberLabel" runat="server" Text="Phone #:" />
                <asp:TextBox ID="PhoneNumberTextBox" runat="server" Text='<%# Bind("PhoneNumber") %>' />
                <asp:RequiredFieldValidator ID="PhoneNumberRequiredFieldValidator" runat="server" ErrorMessage="*" ControlToValidate="PhoneNumberTextBox" ValidationGroup="Insert" Display="Dynamic" />               
                <asp:RegularExpressionValidator ID="PhoneNumberRegularExpressionValidator" runat="server" ErrorMessage="Format: (###) ###-####" ControlToValidate="PhoneNumberTextBox" ValidationGroup="Insert" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" />
                
                <br /><br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" ValidationGroup="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </li>
        </InsertItemTemplate>

        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" >
                <li runat="server" id="itemPlaceholder" />
            </ul>
        </LayoutTemplate>
    </asp:ListView>


    <asp:SqlDataSource 
        ID="AddressesSqlDataSource" 
        runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:AddressConnectionString %>" 
        OldValuesParameterFormatString="original_{0}" 
        DeleteCommand="
            DELETE FROM [Addresses] 
            WHERE [AddressID] = @original_AddressID 
            AND [FirstName] = @original_FirstName 
            AND [LastName] = @original_LastName 
            AND [Email] = @original_Email 
            AND [PhoneNumber] = @original_PhoneNumber" 
        InsertCommand="
            INSERT INTO [Addresses] ([FirstName], [LastName], [Email], [PhoneNumber]) 
            VALUES (@FirstName, @LastName, @Email, @PhoneNumber)"         
        SelectCommand="
            SELECT * 
            FROM [Addresses] 
            WHERE ([LastName] 
            LIKE '%' + @LastName + '%')" 
        UpdateCommand="
            UPDATE [Addresses] 
            SET [FirstName] = @FirstName, [LastName] = @LastName, [Email] = @Email, [PhoneNumber] = @PhoneNumber 
            WHERE [AddressID] = @original_AddressID 
            AND [FirstName] = @original_FirstName 
            AND [LastName] = @original_LastName 
            AND [Email] = @original_Email 
            AND [PhoneNumber] = @original_PhoneNumber"
    >       
        
        <DeleteParameters>
            <asp:Parameter Name="original_AddressID" Type="Int32" />
            <asp:Parameter Name="original_FirstName" Type="String" />
            <asp:Parameter Name="original_LastName" Type="String" />
            <asp:Parameter Name="original_Email" Type="String" />
            <asp:Parameter Name="original_PhoneNumber" Type="String" />
        </DeleteParameters>
       
         <InsertParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="PhoneNumber" Type="String" />
        </InsertParameters>
       
         <SelectParameters>
             <asp:SessionParameter Name="LastName" SessionField="SearchString" Type="String" DefaultValue="%" />
        </SelectParameters>
       
         <UpdateParameters>
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Email" Type="String" />
            <asp:Parameter Name="PhoneNumber" Type="String" />
            <asp:Parameter Name="original_AddressID" Type="Int32" />
            <asp:Parameter Name="original_FirstName" Type="String" />
            <asp:Parameter Name="original_LastName" Type="String" />
            <asp:Parameter Name="original_Email" Type="String" />
            <asp:Parameter Name="original_PhoneNumber" Type="String" />
        </UpdateParameters>
    
    </asp:SqlDataSource>
</asp:Content>

