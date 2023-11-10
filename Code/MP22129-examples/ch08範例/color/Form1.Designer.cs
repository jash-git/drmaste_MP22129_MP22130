namespace color
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
            this.TkbRed = new System.Windows.Forms.TrackBar();
            this.TkbBlue = new System.Windows.Forms.TrackBar();
            this.TkbGreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PicColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TkbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicColor)).BeginInit();
            this.SuspendLayout();
            // 
            // TkbRed
            // 
            this.TkbRed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TkbRed.Location = new System.Drawing.Point(12, 171);
            this.TkbRed.Name = "TkbRed";
            this.TkbRed.Size = new System.Drawing.Size(103, 45);
            this.TkbRed.TabIndex = 0;
            this.TkbRed.Scroll += new System.EventHandler(this.TkbRed_Scroll);
            // 
            // TkbBlue
            // 
            this.TkbBlue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TkbBlue.Location = new System.Drawing.Point(251, 171);
            this.TkbBlue.Name = "TkbBlue";
            this.TkbBlue.Size = new System.Drawing.Size(103, 45);
            this.TkbBlue.TabIndex = 1;
            this.TkbBlue.Scroll += new System.EventHandler(this.TkbBlue_Scroll);
            // 
            // TkbGreen
            // 
            this.TkbGreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TkbGreen.Location = new System.Drawing.Point(132, 171);
            this.TkbGreen.Name = "TkbGreen";
            this.TkbGreen.Size = new System.Drawing.Size(103, 45);
            this.TkbGreen.TabIndex = 2;
            this.TkbGreen.Scroll += new System.EventHandler(this.TkbGreen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "紅色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "綠色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "藍色";
            // 
            // PicColor
            // 
            this.PicColor.Location = new System.Drawing.Point(22, 17);
            this.PicColor.Name = "PicColor";
            this.PicColor.Size = new System.Drawing.Size(331, 116);
            this.PicColor.TabIndex = 6;
            this.PicColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 226);
            this.Controls.Add(this.PicColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TkbGreen);
            this.Controls.Add(this.TkbBlue);
            this.Controls.Add(this.TkbRed);
            this.Name = "Form1";
            this.Text = "調色盤";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TkbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TkbRed;
        private System.Windows.Forms.TrackBar TkbBlue;
        private System.Windows.Forms.TrackBar TkbGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicColor;
    }
}

