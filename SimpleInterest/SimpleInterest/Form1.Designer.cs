namespace SimpleInterest
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrincipalTextBox = new System.Windows.Forms.TextBox();
            this.InterestTextBox = new System.Windows.Forms.TextBox();
            this.PeriodTextBox = new System.Windows.Forms.TextBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CalculateInterestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate(pa.a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period (Months)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount";
            // 
            // PrincipalTextBox
            // 
            this.PrincipalTextBox.Location = new System.Drawing.Point(266, 53);
            this.PrincipalTextBox.Name = "PrincipalTextBox";
            this.PrincipalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrincipalTextBox.TabIndex = 5;
            // 
            // InterestTextBox
            // 
            this.InterestTextBox.Enabled = false;
            this.InterestTextBox.Location = new System.Drawing.Point(266, 225);
            this.InterestTextBox.Name = "InterestTextBox";
            this.InterestTextBox.Size = new System.Drawing.Size(100, 20);
            this.InterestTextBox.TabIndex = 6;
            // 
            // PeriodTextBox
            // 
            this.PeriodTextBox.Location = new System.Drawing.Point(266, 149);
            this.PeriodTextBox.Name = "PeriodTextBox";
            this.PeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeriodTextBox.TabIndex = 7;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(266, 107);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(100, 20);
            this.RateTextBox.TabIndex = 8;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Enabled = false;
            this.AmountTextBox.Location = new System.Drawing.Point(266, 270);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 9;
            // 
            // CalculateInterestButton
            // 
            this.CalculateInterestButton.Location = new System.Drawing.Point(251, 187);
            this.CalculateInterestButton.Name = "CalculateInterestButton";
            this.CalculateInterestButton.Size = new System.Drawing.Size(115, 23);
            this.CalculateInterestButton.TabIndex = 10;
            this.CalculateInterestButton.Text = "Calculate Interest";
            this.CalculateInterestButton.UseVisualStyleBackColor = true;
            this.CalculateInterestButton.Click += new System.EventHandler(this.CalculateInterestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateInterestButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.RateTextBox);
            this.Controls.Add(this.PeriodTextBox);
            this.Controls.Add(this.InterestTextBox);
            this.Controls.Add(this.PrincipalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrincipalTextBox;
        private System.Windows.Forms.TextBox InterestTextBox;
        private System.Windows.Forms.TextBox PeriodTextBox;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button CalculateInterestButton;
    }
}

