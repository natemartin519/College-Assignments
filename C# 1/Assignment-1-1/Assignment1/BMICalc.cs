// Nathan Martin
// PROG1720 - Visual C#.NET I
// Assignment 1

using System;

namespace Assignment1
{
    class BMICalc
    {
        static void Main(string[] args)
        {
            double weight = 0.0;
            double height = 0.0;
            double BMI = 0.0;

 
            Console.Write("Please enter you weight(kg): ");
            weight = double.Parse (Console.ReadLine());

            Console.Write("Please enter your height(m): ");
            height = double.Parse(Console.ReadLine());


            BMI = weight / Math.Pow(height,2);


            Console.WriteLine("\n\nYour BMI is: {0:F1}", BMI);

            // Display BMI chart
            Console.WriteLine("\nBMI VALUES:");
            Console.WriteLine("{0,-15}{1}", "Underweight:", "less than 18.5");
            Console.WriteLine("{0,-15}{1}", "Normal:", "between 18.5 and 24.9");
            Console.WriteLine("{0,-15}{1}", "Overweight:", "between 25 and 29.9");
            Console.WriteLine("{0,-15}{1}", "Obese:", "30 or greater");

            Console.Read();
        }
    }
}
