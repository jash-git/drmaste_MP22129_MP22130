namespace domainUpDn
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
            this.LblMsg = new System.Windows.Forms.Label();
            this.DudNum = new System.Windows.Forms.DomainUpDown();
            this.DudOpt = new System.Windows.Forms.DomainUpDown();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.LblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(17, 73);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 12);
            this.LblMsg.TabIndex = 15;
            this.LblMsg.Text = "label2";
            // 
            // DudNum
            // 
            this.DudNum.Location = new System.Drawing.Point(242, 71);
            this.DudNum.Name = "DudNum";
            this.DudNum.Size = new System.Drawing.Size(91, 22);
            this.DudNum.TabIndex = 14;
            this.DudNum.Text = "domainUpDown2";
            // 
            // DudOpt
            // 
            this.DudOpt.Location = new System.Drawing.Point(242, 33);
            this.DudOpt.Name = "DudOpt";
            this.DudOpt.Size = new System.Drawing.Size(91, 22);
            this.DudOpt.TabIndex = 13;
            this.DudOpt.Text = "domainUpDown1";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(258, 109);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 12;
            this.BtnCheck.Text = "對答案";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // TxtAns
            // 
            this.TxtAns.Font = new System.Drawing.Font("新細明體", 16F);
            this.TxtAns.Location = new System.Drawing.Point(119, 25);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(85, 33);
            this.TxtAns.TabIndex = 11;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(165, 109);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 10;
            this.BtnTest.Text = "出題";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // LblTest
            // 
            this.LblTest.AutoSize = true;
            this.LblTest.Font = new System.Drawing.Font("新細明體", 16F);
            this.LblTest.Location = new System.Drawing.Point(15, 28);
            this.LblTest.Name = "LblTest";
            this.LblTest.Size = new System.Drawing.Size(60, 22);
            this.LblTest.TabIndex = 9;
            this.LblTest.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 144);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.DudNum);
            this.Controls.Add(this.DudOpt);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.LblTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.DomainUpDown DudNum;
        private System.Windows.Forms.DomainUpDown DudOpt;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.TextBox TxtAns;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label LblTest;
    }
}

