// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 2
// TemperatureForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class TemperatureForm : Form
    {
        public TemperatureForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double fahrenheit = double.Parse(txtFahrenheit.Text);
            double celsius = ((5.0 / 9.0) * (fahrenheit - 32));

            lblCelsius.Text = String.Format("{0:F2}°C", celsius).ToString();
        }
    }
}
