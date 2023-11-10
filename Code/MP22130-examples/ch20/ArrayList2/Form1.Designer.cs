namespace ArrayList2
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
            this.Lbl = new System.Windows.Forms.Label();
            this.BtnSort = new System.Windows.Forms.Button();
            this.TxtPer = new System.Windows.Forms.TextBox();
            this.BtnRev = new System.Windows.Forms.Button();
            this.BtnPer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbl.Location = new System.Drawing.Point(15, 16);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(46, 13);
            this.Lbl.TabIndex = 2;
            this.Lbl.Text = "名單：";
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(134, 62);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(67, 21);
            this.BtnSort.TabIndex = 1;
            this.BtnSort.Text = "遞增排序";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // TxtPer
            // 
            this.TxtPer.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtPer.Location = new System.Drawing.Point(18, 35);
            this.TxtPer.Multiline = true;
            this.TxtPer.Name = "TxtPer";
            this.TxtPer.Size = new System.Drawing.Size(87, 79);
            this.TxtPer.TabIndex = 5;
            // 
            // BtnRev
            // 
            this.BtnRev.Location = new System.Drawing.Point(135, 89);
            this.BtnRev.Name = "BtnRev";
            this.BtnRev.Size = new System.Drawing.Size(67, 21);
            this.BtnRev.TabIndex = 2;
            this.BtnRev.Text = "遞減排序";
            this.BtnRev.UseVisualStyleBackColor = true;
            this.BtnRev.Click += new System.EventHandler(this.BtnRev_Click);
            // 
            // BtnPer
            // 
            this.BtnPer.Location = new System.Drawing.Point(134, 34);
            this.BtnPer.Name = "BtnPer";
            this.BtnPer.Size = new System.Drawing.Size(67, 21);
            this.BtnPer.TabIndex = 0;
            this.BtnPer.Text = "原來名單";
            this.BtnPer.UseVisualStyleBackColor = true;
            this.BtnPer.Click += new System.EventHandler(this.BtnPer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "輸入名字：";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtName.Location = new System.Drawing.Point(83, 134);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(62, 23);
            this.TxtName.TabIndex = 7;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(11, 167);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 13);
            this.LblMsg.TabIndex = 8;
            this.LblMsg.Text = "訊息";
            // 
            // BtnIndex
            // 
            this.BtnIndex.Location = new System.Drawing.Point(154, 135);
            this.BtnIndex.Name = "BtnIndex";
            this.BtnIndex.Size = new System.Drawing.Size(46, 21);
            this.BtnIndex.TabIndex = 9;
            this.BtnIndex.Text = "搜尋";
            this.BtnIndex.UseVisualStyleBackColor = true;
            this.BtnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 191);
            this.Controls.Add(this.BtnIndex);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPer);
            this.Controls.Add(this.BtnRev);
            this.Controls.Add(this.TxtPer);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.Lbl);
            this.Name = "Form1";
            this.Text = "串列";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox TxtPer;
        private System.Windows.Forms.Button BtnRev;
        private System.Windows.Forms.Button BtnPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnIndex;
    }
}

