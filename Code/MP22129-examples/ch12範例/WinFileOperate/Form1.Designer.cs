namespace WinFileOperate
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnMove = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.TxtDest = new System.Windows.Forms.TextBox();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDir
            // 
            this.TxtDir.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtDir.Location = new System.Drawing.Point(85, 80);
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(208, 23);
            this.TxtDir.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "資料夾名稱：";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(128, 224);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(51, 20);
            this.BtnCheck.TabIndex = 48;
            this.BtnCheck.Text = "查看";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnMove
            // 
            this.BtnMove.Location = new System.Drawing.Point(242, 224);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(51, 20);
            this.BtnMove.TabIndex = 47;
            this.BtnMove.Text = "搬移";
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(185, 224);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(51, 20);
            this.BtnDelete.TabIndex = 46;
            this.BtnDelete.Text = "刪除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(71, 224);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(51, 20);
            this.BtnCopy.TabIndex = 45;
            this.BtnCopy.Text = "複製";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(14, 224);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(51, 20);
            this.BtnCreate.TabIndex = 44;
            this.BtnCreate.Text = "建立";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(14, 120);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(279, 89);
            this.TxtShow.TabIndex = 43;
            // 
            // TxtDest
            // 
            this.TxtDest.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtDest.Location = new System.Drawing.Point(85, 45);
            this.TxtDest.Name = "TxtDest";
            this.TxtDest.Size = new System.Drawing.Size(208, 23);
            this.TxtDest.TabIndex = 42;
            // 
            // TxtSource
            // 
            this.TxtSource.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtSource.Location = new System.Drawing.Point(85, 10);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(208, 23);
            this.TxtSource.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "目的檔案：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "來源檔案：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 255);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.TxtDest);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "檔案操作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnMove;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.TextBox TxtDest;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

