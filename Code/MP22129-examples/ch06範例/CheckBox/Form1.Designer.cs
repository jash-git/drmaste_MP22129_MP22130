namespace CheckBox
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
            this.Chk1 = new System.Windows.Forms.CheckBox();
            this.Chk2 = new System.Windows.Forms.CheckBox();
            this.Chk3 = new System.Windows.Forms.CheckBox();
            this.TxtQty1 = new System.Windows.Forms.TextBox();
            this.TxtQty2 = new System.Windows.Forms.TextBox();
            this.TxtQty3 = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chk1
            // 
            this.Chk1.AutoSize = true;
            this.Chk1.Location = new System.Drawing.Point(23, 24);
            this.Chk1.Name = "Chk1";
            this.Chk1.Size = new System.Drawing.Size(104, 16);
            this.Chk1.TabIndex = 0;
            this.Chk1.Text = "布丁奶茶(50元)";
            this.Chk1.UseVisualStyleBackColor = true;
            this.Chk1.CheckedChanged += new System.EventHandler(this.Chk1_CheckedChanged);
            // 
            // Chk2
            // 
            this.Chk2.AutoSize = true;
            this.Chk2.Location = new System.Drawing.Point(23, 57);
            this.Chk2.Name = "Chk2";
            this.Chk2.Size = new System.Drawing.Size(104, 16);
            this.Chk2.TabIndex = 1;
            this.Chk2.Text = "冰晶咖啡(80元)";
            this.Chk2.UseVisualStyleBackColor = true;
            this.Chk2.CheckedChanged += new System.EventHandler(this.Chk2_CheckedChanged);
            // 
            // Chk3
            // 
            this.Chk3.AutoSize = true;
            this.Chk3.Location = new System.Drawing.Point(23, 91);
            this.Chk3.Name = "Chk3";
            this.Chk3.Size = new System.Drawing.Size(104, 16);
            this.Chk3.TabIndex = 2;
            this.Chk3.Text = "芋圓豆花(60元)";
            this.Chk3.UseVisualStyleBackColor = true;
            this.Chk3.CheckedChanged += new System.EventHandler(this.Chk3_CheckedChanged);
            // 
            // TxtQty1
            // 
            this.TxtQty1.Location = new System.Drawing.Point(131, 20);
            this.TxtQty1.Name = "TxtQty1";
            this.TxtQty1.Size = new System.Drawing.Size(95, 22);
            this.TxtQty1.TabIndex = 3;
            // 
            // TxtQty2
            // 
            this.TxtQty2.Location = new System.Drawing.Point(131, 54);
            this.TxtQty2.Name = "TxtQty2";
            this.TxtQty2.Size = new System.Drawing.Size(95, 22);
            this.TxtQty2.TabIndex = 4;
            // 
            // TxtQty3
            // 
            this.TxtQty3.Location = new System.Drawing.Point(131, 87);
            this.TxtQty3.Name = "TxtQty3";
            this.TxtQty3.Size = new System.Drawing.Size(95, 22);
            this.TxtQty3.TabIndex = 5;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(18, 128);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(41, 15);
            this.LblMsg.TabIndex = 6;
            this.LblMsg.Text = "label1";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(245, 88);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "結帳";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 159);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtQty3);
            this.Controls.Add(this.TxtQty2);
            this.Controls.Add(this.TxtQty1);
            this.Controls.Add(this.Chk3);
            this.Controls.Add(this.Chk2);
            this.Controls.Add(this.Chk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk1;
        private System.Windows.Forms.CheckBox Chk2;
        private System.Windows.Forms.CheckBox Chk3;
        private System.Windows.Forms.TextBox TxtQty1;
        private System.Windows.Forms.TextBox TxtQty2;
        private System.Windows.Forms.TextBox TxtQty3;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnOK;
    }
}

