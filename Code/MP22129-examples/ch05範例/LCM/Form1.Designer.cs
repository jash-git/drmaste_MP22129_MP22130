namespace LCM
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblLCM = new System.Windows.Forms.Label();
            this.BtnLCM = new System.Windows.Forms.Button();
            this.TxtN2 = new System.Windows.Forms.TextBox();
            this.TxtN1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnExit.Location = new System.Drawing.Point(189, 136);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(79, 30);
            this.BtnExit.TabIndex = 23;
            this.BtnExit.Text = "離開";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnReset.Location = new System.Drawing.Point(104, 136);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(79, 30);
            this.BtnReset.TabIndex = 22;
            this.BtnReset.Text = "重來";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblLCM
            // 
            this.LblLCM.BackColor = System.Drawing.Color.Aqua;
            this.LblLCM.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblLCM.Location = new System.Drawing.Point(16, 89);
            this.LblLCM.Name = "LblLCM";
            this.LblLCM.Size = new System.Drawing.Size(254, 30);
            this.LblLCM.TabIndex = 21;
            this.LblLCM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLCM
            // 
            this.BtnLCM.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnLCM.Location = new System.Drawing.Point(19, 136);
            this.BtnLCM.Name = "BtnLCM";
            this.BtnLCM.Size = new System.Drawing.Size(79, 30);
            this.BtnLCM.TabIndex = 20;
            this.BtnLCM.Text = "LCM";
            this.BtnLCM.UseVisualStyleBackColor = true;
            this.BtnLCM.Click += new System.EventHandler(this.BtnLCM_Click);
            // 
            // TxtN2
            // 
            this.TxtN2.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtN2.Location = new System.Drawing.Point(219, 54);
            this.TxtN2.Name = "TxtN2";
            this.TxtN2.Size = new System.Drawing.Size(51, 25);
            this.TxtN2.TabIndex = 19;
            // 
            // TxtN1
            // 
            this.TxtN1.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtN1.Location = new System.Drawing.Point(219, 20);
            this.TxtN1.Name = "TxtN1";
            this.TxtN1.Size = new System.Drawing.Size(51, 25);
            this.TxtN1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "輸入第二個介於1~100的整數 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "輸入第一個介於1~100的整數 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 176);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblLCM);
            this.Controls.Add(this.BtnLCM);
            this.Controls.Add(this.TxtN2);
            this.Controls.Add(this.TxtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "最大公因數";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LblLCM;
        private System.Windows.Forms.Button BtnLCM;
        private System.Windows.Forms.TextBox TxtN2;
        private System.Windows.Forms.TextBox TxtN1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

