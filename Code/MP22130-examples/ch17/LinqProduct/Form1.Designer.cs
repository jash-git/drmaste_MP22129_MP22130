
namespace LinqProduct
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
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnAsc = new System.Windows.Forms.Button();
            this.BtnDesc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProduct
            // 
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Location = new System.Drawing.Point(12, 12);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.RowTemplate.Height = 24;
            this.DgvProduct.Size = new System.Drawing.Size(345, 170);
            this.DgvProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "輸入查詢品名：";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(363, 27);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(75, 22);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(363, 59);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(363, 92);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 3;
            this.BtnList.Text = "產品資料";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnAsc
            // 
            this.BtnAsc.Location = new System.Drawing.Point(363, 125);
            this.BtnAsc.Name = "BtnAsc";
            this.BtnAsc.Size = new System.Drawing.Size(75, 23);
            this.BtnAsc.TabIndex = 3;
            this.BtnAsc.Text = "遞增排序";
            this.BtnAsc.UseVisualStyleBackColor = true;
            this.BtnAsc.Click += new System.EventHandler(this.BtnAsc_Click);
            // 
            // BtnDesc
            // 
            this.BtnDesc.Location = new System.Drawing.Point(363, 158);
            this.BtnDesc.Name = "BtnDesc";
            this.BtnDesc.Size = new System.Drawing.Size(75, 23);
            this.BtnDesc.TabIndex = 3;
            this.BtnDesc.Text = "遞減排序";
            this.BtnDesc.UseVisualStyleBackColor = true;
            this.BtnDesc.Click += new System.EventHandler(this.BtnDesc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 194);
            this.Controls.Add(this.BtnDesc);
            this.Controls.Add(this.BtnAsc);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnAsc;
        private System.Windows.Forms.Button BtnDesc;
    }
}

