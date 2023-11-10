namespace Casher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbWT = new System.Windows.Forms.RadioButton();
            this.RdbNum = new System.Windows.Forms.RadioButton();
            this.LblBuy = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnCal = new System.Windows.Forms.Button();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblTot = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbWT);
            this.groupBox1.Controls.Add(this.RdbNum);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "結算的種類";
            // 
            // RdbWT
            // 
            this.RdbWT.AutoSize = true;
            this.RdbWT.Location = new System.Drawing.Point(85, 31);
            this.RdbWT.Name = "RdbWT";
            this.RdbWT.Size = new System.Drawing.Size(47, 16);
            this.RdbWT.TabIndex = 1;
            this.RdbWT.Text = "公斤";
            this.RdbWT.UseVisualStyleBackColor = true;
            this.RdbWT.Click += new System.EventHandler(this.RdbWT_Click);
            // 
            // RdbNum
            // 
            this.RdbNum.AutoSize = true;
            this.RdbNum.Checked = true;
            this.RdbNum.Location = new System.Drawing.Point(17, 31);
            this.RdbNum.Name = "RdbNum";
            this.RdbNum.Size = new System.Drawing.Size(47, 16);
            this.RdbNum.TabIndex = 0;
            this.RdbNum.TabStop = true;
            this.RdbNum.Text = "個數";
            this.RdbNum.UseVisualStyleBackColor = true;
            this.RdbNum.Click += new System.EventHandler(this.RdbNum_Click);
            // 
            // LblBuy
            // 
            this.LblBuy.AutoSize = true;
            this.LblBuy.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblBuy.Location = new System.Drawing.Point(20, 102);
            this.LblBuy.Name = "LblBuy";
            this.LblBuy.Size = new System.Drawing.Size(98, 13);
            this.LblBuy.TabIndex = 1;
            this.LblBuy.Text = "輸入購買數量：";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lable2.Location = new System.Drawing.Point(20, 135);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(93, 13);
            this.lable2.TabIndex = 2;
            this.lable2.Text = "輸入單價(元)：";
            // 
            // TxtNum
            // 
            this.TxtNum.Location = new System.Drawing.Point(124, 99);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(47, 22);
            this.TxtNum.TabIndex = 3;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(124, 132);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(47, 22);
            this.TxtPrice.TabIndex = 4;
            // 
            // BtnCal
            // 
            this.BtnCal.Location = new System.Drawing.Point(190, 48);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(65, 27);
            this.BtnCal.TabIndex = 6;
            this.BtnCal.Text = "計算";
            this.BtnCal.UseVisualStyleBackColor = true;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblPrice.Location = new System.Drawing.Point(20, 176);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(72, 13);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "單項收費：";
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblTot.Location = new System.Drawing.Point(150, 176);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(72, 13);
            this.LblTot.TabIndex = 8;
            this.LblTot.Text = "累計收費：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 198);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.BtnCal);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.LblBuy);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbWT;
        private System.Windows.Forms.RadioButton RdbNum;
        private System.Windows.Forms.Label LblBuy;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnCal;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblTot;
    }
}

