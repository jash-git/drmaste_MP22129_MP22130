namespace Interface3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbJP = new System.Windows.Forms.RadioButton();
            this.RdbUSA = new System.Windows.Forms.RadioButton();
            this.LblCash = new System.Windows.Forms.Label();
            this.TxtCash = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbJP);
            this.groupBox1.Controls.Add(this.RdbUSA);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇要兌換台幣的外幣：";
            // 
            // RdbJP
            // 
            this.RdbJP.AutoSize = true;
            this.RdbJP.Location = new System.Drawing.Point(88, 33);
            this.RdbJP.Name = "RdbJP";
            this.RdbJP.Size = new System.Drawing.Size(47, 16);
            this.RdbJP.TabIndex = 1;
            this.RdbJP.TabStop = true;
            this.RdbJP.Text = "日幣";
            this.RdbJP.UseVisualStyleBackColor = true;
            // 
            // RdbUSA
            // 
            this.RdbUSA.AutoSize = true;
            this.RdbUSA.Location = new System.Drawing.Point(17, 33);
            this.RdbUSA.Name = "RdbUSA";
            this.RdbUSA.Size = new System.Drawing.Size(47, 16);
            this.RdbUSA.TabIndex = 0;
            this.RdbUSA.TabStop = true;
            this.RdbUSA.Text = "美元";
            this.RdbUSA.UseVisualStyleBackColor = true;
            // 
            // LblCash
            // 
            this.LblCash.AutoSize = true;
            this.LblCash.Location = new System.Drawing.Point(23, 114);
            this.LblCash.Name = "LblCash";
            this.LblCash.Size = new System.Drawing.Size(149, 12);
            this.LblCash.TabIndex = 1;
            this.LblCash.Text = "請輸入要兌換的外幣金額：";
            // 
            // TxtCash
            // 
            this.TxtCash.Location = new System.Drawing.Point(178, 111);
            this.TxtCash.Name = "TxtCash";
            this.TxtCash.Size = new System.Drawing.Size(66, 22);
            this.TxtCash.TabIndex = 2;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(23, 149);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(29, 12);
            this.LblMsg.TabIndex = 3;
            this.LblMsg.Text = "訊息";
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(195, 55);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(57, 22);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "兌換";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 183);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtCash);
            this.Controls.Add(this.LblCash);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbJP;
        private System.Windows.Forms.RadioButton RdbUSA;
        private System.Windows.Forms.Label LblCash;
        private System.Windows.Forms.TextBox TxtCash;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnConvert;
    }
}

