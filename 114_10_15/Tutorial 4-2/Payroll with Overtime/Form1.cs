using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            { 
                //  NAMED CONSTANTS
                const decimal OT_MULYIPLTER = 1.5m; // Overtime rate multiplier
                const decimal BASE_HOURS = 40m； // Base hours before overtime applies
                // LOCAL VARIABLES
                 decimal hoursWorked; // Hours worked
                 decimal hourlyPayRate; // Hourly pay rate
                 decimal grossPay; // Gross pay
                 decimal overtimeHours; // Overtime hours worked
                 decimal overtimePayRate; // Overtime pay rate  
                 decimal overtimePay; // Overtime pay
                // Get the hours worked.
                hoursWorked = Convert.ToDecimal(hoursWorkedTextBox.Text);
                hourlyPayRate = Convert.ToDecimal(hourlyPayRateTextBox.Text);
                // Determine  The gross pay.
               if (hoursWorked > BASE_HOURS)
                {
                    // Calculate the overtime hours.
                    overtimeHours = hoursWorked - BASE_HOURS;
                    // Calculate the overtime pay rate.
                    overtimePayRate = hourlyPayRate * OT_MULYIPLTER;
                    // Calculate the overtime pay.
                    overtimePay = overtimeHours * overtimePayRate;
                    // Calculate the gross pay.
                    grossPay = (BASE_HOURS * hourlyPayRate) + overtimePay;
                }
                else
                {
                    // No overtime.
                    grossPay = hoursWorked * hourlyPayRate;
                }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
