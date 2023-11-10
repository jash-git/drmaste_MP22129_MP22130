
namespace LinqScore
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
            this.LstScore = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstScore
            // 
            this.LstScore.FormattingEnabled = true;
            this.LstScore.ItemHeight = 12;
            this.LstScore.Location = new System.Drawing.Point(79, 37);
            this.LstScore.Name = "LstScore";
            this.LstScore.Size = new System.Drawing.Size(100, 88);
            this.LstScore.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查詢成績：";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(79, 6);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(100, 22);
            this.TxtScore.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(204, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "單筆查詢";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(204, 37);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(75, 23);
            this.BtnList.TabIndex = 4;
            this.BtnList.Text = "成績表列";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(204, 66);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(75, 23);
            this.BtnInfo.TabIndex = 4;
            this.BtnInfo.Text = "成績資訊";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(204, 95);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 4;
            this.BtnSort.Text = "遞減排序";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 134);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnInfo);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.Button BtnSort;
    }
}

