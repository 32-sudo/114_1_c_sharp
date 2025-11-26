using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader imputfile;
            decimal total = 0;
            decimal currentSale = 0;
            string line;
            // 打開並讀取文件

            if (openFiles.ShowDialog() == DialogResult.OK)
            {
                imputfile = File.OpenText(openFiles.FileName);
                line = imputfile.ReadLine();
                while (line != null)
                {
                    currentSale = Convert.ToDecimal(line);
                    total += currentSale;
                    line = imputfile.ReadLine();
                }
                imputfile.Close();
                // 顯示總銷售額
                totalLabel.Text = total.ToString("c");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
