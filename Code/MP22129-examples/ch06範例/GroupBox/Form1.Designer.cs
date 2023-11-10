namespace GroupBox
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChkSelect3 = new System.Windows.Forms.CheckBox();
            this.ChkSelect2 = new System.Windows.Forms.CheckBox();
            this.ChkSelect1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbGift2 = new System.Windows.Forms.RadioButton();
            this.RdbGift1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbNB3 = new System.Windows.Forms.RadioButton();
            this.RdbNB2 = new System.Windows.Forms.RadioButton();
            this.RdbNB1 = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(209, 120);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 9;
            this.BtnOk.Text = "確定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.Location = new System.Drawing.Point(207, 153);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(204, 39);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkSelect3);
            this.groupBox3.Controls.Add(this.ChkSelect2);
            this.groupBox3.Controls.Add(this.ChkSelect1);
            this.groupBox3.Location = new System.Drawing.Point(209, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 93);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "選配";
            // 
            // ChkSelect3
            // 
            this.ChkSelect3.AutoSize = true;
            this.ChkSelect3.Location = new System.Drawing.Point(7, 68);
            this.ChkSelect3.Name = "ChkSelect3";
            this.ChkSelect3.Size = new System.Drawing.Size(116, 16);
            this.ChkSelect3.TabIndex = 2;
            this.ChkSelect3.Text = "護脊後背包($800)";
            this.ChkSelect3.UseVisualStyleBackColor = true;
            // 
            // ChkSelect2
            // 
            this.ChkSelect2.AutoSize = true;
            this.ChkSelect2.Location = new System.Drawing.Point(7, 45);
            this.ChkSelect2.Name = "ChkSelect2";
            this.ChkSelect2.Size = new System.Drawing.Size(146, 16);
            this.ChkSelect2.TabIndex = 1;
            this.ChkSelect2.Text = "無線影音傳輸器($1200)";
            this.ChkSelect2.UseVisualStyleBackColor = true;
            // 
            // ChkSelect1
            // 
            this.ChkSelect1.AutoSize = true;
            this.ChkSelect1.Location = new System.Drawing.Point(6, 22);
            this.ChkSelect1.Name = "ChkSelect1";
            this.ChkSelect1.Size = new System.Drawing.Size(145, 16);
            this.ChkSelect1.TabIndex = 0;
            this.ChkSelect1.Text = "1000G 行動硬碟($1600)";
            this.ChkSelect1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbGift2);
            this.groupBox2.Controls.Add(this.RdbGift1);
            this.groupBox2.Location = new System.Drawing.Point(15, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 72);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "好禮二選一";
            // 
            // RdbGift2
            // 
            this.RdbGift2.AutoSize = true;
            this.RdbGift2.Location = new System.Drawing.Point(7, 44);
            this.RdbGift2.Name = "RdbGift2";
            this.RdbGift2.Size = new System.Drawing.Size(68, 16);
            this.RdbGift2.TabIndex = 1;
            this.RdbGift2.TabStop = true;
            this.RdbGift2.Text = "64G USB";
            this.RdbGift2.UseVisualStyleBackColor = true;
            // 
            // RdbGift1
            // 
            this.RdbGift1.AutoSize = true;
            this.RdbGift1.Location = new System.Drawing.Point(7, 20);
            this.RdbGift1.Name = "RdbGift1";
            this.RdbGift1.Size = new System.Drawing.Size(124, 16);
            this.RdbGift1.TabIndex = 0;
            this.RdbGift1.TabStop = true;
            this.RdbGift1.Text = "12000mAh行動電源";
            this.RdbGift1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbNB3);
            this.groupBox1.Controls.Add(this.RdbNB2);
            this.groupBox1.Controls.Add(this.RdbNB1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筆電";
            // 
            // RdbNB3
            // 
            this.RdbNB3.AutoSize = true;
            this.RdbNB3.Location = new System.Drawing.Point(7, 68);
            this.RdbNB3.Name = "RdbNB3";
            this.RdbNB3.Size = new System.Drawing.Size(158, 16);
            this.RdbNB3.TabIndex = 2;
            this.RdbNB3.TabStop = true;
            this.RdbNB3.Text = "ASUS 新薄翼筆電($30000)";
            this.RdbNB3.UseVisualStyleBackColor = true;
            // 
            // RdbNB2
            // 
            this.RdbNB2.AutoSize = true;
            this.RdbNB2.Location = new System.Drawing.Point(7, 45);
            this.RdbNB2.Name = "RdbNB2";
            this.RdbNB2.Size = new System.Drawing.Size(170, 16);
            this.RdbNB2.TabIndex = 1;
            this.RdbNB2.TabStop = true;
            this.RdbNB2.Text = "ASUS 薄翼觸控筆電($45000)";
            this.RdbNB2.UseVisualStyleBackColor = true;
            // 
            // RdbNB1
            // 
            this.RdbNB1.AutoSize = true;
            this.RdbNB1.Location = new System.Drawing.Point(7, 22);
            this.RdbNB1.Name = "RdbNB1";
            this.RdbNB1.Size = new System.Drawing.Size(170, 16);
            this.RdbNB1.TabIndex = 0;
            this.RdbNB1.TabStop = true;
            this.RdbNB1.Text = "ASUS 水晶美型筆電($55000)";
            this.RdbNB1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 201);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "筆電選購";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkSelect3;
        private System.Windows.Forms.CheckBox ChkSelect2;
        private System.Windows.Forms.CheckBox ChkSelect1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbGift2;
        private System.Windows.Forms.RadioButton RdbGift1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbNB3;
        private System.Windows.Forms.RadioButton RdbNB2;
        private System.Windows.Forms.RadioButton RdbNB1;
    }
}

