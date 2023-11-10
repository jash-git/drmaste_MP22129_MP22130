namespace PicShow
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsBtnStart = new System.Windows.Forms.ToolStripButton();
            this.TsBtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TsCboPic = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TsTxtMsg = new System.Windows.Forms.ToolStripTextBox();
            this.TmrMove = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.LblMsg = new System.Windows.Forms.Label();
            this.PicPicture = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnStart,
            this.TsBtnStop,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TsCboPic,
            this.toolStripLabel2,
            this.TsTxtMsg});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(360, 25);
            this.toolStrip1.TabIndex = 6;
            // 
            // TsBtnStart
            // 
            this.TsBtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsBtnStart.Image = global::PicShow.Properties.Resources.start;
            this.TsBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnStart.Name = "TsBtnStart";
            this.TsBtnStart.Size = new System.Drawing.Size(23, 22);
            this.TsBtnStart.Text = "toolStripButton1";
            this.TsBtnStart.ToolTipText = "開始";
            this.TsBtnStart.Click += new System.EventHandler(this.TsBtnStart_Click);
            // 
            // TsBtnStop
            // 
            this.TsBtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsBtnStop.Image = global::PicShow.Properties.Resources.stop;
            this.TsBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnStop.Name = "TsBtnStop";
            this.TsBtnStop.Size = new System.Drawing.Size(23, 22);
            this.TsBtnStop.Text = "toolStripButton2";
            this.TsBtnStop.ToolTipText = "暫停";
            this.TsBtnStop.Click += new System.EventHandler(this.TsBtnStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "圖片：";
            // 
            // TsCboPic
            // 
            this.TsCboPic.Items.AddRange(new object[] {
            "第一張",
            "第二張",
            "第三張",
            "第四張",
            "第五張",
            "第六張"});
            this.TsCboPic.Name = "TsCboPic";
            this.TsCboPic.Size = new System.Drawing.Size(75, 25);
            this.TsCboPic.SelectedIndexChanged += new System.EventHandler(this.TsCboPic_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "標題：";
            // 
            // TsTxtMsg
            // 
            this.TsTxtMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.TsTxtMsg.Name = "TsTxtMsg";
            this.TsTxtMsg.Size = new System.Drawing.Size(100, 25);
            this.TsTxtMsg.Text = "生日快樂";
            this.TsTxtMsg.TextChanged += new System.EventHandler(this.TsTxtMsg_TextChanged);
            // 
            // TmrMove
            // 
            this.TmrMove.Tick += new System.EventHandler(this.TmrMove_Tick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LblMsg);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.PicPicture);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(391, 281);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(391, 306);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.BackColor = System.Drawing.SystemColors.Control;
            this.LblMsg.Font = new System.Drawing.Font("標楷體", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(12, 220);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(137, 37);
            this.LblMsg.TabIndex = 6;
            this.LblMsg.Text = "label1";
            // 
            // PicPicture
            // 
            this.PicPicture.Image = global::PicShow.Properties.Resources._6;
            this.PicPicture.Location = new System.Drawing.Point(-4, 3);
            this.PicPicture.Name = "PicPicture";
            this.PicPicture.Size = new System.Drawing.Size(395, 275);
            this.PicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPicture.TabIndex = 7;
            this.PicPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 306);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsBtnStart;
        private System.Windows.Forms.ToolStripButton TsBtnStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox TsCboPic;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TsTxtMsg;
        private System.Windows.Forms.Timer TmrMove;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.PictureBox PicPicture;
    }
}

