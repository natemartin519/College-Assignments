// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 2
// TemperatureForm.Designer.cs

namespace Assignment2
{
    partial class TemperatureForm
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(131, 80);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 40);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(57, 31);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(100, 26);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit:";
            this.lblFahrenheit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.Location = new System.Drawing.Point(163, 31);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(160, 26);
            this.txtFahrenheit.TabIndex = 0;
            // 
            // lblCelsius
            // 
            this.lblCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(33, 143);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(320, 40);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureForm
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnConvert);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "TemperatureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
    }
}

