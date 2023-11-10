namespace WinBinaryCopy
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
            this.LblShow = new System.Windows.Forms.Label();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.PicShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            this.SuspendLayout();
            // 
            // LblShow
            // 
            this.LblShow.AutoSize = true;
            this.LblShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblShow.Location = new System.Drawing.Point(19, 183);
            this.LblShow.Name = "LblShow";
            this.LblShow.Size = new System.Drawing.Size(46, 16);
            this.LblShow.TabIndex = 15;
            this.LblShow.Text = "label1";
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(165, 183);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(61, 24);
            this.BtnCopy.TabIndex = 14;
            this.BtnCopy.Text = "複製";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(12, 12);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(231, 156);
            this.PicShow.TabIndex = 13;
            this.PicShow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 220);
            this.Controls.Add(this.LblShow);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.PicShow);
            this.Name = "Form1";
            this.Text = "BinaryCopy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblShow;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.PictureBox PicShow;
    }
}

