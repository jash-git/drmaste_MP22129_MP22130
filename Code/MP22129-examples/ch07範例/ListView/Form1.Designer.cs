﻿namespace ListView
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
            this.ImgL = new System.Windows.Forms.ImageList(this.components);
            this.ImgS = new System.Windows.Forms.ImageList(this.components);
            this.LstBorrow = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboView = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstvBooks = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ImgL
            // 
            this.ImgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgL.ImageStream")));
            this.ImgL.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgL.Images.SetKeyName(0, "Book1.bmp");
            this.ImgL.Images.SetKeyName(1, "Book2.bmp");
            this.ImgL.Images.SetKeyName(2, "Book3.bmp");
            this.ImgL.Images.SetKeyName(3, "Book4.bmp");
            this.ImgL.Images.SetKeyName(4, "Book5.bmp");
            this.ImgL.Images.SetKeyName(5, "Book6.bmp");
            this.ImgL.Images.SetKeyName(6, "Book7.bmp");
            this.ImgL.Images.SetKeyName(7, "Book8.bmp");
            // 
            // ImgS
            // 
            this.ImgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgS.ImageStream")));
            this.ImgS.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgS.Images.SetKeyName(0, "Book1.bmp");
            this.ImgS.Images.SetKeyName(1, "Book2.bmp");
            this.ImgS.Images.SetKeyName(2, "Book3.bmp");
            this.ImgS.Images.SetKeyName(3, "Book4.bmp");
            this.ImgS.Images.SetKeyName(4, "Book5.bmp");
            this.ImgS.Images.SetKeyName(5, "Book6.bmp");
            this.ImgS.Images.SetKeyName(6, "Book7.bmp");
            this.ImgS.Images.SetKeyName(7, "Book8.bmp");
            // 
            // LstBorrow
            // 
            this.LstBorrow.FormattingEnabled = true;
            this.LstBorrow.ItemHeight = 12;
            this.LstBorrow.Location = new System.Drawing.Point(231, 146);
            this.LstBorrow.Name = "LstBorrow";
            this.LstBorrow.Size = new System.Drawing.Size(120, 88);
            this.LstBorrow.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "借書清單：";
            // 
            // CboView
            // 
            this.CboView.FormattingEnabled = true;
            this.CboView.Location = new System.Drawing.Point(230, 34);
            this.CboView.Name = "CboView";
            this.CboView.Size = new System.Drawing.Size(121, 20);
            this.CboView.TabIndex = 7;
            this.CboView.SelectedIndexChanged += new System.EventHandler(this.CboView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "檢視方式：";
            // 
            // LstvBooks
            // 
            this.LstvBooks.HideSelection = false;
            this.LstvBooks.Location = new System.Drawing.Point(16, 9);
            this.LstvBooks.Name = "LstvBooks";
            this.LstvBooks.Size = new System.Drawing.Size(200, 225);
            this.LstvBooks.TabIndex = 5;
            this.LstvBooks.UseCompatibleStateImageBehavior = false;
            this.LstvBooks.ItemActivate += new System.EventHandler(this.LstvBooks_ItemActivate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 243);
            this.Controls.Add(this.LstBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstvBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ImgL;
        private System.Windows.Forms.ImageList ImgS;
        private System.Windows.Forms.ListBox LstBorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LstvBooks;
    }
}

