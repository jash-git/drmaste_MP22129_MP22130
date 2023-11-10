
namespace LinqDataSet
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
            this.DgvShow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnPrice = new System.Windows.Forms.Button();
            this.BtnAmount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvShow
            // 
            this.DgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShow.Location = new System.Drawing.Point(12, 12);
            this.DgvShow.Name = "DgvShow";
            this.DgvShow.RowTemplate.Height = 24;
            this.DgvShow.Size = new System.Drawing.Size(466, 208);
            this.DgvShow.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "產品關鍵字查詢：";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(486, 169);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(114, 22);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(486, 197);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(484, 12);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(116, 23);
            this.BtnInfo.TabIndex = 4;
            this.BtnInfo.Text = "產品資訊";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnPrice
            // 
            this.BtnPrice.Location = new System.Drawing.Point(484, 53);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(116, 23);
            this.BtnPrice.TabIndex = 5;
            this.BtnPrice.Text = "依單價遞增排序";
            this.BtnPrice.UseVisualStyleBackColor = true;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // BtnAmount
            // 
            this.BtnAmount.Location = new System.Drawing.Point(484, 94);
            this.BtnAmount.Name = "BtnAmount";
            this.BtnAmount.Size = new System.Drawing.Size(116, 23);
            this.BtnAmount.TabIndex = 6;
            this.BtnAmount.Text = "依庫存量遞減排序";
            this.BtnAmount.UseVisualStyleBackColor = true;
            this.BtnAmount.Click += new System.EventHandler(this.BtnAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 229);
            this.Controls.Add(this.BtnAmount);
            this.Controls.Add(this.BtnPrice);
            this.Controls.Add(this.BtnInfo);
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

        private System.Windows.Forms.DataGridView DgvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnPrice;
        private System.Windows.Forms.Button BtnAmount;
    }
}

