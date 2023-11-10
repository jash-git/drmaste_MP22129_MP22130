
namespace LinqXml
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
            this.BtnPM25 = new System.Windows.Forms.Button();
            this.BtnCounty = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPM25
            // 
            this.BtnPM25.Location = new System.Drawing.Point(383, 53);
            this.BtnPM25.Name = "BtnPM25";
            this.BtnPM25.Size = new System.Drawing.Size(116, 23);
            this.BtnPM25.TabIndex = 13;
            this.BtnPM25.Text = "依PM2.5遞減排序";
            this.BtnPM25.UseVisualStyleBackColor = true;
            this.BtnPM25.Click += new System.EventHandler(this.BtnPM25_Click);
            // 
            // BtnCounty
            // 
            this.BtnCounty.Location = new System.Drawing.Point(383, 12);
            this.BtnCounty.Name = "BtnCounty";
            this.BtnCounty.Size = new System.Drawing.Size(116, 23);
            this.BtnCounty.TabIndex = 12;
            this.BtnCounty.Text = "依縣市遞增排序";
            this.BtnCounty.UseVisualStyleBackColor = true;
            this.BtnCounty.Click += new System.EventHandler(this.BtnCounty_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(385, 144);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(385, 116);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(114, 22);
            this.TxtSearch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "PM2.5濃度查詢：";
            // 
            // DgvShow
            // 
            this.DgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShow.Location = new System.Drawing.Point(10, 10);
            this.DgvShow.Name = "DgvShow";
            this.DgvShow.RowTemplate.Height = 24;
            this.DgvShow.Size = new System.Drawing.Size(367, 157);
            this.DgvShow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 175);
            this.Controls.Add(this.BtnPM25);
            this.Controls.Add(this.BtnCounty);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPM25;
        private System.Windows.Forms.Button BtnCounty;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvShow;
    }
}

