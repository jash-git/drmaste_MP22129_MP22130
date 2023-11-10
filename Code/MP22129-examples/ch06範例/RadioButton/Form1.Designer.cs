namespace RadioButton
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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.RdbUSD = new System.Windows.Forms.RadioButton();
            this.LblOutput = new System.Windows.Forms.Label();
            this.RdbJPY = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入台幣金額：";
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(110, 17);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(107, 22);
            this.TxtInput.TabIndex = 1;
            // 
            // RdbUSD
            // 
            this.RdbUSD.AutoSize = true;
            this.RdbUSD.Location = new System.Drawing.Point(17, 53);
            this.RdbUSD.Name = "RdbUSD";
            this.RdbUSD.Size = new System.Drawing.Size(83, 16);
            this.RdbUSD.TabIndex = 2;
            this.RdbUSD.TabStop = true;
            this.RdbUSD.Text = "兌換為美金";
            this.RdbUSD.UseVisualStyleBackColor = true;
            this.RdbUSD.CheckedChanged += new System.EventHandler(this.RdbUSD_CheckedChanged);
            // 
            // LblOutput
            // 
            this.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblOutput.Location = new System.Drawing.Point(19, 86);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(191, 29);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RdbJPY
            // 
            this.RdbJPY.AutoSize = true;
            this.RdbJPY.Location = new System.Drawing.Point(125, 53);
            this.RdbJPY.Name = "RdbJPY";
            this.RdbJPY.Size = new System.Drawing.Size(83, 16);
            this.RdbJPY.TabIndex = 4;
            this.RdbJPY.TabStop = true;
            this.RdbJPY.Text = "兌換為日幣";
            this.RdbJPY.UseVisualStyleBackColor = true;
            this.RdbJPY.CheckedChanged += new System.EventHandler(this.RdbJPY_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 131);
            this.Controls.Add(this.RdbJPY);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.RdbUSD);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "外幣換算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.RadioButton RdbUSD;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.RadioButton RdbJPY;
    }
}

