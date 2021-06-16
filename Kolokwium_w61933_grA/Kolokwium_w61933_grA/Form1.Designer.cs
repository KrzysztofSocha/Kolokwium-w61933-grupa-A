
namespace Kolokwium_w61933_grA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.bChangeColor = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(70, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 98);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(195, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 98);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(327, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 98);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(70, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 98);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(195, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 98);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(327, 186);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 98);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(70, 309);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 98);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(195, 309);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 98);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(327, 309);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 98);
            this.panel9.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(448, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wybierz kolor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(433, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wyberz panel (1-9)";
            // 
            // cbColor
            // 
            this.cbColor.AutoCompleteCustomSource.AddRange(new string[] {
            "Zielony",
            "Czerwony"});
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Zielony",
            "Czerwony"});
            this.cbColor.Location = new System.Drawing.Point(615, 125);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(151, 28);
            this.cbColor.TabIndex = 11;
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbNumber.Location = new System.Drawing.Point(615, 211);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(151, 28);
            this.cbNumber.TabIndex = 12;
            // 
            // bChangeColor
            // 
            this.bChangeColor.Location = new System.Drawing.Point(517, 300);
            this.bChangeColor.Name = "bChangeColor";
            this.bChangeColor.Size = new System.Drawing.Size(141, 39);
            this.bChangeColor.TabIndex = 13;
            this.bChangeColor.Text = "Zmień kolor";
            this.bChangeColor.UseVisualStyleBackColor = true;
            this.bChangeColor.Click += new System.EventHandler(this.bChangeColor_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(517, 368);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(141, 39);
            this.bExit.TabIndex = 14;
            this.bExit.Text = "Wyjście";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bChangeColor);
            this.Controls.Add(this.cbNumber);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form w61933";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbNumber;
        private System.Windows.Forms.Button bChangeColor;
        private System.Windows.Forms.Button bExit;
    }
}

