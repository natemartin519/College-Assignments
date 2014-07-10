// Nathan Martin
// PROG1720 - Visual C#.NET I
// Assignment 3
// HeartRateCalculator.cs

using System;

namespace Assignment3
{
    class HeartRateCalculator
    {

        static void Main(string[] args)
        {
            string userFirstName = "";
            string userLastName = "";
            int userBirthYear = 0;
            int userCurrentYear = 0;

            // Get user's input from the console
            Console.Write("Please enter your first name: ");
            userFirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            userLastName = Console.ReadLine();

            Console.Write("Please enter your birth year: ");
            userBirthYear = int.Parse(Console.ReadLine());

            Console.Write("Please enter the current year: ");
            userCurrentYear = int.Parse(Console.ReadLine());

            HeartRates userHeartRate = new HeartRates(userFirstName, userLastName, userBirthYear, userCurrentYear);


            // Display user's heart rate information
            Console.WriteLine(userHeartRate);

            Console.Read();
        }
    }
}
