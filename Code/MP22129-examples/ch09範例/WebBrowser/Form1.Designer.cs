namespace WebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.MnuSWeb = new System.Windows.Forms.MenuStrip();
            this.MnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuForward = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.網址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsTxtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.MnuMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.WebViewer = new System.Windows.Forms.WebBrowser();
            this.MnuSWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(714, 141);
            this.webBrowser1.TabIndex = 0;
            // 
            // MnuSWeb
            // 
            this.MnuSWeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuView,
            this.MnuExit,
            this.toolStripMenuItem1,
            this.網址ToolStripMenuItem,
            this.TsTxtUrl,
            this.MnuMsg});
            this.MnuSWeb.Location = new System.Drawing.Point(0, 0);
            this.MnuSWeb.Name = "MnuSWeb";
            this.MnuSWeb.Size = new System.Drawing.Size(714, 27);
            this.MnuSWeb.TabIndex = 1;
            this.MnuSWeb.Text = "menuStrip1";
            // 
            // MnuView
            // 
            this.MnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBack,
            this.MnuForward,
            this.MnuRefresh,
            this.MnuHome});
            this.MnuView.Name = "MnuView";
            this.MnuView.Size = new System.Drawing.Size(43, 23);
            this.MnuView.Text = "檢視";
            // 
            // MnuBack
            // 
            this.MnuBack.Name = "MnuBack";
            this.MnuBack.Size = new System.Drawing.Size(180, 22);
            this.MnuBack.Text = "上一頁";
            this.MnuBack.Click += new System.EventHandler(this.MnuBack_Click);
            // 
            // MnuForward
            // 
            this.MnuForward.Name = "MnuForward";
            this.MnuForward.Size = new System.Drawing.Size(180, 22);
            this.MnuForward.Text = "下一頁";
            this.MnuForward.Click += new System.EventHandler(this.MnuForward_Click);
            // 
            // MnuRefresh
            // 
            this.MnuRefresh.Name = "MnuRefresh";
            this.MnuRefresh.Size = new System.Drawing.Size(180, 22);
            this.MnuRefresh.Text = "重新整理";
            this.MnuRefresh.Click += new System.EventHandler(this.MnuRefresh_Click);
            // 
            // MnuHome
            // 
            this.MnuHome.Name = "MnuHome";
            this.MnuHome.Size = new System.Drawing.Size(180, 22);
            this.MnuHome.Text = "到首頁";
            this.MnuHome.Click += new System.EventHandler(this.MnuHome_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(43, 23);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 23);
            this.toolStripMenuItem1.Text = "|";
            // 
            // 網址ToolStripMenuItem
            // 
            this.網址ToolStripMenuItem.Name = "網址ToolStripMenuItem";
            this.網址ToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.網址ToolStripMenuItem.Text = "網址：";
            // 
            // TsTxtUrl
            // 
            this.TsTxtUrl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.TsTxtUrl.Name = "TsTxtUrl";
            this.TsTxtUrl.Size = new System.Drawing.Size(400, 23);
            this.TsTxtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TsTxtUrl_KeyPress);
            // 
            // MnuMsg
            // 
            this.MnuMsg.Name = "MnuMsg";
            this.MnuMsg.Size = new System.Drawing.Size(133, 23);
            this.MnuMsg.Text = "toolStripMenuItem2";
            // 
            // WebViewer
            // 
            this.WebViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebViewer.Location = new System.Drawing.Point(0, 27);
            this.WebViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebViewer.Name = "WebViewer";
            this.WebViewer.Size = new System.Drawing.Size(714, 114);
            this.WebViewer.TabIndex = 2;
            this.WebViewer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebViewer_DocumentCompleted);
            this.WebViewer.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebViewer_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 141);
            this.Controls.Add(this.WebViewer);
            this.Controls.Add(this.MnuSWeb);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MnuSWeb.ResumeLayout(false);
            this.MnuSWeb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip MnuSWeb;
        private System.Windows.Forms.ToolStripMenuItem MnuView;
        private System.Windows.Forms.ToolStripMenuItem MnuBack;
        private System.Windows.Forms.ToolStripMenuItem MnuForward;
        private System.Windows.Forms.ToolStripMenuItem MnuRefresh;
        private System.Windows.Forms.ToolStripMenuItem MnuHome;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 網址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TsTxtUrl;
        private System.Windows.Forms.ToolStripMenuItem MnuMsg;
        private System.Windows.Forms.WebBrowser WebViewer;
    }
}

