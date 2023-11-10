namespace Timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbSet2 = new System.Windows.Forms.RadioButton();
            this.RdbSet1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbDate = new System.Windows.Forms.RadioButton();
            this.RdbTime = new System.Windows.Forms.RadioButton();
            this.LblTime = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbSet2);
            this.groupBox2.Controls.Add(this.RdbSet1);
            this.groupBox2.Location = new System.Drawing.Point(138, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 74);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "設定";
            // 
            // RdbSet2
            // 
            this.RdbSet2.AutoSize = true;
            this.RdbSet2.Location = new System.Drawing.Point(17, 48);
            this.RdbSet2.Name = "RdbSet2";
            this.RdbSet2.Size = new System.Drawing.Size(59, 16);
            this.RdbSet2.TabIndex = 1;
            this.RdbSet2.TabStop = true;
            this.RdbSet2.Text = "每五秒";
            this.RdbSet2.UseVisualStyleBackColor = true;
            // 
            // RdbSet1
            // 
            this.RdbSet1.AutoSize = true;
            this.RdbSet1.Location = new System.Drawing.Point(17, 21);
            this.RdbSet1.Name = "RdbSet1";
            this.RdbSet1.Size = new System.Drawing.Size(59, 16);
            this.RdbSet1.TabIndex = 0;
            this.RdbSet1.TabStop = true;
            this.RdbSet1.Text = "每一秒";
            this.RdbSet1.UseVisualStyleBackColor = true;
            this.RdbSet1.CheckedChanged += new System.EventHandler(this.RdbSet1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbDate);
            this.groupBox1.Controls.Add(this.RdbTime);
            this.groupBox1.Location = new System.Drawing.Point(25, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "類型";
            // 
            // RdbDate
            // 
            this.RdbDate.AutoSize = true;
            this.RdbDate.Location = new System.Drawing.Point(12, 47);
            this.RdbDate.Name = "RdbDate";
            this.RdbDate.Size = new System.Drawing.Size(47, 16);
            this.RdbDate.TabIndex = 1;
            this.RdbDate.TabStop = true;
            this.RdbDate.Text = "日期";
            this.RdbDate.UseVisualStyleBackColor = true;
            // 
            // RdbTime
            // 
            this.RdbTime.AutoSize = true;
            this.RdbTime.Location = new System.Drawing.Point(12, 22);
            this.RdbTime.Name = "RdbTime";
            this.RdbTime.Size = new System.Drawing.Size(47, 16);
            this.RdbTime.TabIndex = 0;
            this.RdbTime.TabStop = true;
            this.RdbTime.Text = "時間";
            this.RdbTime.UseVisualStyleBackColor = true;
            this.RdbTime.CheckedChanged += new System.EventHandler(this.RdbTime_CheckedChanged);
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("新細明體", 18F);
            this.LblTime.Location = new System.Drawing.Point(12, 18);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(234, 42);
            this.LblTime.TabIndex = 3;
            this.LblTime.Text = "label1";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 166);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbSet2;
        private System.Windows.Forms.RadioButton RdbSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbDate;
        private System.Windows.Forms.RadioButton RdbTime;
        private System.Windows.Forms.Label LblTime;
    }
}

