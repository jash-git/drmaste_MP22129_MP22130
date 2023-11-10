namespace WinWavPlayer
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
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnLoop = new System.Windows.Forms.Button();
            this.BbtnPlay = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(264, 73);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(64, 22);
            this.BtnEnd.TabIndex = 48;
            this.BtnEnd.Text = "結束";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(185, 73);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(64, 22);
            this.BtnStop.TabIndex = 47;
            this.BtnStop.Text = "停止播放";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnLoop
            // 
            this.BtnLoop.Location = new System.Drawing.Point(106, 73);
            this.BtnLoop.Name = "BtnLoop";
            this.BtnLoop.Size = new System.Drawing.Size(64, 22);
            this.BtnLoop.TabIndex = 46;
            this.BtnLoop.Text = "重複播放";
            this.BtnLoop.UseVisualStyleBackColor = true;
            this.BtnLoop.Click += new System.EventHandler(this.BtnLoop_Click);
            // 
            // BbtnPlay
            // 
            this.BbtnPlay.Location = new System.Drawing.Point(27, 73);
            this.BbtnPlay.Name = "BbtnPlay";
            this.BbtnPlay.Size = new System.Drawing.Size(64, 22);
            this.BbtnPlay.TabIndex = 45;
            this.BbtnPlay.Text = "播放一次";
            this.BbtnPlay.UseVisualStyleBackColor = true;
            this.BbtnPlay.Click += new System.EventHandler(this.BbtnPlay_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(276, 20);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(64, 22);
            this.BtnBrowse.TabIndex = 44;
            this.BtnBrowse.Text = "瀏覽";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(76, 20);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(189, 22);
            this.TxtPath.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "音效位置：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 111);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnLoop);
            this.Controls.Add(this.BbtnPlay);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "音效檔播放器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnLoop;
        private System.Windows.Forms.Button BbtnPlay;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

