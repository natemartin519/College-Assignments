// Nathan Martin
// PROG1400 - Visual C#.NET II
// Assignment 4
// RegularPolygonCalculator.Designer.cs

namespace Assignment4
{
    partial class RegularPolygonCalculator
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
            this.grbShapeSelect = new System.Windows.Forms.GroupBox();
            this.rbPentagon = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCalculatedPerimeter = new System.Windows.Forms.Label();
            this.lblCalculatedArea = new System.Windows.Forms.Label();
            this.grbShapeSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbShapeSelect
            // 
            this.grbShapeSelect.Controls.Add(this.rbPentagon);
            this.grbShapeSelect.Controls.Add(this.rbSquare);
            this.grbShapeSelect.Controls.Add(this.rbTriangle);
            this.grbShapeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShapeSelect.Location = new System.Drawing.Point(28, 27);
            this.grbShapeSelect.Margin = new System.Windows.Forms.Padding(4);
            this.grbShapeSelect.Name = "grbShapeSelect";
            this.grbShapeSelect.Padding = new System.Windows.Forms.Padding(4);
            this.grbShapeSelect.Size = new System.Drawing.Size(192, 161);
            this.grbShapeSelect.TabIndex = 0;
            this.grbShapeSelect.TabStop = false;
            this.grbShapeSelect.Text = "Select a Shape";
            // 
            // rbPentagon
            // 
            this.rbPentagon.AutoSize = true;
            this.rbPentagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPentagon.Location = new System.Drawing.Point(27, 112);
            this.rbPentagon.Margin = new System.Windows.Forms.Padding(4);
            this.rbPentagon.Name = "rbPentagon";
            this.rbPentagon.Size = new System.Drawing.Size(84, 20);
            this.rbPentagon.TabIndex = 2;
            this.rbPentagon.TabStop = true;
            this.rbPentagon.Text = "Pentagon";
            this.rbPentagon.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSquare.Location = new System.Drawing.Point(27, 74);
            this.rbSquare.Margin = new System.Windows.Forms.Padding(4);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(70, 20);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTriangle.Location = new System.Drawing.Point(27, 36);
            this.rbTriangle.Margin = new System.Windows.Forms.Padding(4);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(76, 20);
            this.rbTriangle.TabIndex = 0;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(350, 63);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtLength.MaxLength = 16;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(132, 22);
            this.txtLength.TabIndex = 1;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(289, 69);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(51, 16);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length:";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(271, 113);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(69, 16);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "Perimeter:";
            this.lblPerimeter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(300, 150);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 16);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area:";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(368, 204);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 28);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(368, 239);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCalculatedPerimeter
            // 
            this.lblCalculatedPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculatedPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedPerimeter.Location = new System.Drawing.Point(350, 101);
            this.lblCalculatedPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedPerimeter.Name = "lblCalculatedPerimeter";
            this.lblCalculatedPerimeter.Size = new System.Drawing.Size(133, 28);
            this.lblCalculatedPerimeter.TabIndex = 9;
            this.lblCalculatedPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCalculatedArea
            // 
            this.lblCalculatedArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculatedArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedArea.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCalculatedArea.Location = new System.Drawing.Point(350, 138);
            this.lblCalculatedArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedArea.Name = "lblCalculatedArea";
            this.lblCalculatedArea.Size = new System.Drawing.Size(133, 28);
            this.lblCalculatedArea.TabIndex = 10;
            this.lblCalculatedArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegularPolygonCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 304);
            this.Controls.Add(this.lblCalculatedArea);
            this.Controls.Add(this.lblCalculatedPerimeter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.grbShapeSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegularPolygonCalculator";
            this.Text = "Regular Polygon Calculator";
            this.grbShapeSelect.ResumeLayout(false);
            this.grbShapeSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbShapeSelect;
        private System.Windows.Forms.RadioButton rbPentagon;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCalculatedPerimeter;
        private System.Windows.Forms.Label lblCalculatedArea;
    }
}

