namespace Tutorial3_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            D = new TextBox();
            monthtextBox = new TextBox();
            daytextBox = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            clearButton = new Label();
            ExitButton = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(-2, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 71);
            label1.TabIndex = 0;
            label1.Text = "星期:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(-2, 93);
            label2.Name = "label2";
            label2.Size = new Size(155, 71);
            label2.TabIndex = 1;
            label2.Text = "月份:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(-2, 164);
            label3.Name = "label3";
            label3.Size = new Size(105, 66);
            label3.TabIndex = 2;
            label3.Text = " 日:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(12, 239);
            label4.Name = "label4";
            label4.Size = new Size(99, 71);
            label4.TabIndex = 3;
            label4.Text = "年:";
            label4.Click += label4_Click;
            // 
            // D
            // 
            D.Location = new Point(174, 46);
            D.Name = "D";
            D.Size = new Size(409, 30);
            D.TabIndex = 4;
            // 
            // monthtextBox
            // 
            monthtextBox.Location = new Point(188, 108);
            monthtextBox.Name = "monthtextBox";
            monthtextBox.Size = new Size(409, 30);
            monthtextBox.TabIndex = 5;
            // 
            // daytextBox
            // 
            daytextBox.Location = new Point(180, 177);
            daytextBox.Name = "daytextBox";
            daytextBox.Size = new Size(409, 30);
            daytextBox.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(417, 30);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 36F);
            label5.Location = new Point(12, 430);
            label5.Name = "label5";
            label5.Size = new Size(327, 91);
            label5.TabIndex = 8;
            label5.Text = "顯示日期";
            label5.Click += label5_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            clearButton.Location = new Point(388, 430);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(183, 91);
            clearButton.TabIndex = 36;
            clearButton.Text = "清除";
            clearButton.Click += label6_Click;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ExitButton.Location = new Point(687, 420);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(183, 91);
            ExitButton.TabIndex = 37;
            ExitButton.Text = "離開";
            ExitButton.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(92, 351);
            label8.Name = "label8";
            label8.Size = new Size(61, 23);
            label8.TabIndex = 38;
            label8.Text = "label8";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 570);
            Controls.Add(label8);
            Controls.Add(ExitButton);
            Controls.Add(clearButton);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(daytextBox);
            Controls.Add(monthtextBox);
            Controls.Add(D);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox D;
        private TextBox monthtextBox;
        private TextBox daytextBox;
        private TextBox textBox4;
        private Label label5;
        private Label clearButton;
        private Label ExitButton;
        private Label label8;
    }
}
