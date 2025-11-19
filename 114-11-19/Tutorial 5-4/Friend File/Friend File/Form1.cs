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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
          StreamWriter outputFile;
            try
                {
                // 開啟檔案以供寫入。
                outputFile = File.AppendText("Friends.txt");
                // 寫入使用者輸入的名字。
                outputFile.WriteLine(nameTextBox.Text);
                // 關閉檔案。
                outputFile.Close();
                
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
