// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// RegularPolygonCaculator.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment4
{

    public partial class RegularPolygonCalculator : Form
    {
        public RegularPolygonCalculator()
        {
            InitializeComponent();
        }


        // Button Methods
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length;

            // TryParse method must be evaluated first so it can set the length variable
            if (Double.TryParse(txtLength.Text, out length) && length > 0)
            {
                RegularPolygon selectedPolygon;

                // Select child class based on what radio button the user has selected
                if (rbTriangle.Checked)
                {
                    selectedPolygon = new Triangle(length);
                }
                else if (rbSquare.Checked)
                {
                    selectedPolygon = new Square(length);
                }
                else
                {
                    selectedPolygon = new Pentagon(length);
                }

                // Calculate and display the perimeter and area of the regular polygon
                lblCalculatedPerimeter.Text = String.Format("{0}", selectedPolygon.CalculatePerimeter());
                lblCalculatedArea.Text = String.Format("{0}", selectedPolygon.CalculateArea());
            }
            else 
            {
                MessageBox.Show("You have entered an invaild length.\nPlease enter a positive numeric value and try agian.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAllFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }


        // Misc. Methods
        private void ClearAllFields() {
            txtLength.Clear();
            lblCalculatedArea.Text = "";
            lblCalculatedPerimeter.Text = "";       
        }
    }
}
