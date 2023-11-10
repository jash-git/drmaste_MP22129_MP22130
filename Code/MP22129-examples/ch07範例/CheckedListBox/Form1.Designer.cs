namespace CheckedListBox
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.LblDiv = new System.Windows.Forms.Label();
            this.ClstTest = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(189, 128);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "重答";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(189, 92);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 10;
            this.BtnCheck.Text = "核對";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(189, 56);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 9;
            this.BtnNew.Text = "出題";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Location = new System.Drawing.Point(189, 20);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(96, 23);
            this.LblMsg.TabIndex = 8;
            this.LblMsg.Text = "label2";
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDiv
            // 
            this.LblDiv.AutoSize = true;
            this.LblDiv.Location = new System.Drawing.Point(18, 16);
            this.LblDiv.Name = "LblDiv";
            this.LblDiv.Size = new System.Drawing.Size(41, 12);
            this.LblDiv.TabIndex = 7;
            this.LblDiv.Text = "未出題";
            // 
            // ClstTest
            // 
            this.ClstTest.FormattingEnabled = true;
            this.ClstTest.Location = new System.Drawing.Point(18, 40);
            this.ClstTest.Name = "ClstTest";
            this.ClstTest.Size = new System.Drawing.Size(156, 106);
            this.ClstTest.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 161);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.LblDiv);
            this.Controls.Add(this.ClstTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label LblDiv;
        private System.Windows.Forms.CheckedListBox ClstTest;
    }
}

