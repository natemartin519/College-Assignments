// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// Pentagon.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Pentagon : RegularPolygon
    {
        // Constants
        private const int NUMBER_OF_SIDES = 5;
        private const double MULTIPLICATION_CONSTANT = 1.72;


        // Constructors
        public Pentagon(double sideLength) : base(NUMBER_OF_SIDES, sideLength) { }


        // Calculations
        public override double CalculateArea()
        {
            return MULTIPLICATION_CONSTANT * Math.Pow(SideLength, 2);
        }
    }
}
