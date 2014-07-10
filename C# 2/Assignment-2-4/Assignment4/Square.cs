// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// Square.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Square : RegularPolygon
    {
        // Constants
        private const int NUMBER_OF_SIDES = 4;


        // Constructors
        public Square(double sideLength) : base(NUMBER_OF_SIDES, sideLength) { }


        // Calculations
        public override double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
