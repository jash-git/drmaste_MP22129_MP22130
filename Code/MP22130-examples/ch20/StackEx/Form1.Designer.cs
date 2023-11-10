namespace StackEx
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnCln = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtName.Location = new System.Drawing.Point(25, 23);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(113, 96);
            this.TxtName.TabIndex = 0;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(22, 136);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(35, 13);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入名字：";
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(98, 168);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(62, 22);
            this.TxtAdd.TabIndex = 3;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(175, 21);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(70, 24);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "刪除一筆";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnCln
            // 
            this.BtnCln.Location = new System.Drawing.Point(175, 99);
            this.BtnCln.Name = "BtnCln";
            this.BtnCln.Size = new System.Drawing.Size(70, 24);
            this.BtnCln.TabIndex = 5;
            this.BtnCln.Text = "清除堆疊";
            this.BtnCln.UseVisualStyleBackColor = true;
            this.BtnCln.Click += new System.EventHandler(this.BtnCln_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.Location = new System.Drawing.Point(175, 60);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(70, 24);
            this.BtnTop.TabIndex = 6;
            this.BtnTop.Text = "Top資料";
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtnTop_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(175, 165);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 24);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "加入";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 202);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnTop);
            this.Controls.Add(this.BtnCln);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.TxtAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "堆疊";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnCln;
        private System.Windows.Forms.Button BtnTop;
        private System.Windows.Forms.Button BtnAdd;
    }
}

