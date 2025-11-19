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
            // 初始化累計與暫存變數
            decimal total = 0m;
            decimal currentSales;
            string line;

            // 清除舊的 ListBox 內容，準備顯示本次讀取之資料
            if (this.slaselistbox != null)
            {
                this.slaselistbox.Items.Clear();
            }

            try
            {
                // 使用 using 確保檔案正確關閉與釋放資源
                using (StreamReader inputFile = File.OpenText("SalesData.txt"))
                {
                    // 逐行讀取，直到檔案結尾
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        // 忽略空行
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        // 嘗試解析為 decimal，解析成功則累計並顯示在 ListBox
                        if (decimal.TryParse(line, out currentSales))
                        {
                            total += currentSales;
                            if (this.slaselistbox != null)
                            {
                                // 顯示格式化的金額（當地貨幣格式）
                                this.slaselistbox.Items.Add(currentSales.ToString("C"));
                            }
                        }
                        else
                        {
                            // 若某一行無法解析，顯示警告但繼續讀取其餘資料
                            MessageBox.Show("無法解析銷售額: " + line, "資料格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // 顯示總銷售額（格式化為貨幣）
                totalLabel.Text = total.ToString("C");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到 SalesData.txt 檔案。請確認檔案與執行檔在同一資料夾。", "檔案不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
