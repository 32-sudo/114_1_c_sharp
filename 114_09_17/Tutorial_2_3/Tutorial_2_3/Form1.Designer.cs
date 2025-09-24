namespace Tutorial_2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TRASLATIONLABEL = new System.Windows.Forms.Label();
            this.Italianlabel = new System.Windows.Forms.Button();
            this.spanishLABEL = new System.Windows.Forms.Button();
            this.Germanlabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(46, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我會說早安";
            // 
            // TRASLATIONLABEL
            // 
            this.TRASLATIONLABEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TRASLATIONLABEL.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TRASLATIONLABEL.Location = new System.Drawing.Point(43, 151);
            this.TRASLATIONLABEL.Name = "TRASLATIONLABEL";
            this.TRASLATIONLABEL.Size = new System.Drawing.Size(587, 108);
            this.TRASLATIONLABEL.TabIndex = 1;
            this.TRASLATIONLABEL.Text = "label2";
            this.TRASLATIONLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TRASLATIONLABEL.Click += new System.EventHandler(this.label2_Click);
            // 
            // Italianlabel
            // 
            this.Italianlabel.Location = new System.Drawing.Point(55, 293);
            this.Italianlabel.Name = "Italianlabel";
            this.Italianlabel.Size = new System.Drawing.Size(165, 102);
            this.Italianlabel.TabIndex = 2;
            this.Italianlabel.Text = "義大利文";
            this.Italianlabel.UseMnemonic = false;
            this.Italianlabel.UseVisualStyleBackColor = true;
            this.Italianlabel.Click += new System.EventHandler(this.Italianlabel_Click);
            // 
            // spanishLABEL
            // 
            this.spanishLABEL.Location = new System.Drawing.Point(274, 293);
            this.spanishLABEL.Name = "spanishLABEL";
            this.spanishLABEL.Size = new System.Drawing.Size(164, 102);
            this.spanishLABEL.TabIndex = 3;
            this.spanishLABEL.Text = "西班牙文";
            this.spanishLABEL.UseVisualStyleBackColor = true;
            this.spanishLABEL.Click += new System.EventHandler(this.button1_Click);
            // 
            // Germanlabel
            // 
            this.Germanlabel.Location = new System.Drawing.Point(502, 293);
            this.Germanlabel.Name = "Germanlabel";
            this.Germanlabel.Size = new System.Drawing.Size(171, 102);
            this.Germanlabel.TabIndex = 4;
            this.Germanlabel.Text = "德文";
            this.Germanlabel.UseVisualStyleBackColor = true;
            this.Germanlabel.Click += new System.EventHandler(this.Germanlabel_Click);
            this.Germanlabel.Layout += new System.Windows.Forms.LayoutEventHandler(this.Germanlabel_Layout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Germanlabel);
            this.Controls.Add(this.spanishLABEL);
            this.Controls.Add(this.Italianlabel);
            this.Controls.Add(this.TRASLATIONLABEL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "語言翻譯器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TRASLATIONLABEL;
        private System.Windows.Forms.Button Italianlabel;
        private System.Windows.Forms.Button spanishLABEL;
        private System.Windows.Forms.Button Germanlabel;
    }
}

