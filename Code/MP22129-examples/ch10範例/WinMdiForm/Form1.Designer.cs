﻿
namespace WinMdiForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAdd,
            this.MnuWindow,
            this.MnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuAdd
            // 
            this.MnuAdd.Name = "MnuAdd";
            this.MnuAdd.Size = new System.Drawing.Size(43, 20);
            this.MnuAdd.Text = "新增";
            this.MnuAdd.Click += new System.EventHandler(this.MnuAdd_Click);
            // 
            // MnuWindow
            // 
            this.MnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCascade,
            this.MnuHorizontal,
            this.MnuVertical});
            this.MnuWindow.Name = "MnuWindow";
            this.MnuWindow.Size = new System.Drawing.Size(43, 20);
            this.MnuWindow.Text = "視窗";
            // 
            // MnuCascade
            // 
            this.MnuCascade.Name = "MnuCascade";
            this.MnuCascade.Size = new System.Drawing.Size(180, 22);
            this.MnuCascade.Text = "重疊排列";
            this.MnuCascade.Click += new System.EventHandler(this.MnuCascade_Click);
            // 
            // MnuHorizontal
            // 
            this.MnuHorizontal.Name = "MnuHorizontal";
            this.MnuHorizontal.Size = new System.Drawing.Size(180, 22);
            this.MnuHorizontal.Text = "水平並排";
            this.MnuHorizontal.Click += new System.EventHandler(this.MnuHorizontal_Click);
            // 
            // MnuVertical
            // 
            this.MnuVertical.Name = "MnuVertical";
            this.MnuVertical.Size = new System.Drawing.Size(180, 22);
            this.MnuVertical.Text = "垂直並排";
            this.MnuVertical.Click += new System.EventHandler(this.MnuVertical_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(43, 20);
            this.MnuExit.Text = "結束";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 141);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MDI多表單程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuAdd;
        private System.Windows.Forms.ToolStripMenuItem MnuWindow;
        private System.Windows.Forms.ToolStripMenuItem MnuCascade;
        private System.Windows.Forms.ToolStripMenuItem MnuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MnuVertical;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

