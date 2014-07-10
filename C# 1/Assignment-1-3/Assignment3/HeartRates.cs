// Nathan Martin
// PROG1720 - Visual C#.NET I
// Assignment 3
// HeartRates.cs

using System;


namespace Assignment3
{
    internal class HeartRates
    {
        // Constants
        private const int MHR_BASE_NUMBER = 220;
        private const double MAX_THR_MULTIPLIER = 0.85;
        private const double MIN_THR_MULTIPLIER = 0.5;


        // Auto-Implemented Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int CurrentYear { get; set; }


        // Constructors
        public HeartRates(string constructFirstName, string constructLastName, int constructBirthYear, int constructCurrentYear) 
        {            
            FirstName = constructFirstName;
            LastName = constructLastName;
            BirthYear = constructBirthYear;
            CurrentYear = constructCurrentYear;
        }
    
        
        // Calculations
        public int CalculateAge()
        {
            return CurrentYear - BirthYear;
        }

        public int CalculateMaxHeartRate()
        {
            return MHR_BASE_NUMBER - CalculateAge();
        }

        public int CalculateMaxThr()
        {
            return (int)Math.Round(CalculateMaxHeartRate() * MAX_THR_MULTIPLIER, 0);
        }

        public int CalculateMinThr()
        {
            return (int)Math.Round(CalculateMaxHeartRate() * MIN_THR_MULTIPLIER, 0);
        }


        // Display readout
        public override string ToString()
        {
            return FirstName + " " + LastName + ", you are " + CalculateAge() + " years old:\n" +
                "Your maximum heart rate is " + CalculateMaxHeartRate() + "BPM\n" + 
                "Your minimum target heart rate is " + CalculateMinThr() + "BPM\n" + 
                "Your maximum target heart rate is " + CalculateMaxThr() + "BPM.";
        }
    }
}
