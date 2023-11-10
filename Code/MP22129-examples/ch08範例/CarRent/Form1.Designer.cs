namespace CarRent
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
            this.LblMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.McaDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMoney
            // 
            this.LblMoney.AutoSize = true;
            this.LblMoney.Location = new System.Drawing.Point(74, 226);
            this.LblMoney.Name = "LblMoney";
            this.LblMoney.Size = new System.Drawing.Size(17, 12);
            this.LblMoney.TabIndex = 19;
            this.LblMoney.Text = "元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "租金：";
            // 
            // McaDate
            // 
            this.McaDate.Location = new System.Drawing.Point(27, 42);
            this.McaDate.Name = "McaDate";
            this.McaDate.TabIndex = 17;
            this.McaDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.McaDate_DateChanged);
            this.McaDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McaDate_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "請選擇租用日期範圍：(1~7日)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 249);
            this.Controls.Add(this.LblMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.McaDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "博碩汽車租金查詢";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar McaDate;
        private System.Windows.Forms.Label label1;
    }
}

