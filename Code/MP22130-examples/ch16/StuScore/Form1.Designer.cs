namespace StuScore
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtChi = new System.Windows.Forms.TextBox();
            this.TxtEng = new System.Windows.Forms.TextBox();
            this.TxtMath = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnScore = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.HScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.BtnCls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "學號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "國文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "英文";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "數學";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(79, 25);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 25);
            this.TxtId.TabIndex = 0;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(79, 68);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 25);
            this.TxtName.TabIndex = 1;
            // 
            // TxtChi
            // 
            this.TxtChi.Location = new System.Drawing.Point(79, 111);
            this.TxtChi.Name = "TxtChi";
            this.TxtChi.Size = new System.Drawing.Size(100, 25);
            this.TxtChi.TabIndex = 2;
            // 
            // TxtEng
            // 
            this.TxtEng.Location = new System.Drawing.Point(79, 154);
            this.TxtEng.Name = "TxtEng";
            this.TxtEng.Size = new System.Drawing.Size(100, 25);
            this.TxtEng.TabIndex = 3;
            // 
            // TxtMath
            // 
            this.TxtMath.Location = new System.Drawing.Point(79, 197);
            this.TxtMath.Name = "TxtMath";
            this.TxtMath.Size = new System.Drawing.Size(100, 25);
            this.TxtMath.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnAdd.Location = new System.Drawing.Point(202, 70);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "新增";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnUpdate.Location = new System.Drawing.Point(202, 113);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnDel.Location = new System.Drawing.Point(202, 156);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "刪除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnScore
            // 
            this.BtnScore.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnScore.Location = new System.Drawing.Point(202, 199);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(75, 23);
            this.BtnScore.TabIndex = 9;
            this.BtnScore.Text = "成績排名";
            this.BtnScore.UseVisualStyleBackColor = true;
            this.BtnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(27, 247);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(37, 15);
            this.LblCount.TabIndex = 3;
            this.LblCount.Text = "記錄";
            // 
            // HScrollBar1
            // 
            this.HScrollBar1.LargeChange = 1;
            this.HScrollBar1.Location = new System.Drawing.Point(109, 247);
            this.HScrollBar1.Name = "HScrollBar1";
            this.HScrollBar1.Size = new System.Drawing.Size(168, 17);
            this.HScrollBar1.TabIndex = 4;
            this.HScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // BtnCls
            // 
            this.BtnCls.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCls.Location = new System.Drawing.Point(202, 27);
            this.BtnCls.Name = "BtnCls";
            this.BtnCls.Size = new System.Drawing.Size(75, 23);
            this.BtnCls.TabIndex = 5;
            this.BtnCls.Text = "清除";
            this.BtnCls.UseVisualStyleBackColor = true;
            this.BtnCls.Click += new System.EventHandler(this.BtnCls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 291);
            this.Controls.Add(this.HScrollBar1);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCls);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtMath);
            this.Controls.Add(this.TxtEng);
            this.Controls.Add(this.TxtChi);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "個人成績管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtChi;
        private System.Windows.Forms.TextBox TxtEng;
        private System.Windows.Forms.TextBox TxtMath;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnScore;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.HScrollBar HScrollBar1;
        private System.Windows.Forms.Button BtnCls;
    }
}

