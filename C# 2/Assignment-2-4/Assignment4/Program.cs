// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegularPolygonCalculator());
        }
    }
}
