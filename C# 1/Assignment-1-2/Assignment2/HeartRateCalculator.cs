// Nathan Martin
// PROG1720 - Visual C#.NET I
// Assignment 2

using System;

namespace Assignment2
{
    class HeartRateCalculator
    {

        private const int MHR_BASE_NUMBER = 220;
        private const double MAX_THR_MULTIPLIER = 0.85;
        private const double MIN_THR_MULTIPLIER = 0.5;

        private static int userCurrentYear = 0, 
            userBirthYear = 0,
            userAge = 0, 
            userMhr = 0;

        private static string userLastName = "", 
            userFirstName = "";


        static void Main(string[] args)
        {
            GetUserInformation();

            userAge = CalculateAge(userBirthYear, userCurrentYear);
            userMhr = CalculateMhr(userAge);

            DisplayHeartRateInformation();

            Console.Read();
        }


        // Get user's input from the console
        private static void GetUserInformation() {
            Console.Write("Please enter your first name: ");
            userFirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            userLastName = Console.ReadLine();

            Console.Write("Please enter your birth year: ");
            userBirthYear = int.Parse(Console.ReadLine());

            Console.Write("Please enter the current year: ");
            userCurrentYear = int.Parse(Console.ReadLine());

            return;
        }

        // Display user's heart rate information
        private static void DisplayHeartRateInformation()
        {
            Console.WriteLine("{0}, you are {1} years old;", userFirstName + " " + userLastName, userAge);
            Console.WriteLine("Your MHR is {0}BPM, minimum THR is {1}BPM, and maximum THR is {2}BPM", userMhr, CalculateMinThr(userMhr), CalculateMaxThr(userMhr));
            return;
        }


        // Calculate user's age
        private static int CalculateAge(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }

        // Calculate user's maximun heart rate
        private static int CalculateMhr(int age)
        {
            return MHR_BASE_NUMBER - age;
        }

        // Calculate user's maximum target heart rate
        private static int CalculateMaxThr(int mhr)
        {
            return (int)Math.Round(mhr * MAX_THR_MULTIPLIER, 0);
        }

        // Calculate user's minimum target heart rate
        private static int CalculateMinThr(int mhr)
        {
            return (int)Math.Round(mhr * MIN_THR_MULTIPLIER, 0); 
        }
    }
}
