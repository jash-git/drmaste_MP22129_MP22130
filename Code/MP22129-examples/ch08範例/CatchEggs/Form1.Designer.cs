namespace CatchEggs
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
            this.components = new System.ComponentModel.Container();
            this.PicBowl = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LblMsg = new System.Windows.Forms.Label();
            this.PicEgg = new System.Windows.Forms.PictureBox();
            this.HsbMove = new System.Windows.Forms.HScrollBar();
            this.TmrFall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBowl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBowl
            // 
            this.PicBowl.Location = new System.Drawing.Point(116, 168);
            this.PicBowl.Name = "PicBowl";
            this.PicBowl.Size = new System.Drawing.Size(40, 24);
            this.PicBowl.TabIndex = 11;
            this.PicBowl.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(319, 194);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(44, 23);
            this.BtnStart.TabIndex = 14;
            this.BtnStart.Text = "開始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Location = new System.Drawing.Point(12, 24);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(33, 12);
            this.LblMsg.TabIndex = 13;
            this.LblMsg.Text = "label1";
            // 
            // PicEgg
            // 
            this.PicEgg.Location = new System.Drawing.Point(203, 23);
            this.PicEgg.Name = "PicEgg";
            this.PicEgg.Size = new System.Drawing.Size(16, 24);
            this.PicEgg.TabIndex = 12;
            this.PicEgg.TabStop = false;
            // 
            // HsbMove
            // 
            this.HsbMove.Location = new System.Drawing.Point(9, 194);
            this.HsbMove.Name = "HsbMove";
            this.HsbMove.Size = new System.Drawing.Size(300, 20);
            this.HsbMove.TabIndex = 10;
            this.HsbMove.ValueChanged += new System.EventHandler(this.HsbMove_ValueChanged);
            // 
            // TmrFall
            // 
            this.TmrFall.Tick += new System.EventHandler(this.TmrFall_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(373, 224);
            this.Controls.Add(this.PicBowl);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.PicEgg);
            this.Controls.Add(this.HsbMove);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBowl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEgg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBowl;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.PictureBox PicEgg;
        private System.Windows.Forms.HScrollBar HsbMove;
        private System.Windows.Forms.Timer TmrFall;
    }
}

