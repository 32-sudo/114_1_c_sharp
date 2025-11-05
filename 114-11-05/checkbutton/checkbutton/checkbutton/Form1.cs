using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 確定_Click(object sender, EventArgs e)
        {
            string message ="";
            if (checkBox1.Checked)
            {
                message = message += "夏威夷";

            }
            if (checkBox2.Checked)
            {
                message = message += "章魚燒";

            }
            if (checkBox3.Checked)
            {
                message = message += "綜合海鮮";
            }
            if (checkBox4.Checked)
            {
                message = message += "義式火腿";
            }
            if(message == "")
            {
                MessageBox.Show("您沒有選擇任何口味");
            }
            
            {
                MessageBox.Show("您選擇的披薩口味有" );
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
