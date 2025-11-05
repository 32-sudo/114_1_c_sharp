namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "點餐內容: ";
            string drink= "";
            String sandwich= "";
            if (coffeeradioButton1.Checked)
            {
                drink = "咖啡 ";
            }
            else if (milkteabutton.Checked)
            {
                drink = "奶茶";
            }
            else if (radioButton3.Checked)
            {
                drink = "紅茶 ";
            }
            else if (radioButton4.Checked)
            {
                drink = "果汁 ";
            }
            if (radioButton5.Checked)
            {
                sandwich = "果醬三明治 ";
            }
            else if (radioButton6.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else if (radioButton7.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else
            {
                sandwich = "";
            }
            message += drink + sandwich;
            MessageBox.Show(message, "訂單內容");
        }
    }
}
