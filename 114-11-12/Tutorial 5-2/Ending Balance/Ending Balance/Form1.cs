using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    // 主窗體：計算多個月份複利後的結餘
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算」按鈕時觸發
        private void calculateButton_Click(object sender, EventArgs e)
        {
           // 固定的每月利率（m 後綴表示 decimal 型別）
           const decimal interestRate = 0.005m;
            // 儲存起始餘額（decimal 可處理貨幣金額）
            decimal startingBalance;
            // 儲存要計算的月份數（整數）
            int months;
            // 用來追蹤目前處理的月份（從 1 開始）
             int count=1;


            // 嘗試將起始餘額的文字轉為 decimal，若轉換失敗會回傳 false
            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                // 若月份可以成功轉為整數，且大於 0，才進行計算
                if (int.TryParse(monthsTextBox.Text, out months) &&
                    months > 0)
                {
                    // 清空顯示每月明細的 ListBox（重新開始顯示）
                    detailListBox.Items.Clear();
                    // 將 endingBalance 設為起始餘額，之後會逐月累加利息
                    decimal endingBalance = startingBalance;
                    // 使用 while 迴圈逐月計算利息並更新結餘
                    while (count <= months)
                    {
                        // 本月份的利息 = 現有結餘 * 每月利率
                        decimal interest = endingBalance * interestRate;
                        // 將本月份利息加入結餘（複利：利息會併入下一月的本金）
                        endingBalance += interest;
                        // 在 ListBox 中顯示本月份的利息與更新後的結餘
                        // ToString("c") 會使用系統文化顯示貨幣格式（帶貨幣符號與小數）
                        detailListBox.Items.Add("第 " + count +
                            " 個月：利息 " + interest.ToString("c") +
                            "  結餘 " + endingBalance.ToString("c"));
                        // 處理下一個月份
                        count++;
                    }
                    // 將最終結餘顯示在窗體上的 Label 控制項
                    endingBalanceLabel.Text = endingBalance.ToString("c");
                }
                else
                {
                    // 月份輸入非整數或小於等於 0 時顯示錯誤訊息（提示使用者）
                    MessageBox.Show("請輸入有效的月份數。", "輸入錯誤");
                }
               
            }
            else
            {
                // 起始餘額無法轉為 decimal 時顯示錯誤訊息
                MessageBox.Show("請輸入有效的起始餘額和月份數。", "輸入錯誤");
            }
        }

        // 清除欄位：當使用者按下「清除」按鈕時觸發
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空輸入的起始餘額文字框
            startingBalTextBox.Text = "";
            // 清空輸入的月份數文字框
            monthsTextBox.Text = "";
            // 清空顯示的結餘標籤
            endingBalanceLabel.Text = "";
            // 清空每月明細 ListBox
            detailListBox.Items.Clear();

            // 將焦點移回起始餘額的文字框，方便使用者重新輸入
            startingBalTextBox.Focus();
        }

        // 離開程式：當使用者按下「離開」按鈕時觸發
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗（結束應用程式）
            this.Close();
        }
    }
}
