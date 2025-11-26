using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        private int tailsCount = 0;
        private int headsCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideup;
            Random randomNumber = new Random();
            sideup = randomNumber.Next(2);

            if (sideup == 0)
            {
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;
                tailsCount++;
                tailCountLabel.Text = tailsCount.ToString();
            }
            else
            {
                tailsPictureBox.Visible = false;
                headsPictureBox.Visible = true;
                headsCount++;
                headCountLabel.Text = headsCount.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
