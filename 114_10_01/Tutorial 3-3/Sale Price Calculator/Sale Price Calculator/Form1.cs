using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {     
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;
            // 從文字方塊取得原價。
            originalPrice = Convert.ToDecimal(originalPriceTextBox.Text);
            // 從文字方塊取得折扣百分比。
            discountPercentage = Convert.ToDecimal(discountPercentageTextBox.Text);
            // 計算特價。
            salePrice = originalPrice*(1 -discountPercentage/100.0m);
            // 在特價標籤顯示特價。
            salePriceLabel.Text = salePrice.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void discPercentagePromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
