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
        { Streamreader imputfile;
            decimal total = 0;
            decimal currentSale=0;
            string line;
            // 打開並讀取文件

            try
            imputfile =File.OpenText("Sales.txt");
            salesListBox.items.Clear();

            while (!imputfile.EndOfStream)
            {
                line = imputfile.ReadLine();
                currentSale = Convert.ToDecimal(line);
                salesListBox.items.Add(currentSale.ToString("c"));

            }
            line = imputfile.ReadLine();
            string[] parts;= line.Split(new char[])
            {
                // 將讀取的行轉換為十進制並累加到總額
                total += Convert.ToDecimal(line);
                line = imputfile.ReadLine();
            }
            // 關閉文件
            imputfile.Close();
            // 顯示總銷售額
            totalLabel.Text = total.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
