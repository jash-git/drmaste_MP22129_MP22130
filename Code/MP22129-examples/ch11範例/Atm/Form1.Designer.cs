namespace Atm
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
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtMoney
            // 
            this.TxtMoney.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtMoney.Location = new System.Drawing.Point(91, 69);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.Size = new System.Drawing.Size(169, 27);
            this.TxtMoney.TabIndex = 14;
            this.TxtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMoney_KeyPress);
            // 
            // TxtPW
            // 
            this.TxtPW.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxtPW.Location = new System.Drawing.Point(91, 26);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(169, 27);
            this.TxtPW.TabIndex = 13;
            this.TxtPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPW_KeyPress);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 12F);
            this.LblMsg.Location = new System.Drawing.Point(18, 115);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(46, 16);
            this.LblMsg.TabIndex = 12;
            this.LblMsg.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "金額：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "密碼：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 156);
            this.Controls.Add(this.TxtMoney);
            this.Controls.Add(this.TxtPW);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ATM提款機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMoney;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

