//Nathan Martin
//PROG1410 - ASP.NET
//Assignment 2
//User.cs



public class User
{
    public string FirstName { get; set; }
    public string LastName{ get; set; }
    public string PhoneNumber{ get; set; }
    public string EmailAddress{ get; set; }

    public User(string firstName, string lastName, string phoneNumber, string emailAddress) 
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.PhoneNumber = phoneNumber;
        this.EmailAddress = emailAddress;
    }
}