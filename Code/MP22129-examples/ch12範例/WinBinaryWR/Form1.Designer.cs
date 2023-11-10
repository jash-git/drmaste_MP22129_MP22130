namespace WinBinaryWR
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.BtnCls = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.TxtPad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCls
            // 
            this.BtnCls.Location = new System.Drawing.Point(185, 55);
            this.BtnCls.Name = "BtnCls";
            this.BtnCls.Size = new System.Drawing.Size(70, 24);
            this.BtnCls.TabIndex = 23;
            this.BtnCls.Text = "清除文字";
            this.BtnCls.UseVisualStyleBackColor = true;
            this.BtnCls.Click += new System.EventHandler(this.BtnCls_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(185, 94);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(70, 24);
            this.BtnRead.TabIndex = 22;
            this.BtnRead.Text = "讀取檔案";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(185, 16);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(70, 24);
            this.BtnWrite.TabIndex = 21;
            this.BtnWrite.Text = "寫入檔案";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // TxtPad
            // 
            this.TxtPad.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtPad.Location = new System.Drawing.Point(12, 12);
            this.TxtPad.Multiline = true;
            this.TxtPad.Name = "TxtPad";
            this.TxtPad.Size = new System.Drawing.Size(163, 130);
            this.TxtPad.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 157);
            this.Controls.Add(this.BtnCls);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.TxtPad);
            this.Name = "Form1";
            this.Text = "BinaryWR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCls;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.TextBox TxtPad;
    }
}

