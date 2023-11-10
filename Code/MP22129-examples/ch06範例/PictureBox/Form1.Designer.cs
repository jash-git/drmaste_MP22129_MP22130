namespace PictureBox
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbDown = new System.Windows.Forms.RadioButton();
            this.RdbLeft = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbOff = new System.Windows.Forms.RadioButton();
            this.RdbOn = new System.Windows.Forms.RadioButton();
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbDown);
            this.groupBox2.Controls.Add(this.RdbLeft);
            this.groupBox2.Location = new System.Drawing.Point(120, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "設定";
            // 
            // RdbDown
            // 
            this.RdbDown.AutoSize = true;
            this.RdbDown.Location = new System.Drawing.Point(80, 29);
            this.RdbDown.Name = "RdbDown";
            this.RdbDown.Size = new System.Drawing.Size(71, 16);
            this.RdbDown.TabIndex = 1;
            this.RdbDown.TabStop = true;
            this.RdbDown.Text = "向下拉出";
            this.RdbDown.UseVisualStyleBackColor = true;
            // 
            // RdbLeft
            // 
            this.RdbLeft.AutoSize = true;
            this.RdbLeft.Location = new System.Drawing.Point(9, 29);
            this.RdbLeft.Name = "RdbLeft";
            this.RdbLeft.Size = new System.Drawing.Size(71, 16);
            this.RdbLeft.TabIndex = 0;
            this.RdbLeft.TabStop = true;
            this.RdbLeft.Text = "向左移入";
            this.RdbLeft.UseVisualStyleBackColor = true;
            this.RdbLeft.CheckedChanged += new System.EventHandler(this.RdbLeft_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbOff);
            this.groupBox1.Controls.Add(this.RdbOn);
            this.groupBox1.Location = new System.Drawing.Point(11, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "動態秀圖";
            // 
            // RdbOff
            // 
            this.RdbOff.AutoSize = true;
            this.RdbOff.Location = new System.Drawing.Point(59, 29);
            this.RdbOff.Name = "RdbOff";
            this.RdbOff.Size = new System.Drawing.Size(35, 16);
            this.RdbOff.TabIndex = 1;
            this.RdbOff.TabStop = true;
            this.RdbOff.Text = "關";
            this.RdbOff.UseVisualStyleBackColor = true;
            // 
            // RdbOn
            // 
            this.RdbOn.AutoSize = true;
            this.RdbOn.Location = new System.Drawing.Point(12, 29);
            this.RdbOn.Name = "RdbOn";
            this.RdbOn.Size = new System.Drawing.Size(35, 16);
            this.RdbOn.TabIndex = 0;
            this.RdbOn.TabStop = true;
            this.RdbOn.Text = "開";
            this.RdbOn.UseVisualStyleBackColor = true;
            this.RdbOn.CheckedChanged += new System.EventHandler(this.RdbOn_CheckedChanged);
            // 
            // PicShow
            // 
            this.PicShow.Location = new System.Drawing.Point(12, 22);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(263, 180);
            this.PicShow.TabIndex = 3;
            this.PicShow.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 290);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbDown;
        private System.Windows.Forms.RadioButton RdbLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbOff;
        private System.Windows.Forms.RadioButton RdbOn;
        private System.Windows.Forms.PictureBox PicShow;
        private System.Windows.Forms.Timer timer1;
    }
}

