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
           StreamReader inputFile;
            decimal total = 0;
            decimal currentSales=0m;
            // 打開並讀取銷售數據文件
            try
            {
                inputFile = File.OpenText("SalesData.txt");
                // 逐行讀取文件內容並累加銷售額
                while (!inputFile.EndOfStream)
                {
                   currentSales = decimal.Parse(inputFile.ReadLine());
                    total += currentSales;
                }
                // 關閉文件
                inputFile.Close();
                // 顯示總銷售額
                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
