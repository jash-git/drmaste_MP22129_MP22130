
namespace LinqSalary
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
            this.BtnId = new System.Windows.Forms.Button();
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvSalary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnId
            // 
            this.BtnId.Location = new System.Drawing.Point(380, 12);
            this.BtnId.Name = "BtnId";
            this.BtnId.Size = new System.Drawing.Size(75, 23);
            this.BtnId.TabIndex = 1;
            this.BtnId.Text = "依編號排";
            this.BtnId.UseVisualStyleBackColor = true;
            this.BtnId.Click += new System.EventHandler(this.BtnId_Click);
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(380, 39);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(75, 23);
            this.BtnName.TabIndex = 1;
            this.BtnName.Text = "依姓名排";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // BtnSalary
            // 
            this.BtnSalary.Location = new System.Drawing.Point(380, 68);
            this.BtnSalary.Name = "BtnSalary";
            this.BtnSalary.Size = new System.Drawing.Size(75, 23);
            this.BtnSalary.TabIndex = 1;
            this.BtnSalary.Text = "依薪資排";
            this.BtnSalary.UseVisualStyleBackColor = true;
            this.BtnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "員工編號：";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(382, 109);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(75, 22);
            this.TxtId.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(382, 137);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "單筆查詢";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvSalary
            // 
            this.DgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSalary.Location = new System.Drawing.Point(12, 12);
            this.DgvSalary.Name = "DgvSalary";
            this.DgvSalary.RowTemplate.Height = 24;
            this.DgvSalary.Size = new System.Drawing.Size(362, 148);
            this.DgvSalary.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 170);
            this.Controls.Add(this.DgvSalary);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnSalary);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.BtnId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnId;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Button BtnSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvSalary;
    }
}

