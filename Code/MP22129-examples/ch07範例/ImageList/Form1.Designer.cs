namespace ImageList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.PicBrid = new System.Windows.Forms.PictureBox();
            this.ImgIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgBird = new System.Windows.Forms.ImageList(this.components);
            this.TmrFly = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStop
            // 
            this.BtnStop.ImageIndex = 1;
            this.BtnStop.ImageList = this.ImgIcon;
            this.BtnStop.Location = new System.Drawing.Point(229, 85);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(58, 58);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.ImageIndex = 0;
            this.BtnStart.ImageList = this.ImgIcon;
            this.BtnStart.Location = new System.Drawing.Point(152, 85);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(58, 58);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PicBrid
            // 
            this.PicBrid.Location = new System.Drawing.Point(25, 22);
            this.PicBrid.Name = "PicBrid";
            this.PicBrid.Size = new System.Drawing.Size(100, 50);
            this.PicBrid.TabIndex = 3;
            this.PicBrid.TabStop = false;
            // 
            // ImgIcon
            // 
            this.ImgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgIcon.ImageStream")));
            this.ImgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgIcon.Images.SetKeyName(0, "start.bmp");
            this.ImgIcon.Images.SetKeyName(1, "stop.bmp");
            // 
            // ImgBird
            // 
            this.ImgBird.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgBird.ImageStream")));
            this.ImgBird.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgBird.Images.SetKeyName(0, "bird1.gif");
            this.ImgBird.Images.SetKeyName(1, "bird2.gif");
            this.ImgBird.Images.SetKeyName(2, "bird3.gif");
            this.ImgBird.Images.SetKeyName(3, "bird4.gif");
            this.ImgBird.Images.SetKeyName(4, "bird5.gif");
            this.ImgBird.Images.SetKeyName(5, "bird6.gif");
            // 
            // TmrFly
            // 
            this.TmrFly.Tick += new System.EventHandler(this.TmrFly_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 162);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PicBrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ImageList ImgIcon;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox PicBrid;
        private System.Windows.Forms.ImageList ImgBird;
        private System.Windows.Forms.Timer TmrFly;
    }
}

