using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateInterestButton_Click(object sender, EventArgs e)
        {
            try
            {
                double Principal = 0;
                double Rate = 0;
                int Period = 0;
                if (PrincipalTextBox.Text != "")
                {
                    Principal = Convert.ToDouble(PrincipalTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Enter the Principal Amount");
                }
                if (RateTextBox.Text != "")
                {
                    Rate = Convert.ToDouble(RateTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Enter the Rate");
                }
                if (PeriodTextBox.Text != "")
                {
                    Period = Convert.ToInt32(PeriodTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Enter the Period");
                }
                double interest = Convert.ToDouble((Principal * Rate * Period) / 1200);
                InterestTextBox.Text = interest.ToString();
                AmountTextBox.Text = Convert.ToString(Principal + interest);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
