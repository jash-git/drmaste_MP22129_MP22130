namespace BirdFly
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
            this.PicBird = new System.Windows.Forms.PictureBox();
            this.TmrFly = new System.Windows.Forms.Timer(this.components);
            this.SttFly = new System.Windows.Forms.StatusStrip();
            this.TsBtnSpeed = new System.Windows.Forms.ToolStripSplitButton();
            this.MnuFast = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSlow = new System.Windows.Forms.ToolStripMenuItem();
            this.TsLblSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsPrgFly = new System.Windows.Forms.ToolStripProgressBar();
            this.TsLblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBird)).BeginInit();
            this.SttFly.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBird
            // 
            this.PicBird.Image = global::BirdFly.Properties.Resources.bird;
            this.PicBird.Location = new System.Drawing.Point(0, 6);
            this.PicBird.Name = "PicBird";
            this.PicBird.Size = new System.Drawing.Size(62, 50);
            this.PicBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBird.TabIndex = 6;
            this.PicBird.TabStop = false;
            // 
            // TmrFly
            // 
            this.TmrFly.Tick += new System.EventHandler(this.TmrFly_Tick);
            // 
            // SttFly
            // 
            this.SttFly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnSpeed,
            this.TsLblSpeed,
            this.TsPrgFly,
            this.TsLblMsg});
            this.SttFly.Location = new System.Drawing.Point(0, 79);
            this.SttFly.Name = "SttFly";
            this.SttFly.Size = new System.Drawing.Size(364, 22);
            this.SttFly.TabIndex = 5;
            this.SttFly.Text = "statusStrip1";
            // 
            // TsBtnSpeed
            // 
            this.TsBtnSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsBtnSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFast,
            this.MnuSlow});
            this.TsBtnSpeed.Image = global::BirdFly.Properties.Resources.bird;
            this.TsBtnSpeed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnSpeed.Name = "TsBtnSpeed";
            this.TsBtnSpeed.Size = new System.Drawing.Size(32, 20);
            this.TsBtnSpeed.Text = "toolStripSplitButton1";
            this.TsBtnSpeed.ButtonClick += new System.EventHandler(this.TsBtnSpeed_ButtonClick);
            // 
            // MnuFast
            // 
            this.MnuFast.Name = "MnuFast";
            this.MnuFast.Size = new System.Drawing.Size(180, 22);
            this.MnuFast.Text = "快速";
            this.MnuFast.Click += new System.EventHandler(this.MnuFast_Click);
            // 
            // MnuSlow
            // 
            this.MnuSlow.Name = "MnuSlow";
            this.MnuSlow.Size = new System.Drawing.Size(180, 22);
            this.MnuSlow.Text = "慢速";
            this.MnuSlow.Click += new System.EventHandler(this.MnuSlow_Click);
            // 
            // TsLblSpeed
            // 
            this.TsLblSpeed.Name = "TsLblSpeed";
            this.TsLblSpeed.Size = new System.Drawing.Size(31, 17);
            this.TsLblSpeed.Text = "慢速";
            // 
            // TsPrgFly
            // 
            this.TsPrgFly.Name = "TsPrgFly";
            this.TsPrgFly.Size = new System.Drawing.Size(100, 16);
            // 
            // TsLblMsg
            // 
            this.TsLblMsg.Name = "TsLblMsg";
            this.TsLblMsg.Size = new System.Drawing.Size(43, 17);
            this.TsLblMsg.Text = "進度：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 101);
            this.Controls.Add(this.PicBird);
            this.Controls.Add(this.SttFly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBird)).EndInit();
            this.SttFly.ResumeLayout(false);
            this.SttFly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBird;
        private System.Windows.Forms.Timer TmrFly;
        private System.Windows.Forms.StatusStrip SttFly;
        private System.Windows.Forms.ToolStripSplitButton TsBtnSpeed;
        private System.Windows.Forms.ToolStripMenuItem MnuFast;
        private System.Windows.Forms.ToolStripMenuItem MnuSlow;
        private System.Windows.Forms.ToolStripStatusLabel TsLblSpeed;
        private System.Windows.Forms.ToolStripProgressBar TsPrgFly;
        private System.Windows.Forms.ToolStripStatusLabel TsLblMsg;
    }
}

