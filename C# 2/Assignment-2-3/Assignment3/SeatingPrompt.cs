// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 3
// SeatingPrompt.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class SeatingPrompt : Form
    {

        private const int SECTION_CUTOFF = 5;
        private const int TOTAL_SEATS = 21;

        private bool[] seatingChart = new bool[TOTAL_SEATS];


        public SeatingPrompt()
        {
            InitializeComponent();
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            if (rbEconomy.Checked)
            {
                // Try to assign an economy seat, ask to switch to first class if all economy seats are full
                if (!AssignEconomySeat())
                {
                    // Setup message box display
                    string messageBody = "The Economy section is full, would you like to switch to First Class?";
                    string messageHead = "Economy Section Full";

                    if (MessageBox.Show(messageBody, messageHead, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Try to assign a first class seat, dislay message if none are available
                        if (!AssignFirstClassSeat())
                        {
                            MessageBox.Show("Flight Full: Next flight leaves in 3 hours.", "Flight Full", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                        }
                    }
                    else
                    {
                        MessageBox.Show(messageHead + ": Next flight leaves in 3 hours.", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                    
            }
            else
            {
                // Try to assign a first class seat, ask to switch to economy if all economy seats are full
                if (!AssignFirstClassSeat())
                {
                    // Setup message box display
                    string messageBody = "The First Class section is full, would you like to switch to Economy?";
                    string messageHead = "First Class Section Full";

                    if (MessageBox.Show(messageBody, messageHead, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
                    {
                        // Try to assign an economy seat, dislay message if none are available
                        if (!AssignEconomySeat())
                        {
                            MessageBox.Show("Flight Full: Next flight leaves in 3 hours.", "Flight Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(messageHead + ": Next flight leaves in 3 hours.", messageHead, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }             
            }
        }



        // Seat Assignment Methods
        private bool AssignEconomySeat() 
        {
            for (int x = SECTION_CUTOFF; x < TOTAL_SEATS; x++)
            {
                if (!seatingChart[x])
                {
                    seatingChart[x] = true;
                    return true;
                }
            }

            return false;
        }
        
        
        private bool AssignFirstClassSeat() 
        {
            for (int x = 0; x < SECTION_CUTOFF; x++)
            {
                if (!seatingChart[x])
                {
                    seatingChart[x] = true;
                    return true;
                }
            }

            return false;       
        }
    }
}
