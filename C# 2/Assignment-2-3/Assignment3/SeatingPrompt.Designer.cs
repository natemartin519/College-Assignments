// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 3
// SeatingPrompt.Designer.cs

namespace Assignment3
{
    partial class SeatingPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.groSelectSeat = new System.Windows.Forms.GroupBox();
            this.rbFirstClass = new System.Windows.Forms.RadioButton();
            this.rbEconomy = new System.Windows.Forms.RadioButton();
            this.groSelectSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(90, 140);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select Seat";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groSelectSeat
            // 
            this.groSelectSeat.Controls.Add(this.rbFirstClass);
            this.groSelectSeat.Controls.Add(this.rbEconomy);
            this.groSelectSeat.Location = new System.Drawing.Point(21, 23);
            this.groSelectSeat.Name = "groSelectSeat";
            this.groSelectSeat.Size = new System.Drawing.Size(232, 100);
            this.groSelectSeat.TabIndex = 0;
            this.groSelectSeat.TabStop = false;
            this.groSelectSeat.Text = "Seat Selection";
            // 
            // rbFirstClass
            // 
            this.rbFirstClass.AutoSize = true;
            this.rbFirstClass.Location = new System.Drawing.Point(21, 57);
            this.rbFirstClass.Name = "rbFirstClass";
            this.rbFirstClass.Size = new System.Drawing.Size(72, 17);
            this.rbFirstClass.TabIndex = 1;
            this.rbFirstClass.TabStop = true;
            this.rbFirstClass.Text = "First Class";
            this.rbFirstClass.UseVisualStyleBackColor = true;
            // 
            // rbEconomy
            // 
            this.rbEconomy.AutoSize = true;
            this.rbEconomy.Location = new System.Drawing.Point(21, 34);
            this.rbEconomy.Name = "rbEconomy";
            this.rbEconomy.Size = new System.Drawing.Size(97, 17);
            this.rbEconomy.TabIndex = 0;
            this.rbEconomy.TabStop = true;
            this.rbEconomy.Text = "Economy Class";
            this.rbEconomy.UseVisualStyleBackColor = true;
            // 
            // SeatingPrompt
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groSelectSeat);
            this.Name = "SeatingPrompt";
            this.Text = "Airling Seating POS";
            this.groSelectSeat.ResumeLayout(false);
            this.groSelectSeat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groSelectSeat;
        private System.Windows.Forms.RadioButton rbFirstClass;
        private System.Windows.Forms.RadioButton rbEconomy;
    }
}

