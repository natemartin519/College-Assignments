// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// Triangle.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class Triangle : RegularPolygon
    {
        // Constants
        private const int NUMBER_OF_SIDES = 3;
        private const double MULTIPLICATION_CONSTANT = 0.433;


        // Constructors
        public Triangle(double sideLength) : base(NUMBER_OF_SIDES, sideLength) { }


        // Calculations
        public override double CalculateArea()
        {
            return MULTIPLICATION_CONSTANT * Math.Pow(SideLength, 2);
        }
    }
}
