// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 3
// FlightProgram.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment3
{
    static class FlightProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SeatingPrompt());
        }
    }
}
