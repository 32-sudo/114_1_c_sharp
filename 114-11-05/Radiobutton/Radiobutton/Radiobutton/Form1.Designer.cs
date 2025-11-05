namespace Radiobutton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            coffeeradioButton1 = new RadioButton();
            milkteabutton = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            sendbutton = new Button();
            sandbutton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // coffeeradioButton1
            // 
            coffeeradioButton1.AutoSize = true;
            coffeeradioButton1.Location = new Point(47, 29);
            coffeeradioButton1.Name = "coffeeradioButton1";
            coffeeradioButton1.Size = new Size(71, 27);
            coffeeradioButton1.TabIndex = 0;
            coffeeradioButton1.TabStop = true;
            coffeeradioButton1.Text = "咖啡";
            coffeeradioButton1.UseVisualStyleBackColor = true;
            coffeeradioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // milkteabutton
            // 
            milkteabutton.AutoSize = true;
            milkteabutton.Location = new Point(47, 62);
            milkteabutton.Name = "milkteabutton";
            milkteabutton.Size = new Size(71, 27);
            milkteabutton.TabIndex = 1;
            milkteabutton.TabStop = true;
            milkteabutton.Text = "奶茶";
            milkteabutton.UseVisualStyleBackColor = true;
            milkteabutton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(47, 105);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 27);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "紅茶";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(138, 29);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(71, 27);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "果汁";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 29);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(125, 27);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "果醬三明治";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 62);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(125, 27);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "火腿三明治";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 105);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(125, 27);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "鮪魚三明治";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(coffeeradioButton1);
            groupBox1.Controls.Add(milkteabutton);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 150);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "飲料";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(458, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "三明治";
            // 
            // sendbutton
            // 
            sendbutton.Location = new Point(59, 292);
            sendbutton.Name = "sendbutton";
            sendbutton.Size = new Size(184, 103);
            sendbutton.TabIndex = 9;
            sendbutton.Text = "送出訂單";
            sendbutton.UseVisualStyleBackColor = true;
            sendbutton.Click += button1_Click;
            // 
            // sandbutton
            // 
            sandbutton.Location = new Point(343, 282);
            sandbutton.Name = "sandbutton";
            sandbutton.Size = new Size(130, 113);
            sandbutton.TabIndex = 10;
            sandbutton.Text = "button2";
            sandbutton.UseVisualStyleBackColor = true;
            sandbutton.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 550);
            Controls.Add(sandbutton);
            Controls.Add(sendbutton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton coffeeradioButton1;
        private RadioButton milkteabutton;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button sendbutton;
        private Button sandbutton;
    }
}
