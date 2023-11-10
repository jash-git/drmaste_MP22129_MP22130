namespace TouchPic
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
            this.picT3 = new System.Windows.Forms.PictureBox();
            this.picT2 = new System.Windows.Forms.PictureBox();
            this.PicT1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicT1)).BeginInit();
            this.SuspendLayout();
            // 
            // picT3
            // 
            this.picT3.Location = new System.Drawing.Point(97, 114);
            this.picT3.Name = "picT3";
            this.picT3.Size = new System.Drawing.Size(160, 120);
            this.picT3.TabIndex = 5;
            this.picT3.TabStop = false;
            // 
            // picT2
            // 
            this.picT2.Location = new System.Drawing.Point(61, 68);
            this.picT2.Name = "picT2";
            this.picT2.Size = new System.Drawing.Size(160, 120);
            this.picT2.TabIndex = 4;
            this.picT2.TabStop = false;
            // 
            // PicT1
            // 
            this.PicT1.Location = new System.Drawing.Point(28, 26);
            this.PicT1.Name = "PicT1";
            this.PicT1.Size = new System.Drawing.Size(160, 120);
            this.PicT1.TabIndex = 3;
            this.PicT1.TabStop = false;
            this.PicT1.Click += new System.EventHandler(this.PicT1_Click);
            this.PicT1.DoubleClick += new System.EventHandler(this.PicT1_DoubleClick);
            this.PicT1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicT1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picT3);
            this.Controls.Add(this.picT2);
            this.Controls.Add(this.PicT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicT1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picT3;
        private System.Windows.Forms.PictureBox picT2;
        private System.Windows.Forms.PictureBox PicT1;
    }
}

