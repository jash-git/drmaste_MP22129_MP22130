
namespace WinReader
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
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(13, 12);
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtShow.Size = new System.Drawing.Size(224, 22);
            this.TxtShow.TabIndex = 0;
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(13, 49);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(75, 23);
            this.BtnSum.TabIndex = 1;
            this.BtnSum.Text = "開始計算";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(162, 49);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "結束";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 82);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.TxtShow);
            this.Name = "Form1";
            this.Text = "WinReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Button BtnExit;
    }
}

