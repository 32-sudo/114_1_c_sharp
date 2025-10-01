using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers;
            double liters;
            double kmpl;
            // 取得使用者輸入的公里數與公升數.
            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);

            // 計算公里數/公升數.
            kmpl = kilometers / liters;

            // 顯示結果.
            mpgLabel.Text = kmpl.ToString("n2") + "公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單.
            this.Close();
        }
    }
}
