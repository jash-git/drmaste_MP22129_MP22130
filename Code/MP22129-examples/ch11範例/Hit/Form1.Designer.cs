namespace Hit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TmrT = new System.Windows.Forms.Timer(this.components);
            this.ImgPic = new System.Windows.Forms.ImageList(this.components);
            this.Pic9 = new System.Windows.Forms.PictureBox();
            this.Pic6 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic8 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic7 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblMiss = new System.Windows.Forms.Label();
            this.LblHit = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrT
            // 
            this.TmrT.Tick += new System.EventHandler(this.TmrT_Tick);
            // 
            // ImgPic
            // 
            this.ImgPic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgPic.ImageStream")));
            this.ImgPic.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgPic.Images.SetKeyName(0, "hit1.gif");
            this.ImgPic.Images.SetKeyName(1, "hit2.gif");
            // 
            // Pic9
            // 
            this.Pic9.Location = new System.Drawing.Point(148, 152);
            this.Pic9.Name = "Pic9";
            this.Pic9.Size = new System.Drawing.Size(60, 60);
            this.Pic9.TabIndex = 23;
            this.Pic9.TabStop = false;
            // 
            // Pic6
            // 
            this.Pic6.Location = new System.Drawing.Point(148, 85);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(60, 60);
            this.Pic6.TabIndex = 24;
            this.Pic6.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.Location = new System.Drawing.Point(147, 19);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(60, 60);
            this.Pic3.TabIndex = 25;
            this.Pic3.TabStop = false;
            // 
            // Pic8
            // 
            this.Pic8.Location = new System.Drawing.Point(82, 152);
            this.Pic8.Name = "Pic8";
            this.Pic8.Size = new System.Drawing.Size(60, 60);
            this.Pic8.TabIndex = 26;
            this.Pic8.TabStop = false;
            // 
            // Pic5
            // 
            this.Pic5.Location = new System.Drawing.Point(82, 85);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(60, 60);
            this.Pic5.TabIndex = 27;
            this.Pic5.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(81, 19);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(60, 60);
            this.Pic2.TabIndex = 28;
            this.Pic2.TabStop = false;
            // 
            // Pic7
            // 
            this.Pic7.Location = new System.Drawing.Point(16, 152);
            this.Pic7.Name = "Pic7";
            this.Pic7.Size = new System.Drawing.Size(60, 60);
            this.Pic7.TabIndex = 29;
            this.Pic7.TabStop = false;
            // 
            // Pic4
            // 
            this.Pic4.Location = new System.Drawing.Point(16, 85);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(60, 60);
            this.Pic4.TabIndex = 30;
            this.Pic4.TabStop = false;
            // 
            // Pic1
            // 
            this.Pic1.Location = new System.Drawing.Point(15, 19);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(60, 60);
            this.Pic1.TabIndex = 31;
            this.Pic1.TabStop = false;
            this.Pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("新細明體", 12F);
            this.LblTime.Location = new System.Drawing.Point(214, 139);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(52, 16);
            this.LblTime.TabIndex = 22;
            this.LblTime.Text = "30.0秒";
            // 
            // LblMiss
            // 
            this.LblMiss.AutoSize = true;
            this.LblMiss.Font = new System.Drawing.Font("新細明體", 12F);
            this.LblMiss.Location = new System.Drawing.Point(214, 196);
            this.LblMiss.Name = "LblMiss";
            this.LblMiss.Size = new System.Drawing.Size(88, 16);
            this.LblMiss.TabIndex = 21;
            this.LblMiss.Text = "失誤： 0 次";
            // 
            // LblHit
            // 
            this.LblHit.AutoSize = true;
            this.LblHit.Font = new System.Drawing.Font("新細明體", 12F);
            this.LblHit.Location = new System.Drawing.Point(214, 168);
            this.LblHit.Name = "LblHit";
            this.LblHit.Size = new System.Drawing.Size(88, 16);
            this.LblHit.TabIndex = 20;
            this.LblHit.Text = "擊中： 0 次";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(214, 104);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 19;
            this.BtnStart.Text = "開始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 230);
            this.Controls.Add(this.Pic9);
            this.Controls.Add(this.Pic6);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic8);
            this.Controls.Add(this.Pic5);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic7);
            this.Controls.Add(this.Pic4);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblMiss);
            this.Controls.Add(this.LblHit);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "打地鼠";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TmrT;
        private System.Windows.Forms.ImageList ImgPic;
        private System.Windows.Forms.PictureBox Pic9;
        private System.Windows.Forms.PictureBox Pic6;
        private System.Windows.Forms.PictureBox Pic3;
        private System.Windows.Forms.PictureBox Pic8;
        private System.Windows.Forms.PictureBox Pic5;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic7;
        private System.Windows.Forms.PictureBox Pic4;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblMiss;
        private System.Windows.Forms.Label LblHit;
        private System.Windows.Forms.Button BtnStart;
    }
}

