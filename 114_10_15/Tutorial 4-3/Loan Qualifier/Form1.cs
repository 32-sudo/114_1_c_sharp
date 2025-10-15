using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 檢查按鈕點擊事件
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 最低薪資常數
            const decimal 最低薪資 = 30000m;
            // 最低工作年資常數
            const int 最低年資 = 2;

            decimal 薪資;
            int 年資;

            // 嘗試取得薪資與年資
            if (decimal.TryParse(salaryTextBox.Text, out 薪資) && int.TryParse(yearsTextBox.Text, out 年資))
            {
                // 檢查資格
                if (薪資 >= 最低薪資 && 年資 >= 最低年資)
                {
                    decisionLabel.Text = "您符合貸款資格。";
                }
                else
                {
                    decisionLabel.Text = "很抱歉，您不符合貸款資格。";
                }
            }
            else
            {
                decisionLabel.Text = "請輸入有效的薪資和年資。";
            }
        }

        // 清除按鈕點擊事件
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除文字方塊和決策標籤。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 重設焦點。
            salaryTextBox.Focus();
        }

        // 離開按鈕點擊事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
