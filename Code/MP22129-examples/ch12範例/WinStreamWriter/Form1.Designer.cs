namespace WinStreamWriter
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
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAppend = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.TxtPad = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtShow
            // 
            this.TxtShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtShow.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtShow.Location = new System.Drawing.Point(9, 95);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.ReadOnly = true;
            this.TxtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtShow.Size = new System.Drawing.Size(162, 73);
            this.TxtShow.TabIndex = 42;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnClear.Location = new System.Drawing.Point(183, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(65, 26);
            this.BtnClear.TabIndex = 41;
            this.BtnClear.Text = "清除";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAppend
            // 
            this.BtnAppend.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAppend.Location = new System.Drawing.Point(183, 76);
            this.BtnAppend.Name = "BtnAppend";
            this.BtnAppend.Size = new System.Drawing.Size(65, 26);
            this.BtnAppend.TabIndex = 40;
            this.BtnAppend.Text = "加入";
            this.BtnAppend.UseVisualStyleBackColor = true;
            this.BtnAppend.Click += new System.EventHandler(this.BtnAppend_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(183, 156);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 12);
            this.LblMsg.TabIndex = 39;
            this.LblMsg.Text = "label1";
            // 
            // BtnEnd
            // 
            this.BtnEnd.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnEnd.Location = new System.Drawing.Point(183, 108);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(65, 26);
            this.BtnEnd.TabIndex = 38;
            this.BtnEnd.Text = "結束";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // TxtPad
            // 
            this.TxtPad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPad.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtPad.Location = new System.Drawing.Point(9, 12);
            this.TxtPad.Multiline = true;
            this.TxtPad.Name = "TxtPad";
            this.TxtPad.Size = new System.Drawing.Size(162, 75);
            this.TxtPad.TabIndex = 37;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCreate.Location = new System.Drawing.Point(183, 44);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(65, 26);
            this.BtnCreate.TabIndex = 36;
            this.BtnCreate.Text = "新增";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 180);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAppend);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.TxtPad);
            this.Controls.Add(this.BtnCreate);
            this.Name = "Form1";
            this.Text = "StreamWriter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAppend;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.TextBox TxtPad;
        private System.Windows.Forms.Button BtnCreate;
    }
}

