namespace TabControl
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
            this.TbcOrder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtM2 = new System.Windows.Forms.TextBox();
            this.TxtM1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkM2 = new System.Windows.Forms.CheckBox();
            this.ChkM1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TxtR2 = new System.Windows.Forms.TextBox();
            this.TxtR1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkR1 = new System.Windows.Forms.CheckBox();
            this.ChkR2 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.TbcOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcOrder
            // 
            this.TbcOrder.Controls.Add(this.tabPage1);
            this.TbcOrder.Controls.Add(this.tabPage2);
            this.TbcOrder.Controls.Add(this.tabPage3);
            this.TbcOrder.Controls.Add(this.tabPage4);
            this.TbcOrder.Location = new System.Drawing.Point(12, 12);
            this.TbcOrder.Name = "TbcOrder";
            this.TbcOrder.SelectedIndex = 0;
            this.TbcOrder.Size = new System.Drawing.Size(247, 127);
            this.TbcOrder.TabIndex = 1;
            this.TbcOrder.SelectedIndexChanged += new System.EventHandler(this.TbcOrder_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtPW);
            this.tabPage1.Controls.Add(this.TxtID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(239, 101);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登錄";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(96, 54);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.Size = new System.Drawing.Size(100, 22);
            this.TxtPW.TabIndex = 4;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(96, 21);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密碼：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用者：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtM2);
            this.tabPage2.Controls.Add(this.TxtM1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ChkM2);
            this.tabPage2.Controls.Add(this.ChkM1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(239, 101);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "主餐";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtM2
            // 
            this.TxtM2.Location = new System.Drawing.Point(124, 59);
            this.TxtM2.Name = "TxtM2";
            this.TxtM2.Size = new System.Drawing.Size(68, 22);
            this.TxtM2.TabIndex = 5;
            // 
            // TxtM1
            // 
            this.TxtM1.Location = new System.Drawing.Point(124, 31);
            this.TxtM1.Name = "TxtM1";
            this.TxtM1.Size = new System.Drawing.Size(68, 22);
            this.TxtM1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "數量";
            // 
            // ChkM2
            // 
            this.ChkM2.AutoSize = true;
            this.ChkM2.Location = new System.Drawing.Point(19, 65);
            this.ChkM2.Name = "ChkM2";
            this.ChkM2.Size = new System.Drawing.Size(92, 16);
            this.ChkM2.TabIndex = 1;
            this.ChkM2.Text = "三明治(30元)";
            this.ChkM2.UseVisualStyleBackColor = true;
            this.ChkM2.CheckedChanged += new System.EventHandler(this.ChkM2_CheckedChanged);
            // 
            // ChkM1
            // 
            this.ChkM1.AutoSize = true;
            this.ChkM1.Location = new System.Drawing.Point(19, 37);
            this.ChkM1.Name = "ChkM1";
            this.ChkM1.Size = new System.Drawing.Size(80, 16);
            this.ChkM1.TabIndex = 0;
            this.ChkM1.Text = "蛋餅(20元)";
            this.ChkM1.UseVisualStyleBackColor = true;
            this.ChkM1.CheckedChanged += new System.EventHandler(this.ChkM1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TxtR2);
            this.tabPage3.Controls.Add(this.TxtR1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.ChkR1);
            this.tabPage3.Controls.Add(this.ChkR2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(239, 101);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "飲料";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TxtR2
            // 
            this.TxtR2.Location = new System.Drawing.Point(123, 64);
            this.TxtR2.Name = "TxtR2";
            this.TxtR2.Size = new System.Drawing.Size(68, 22);
            this.TxtR2.TabIndex = 14;
            // 
            // TxtR1
            // 
            this.TxtR1.Location = new System.Drawing.Point(123, 32);
            this.TxtR1.Name = "TxtR1";
            this.TxtR1.Size = new System.Drawing.Size(68, 22);
            this.TxtR1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "數量";
            // 
            // ChkR1
            // 
            this.ChkR1.AutoSize = true;
            this.ChkR1.Location = new System.Drawing.Point(16, 33);
            this.ChkR1.Name = "ChkR1";
            this.ChkR1.Size = new System.Drawing.Size(80, 16);
            this.ChkR1.TabIndex = 9;
            this.ChkR1.Text = "豆漿(15元)";
            this.ChkR1.UseVisualStyleBackColor = true;
            this.ChkR1.CheckedChanged += new System.EventHandler(this.ChkR1_CheckedChanged);
            // 
            // ChkR2
            // 
            this.ChkR2.AutoSize = true;
            this.ChkR2.Location = new System.Drawing.Point(16, 65);
            this.ChkR2.Name = "ChkR2";
            this.ChkR2.Size = new System.Drawing.Size(80, 16);
            this.ChkR2.TabIndex = 8;
            this.ChkR2.Text = "奶茶(20元)";
            this.ChkR2.UseVisualStyleBackColor = true;
            this.ChkR2.CheckedChanged += new System.EventHandler(this.ChkR2_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LblTotal);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(239, 101);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "結帳";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(20, 14);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(33, 12);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "label5";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(14, 152);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 12);
            this.LblMsg.TabIndex = 2;
            this.LblMsg.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 180);
            this.Controls.Add(this.TbcOrder);
            this.Controls.Add(this.LblMsg);
            this.Name = "Form1";
            this.Text = "活力早餐店";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TbcOrder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbcOrder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtM2;
        private System.Windows.Forms.TextBox TxtM1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkM2;
        private System.Windows.Forms.CheckBox ChkM1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TxtR2;
        private System.Windows.Forms.TextBox TxtR1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkR1;
        private System.Windows.Forms.CheckBox ChkR2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblMsg;
    }
}

