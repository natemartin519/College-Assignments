// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// RegularPolygon.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public abstract class RegularPolygon
    {
        private readonly double _sideLength;
        private readonly int _numberOfSides;
        
        // Properties
        public double SideLength 
        {
            get { return this._sideLength; }
        }


        // Constructors
        public RegularPolygon(int numberOfSides, double sideLength) 
        { 
            this._sideLength = sideLength;
            this._numberOfSides = numberOfSides;
        }


        // Abstract Methods        
        public abstract double CalculateArea();


        // Calculations
        public double CalculatePerimeter(){
            return _numberOfSides * _sideLength;
        }
    }
}
