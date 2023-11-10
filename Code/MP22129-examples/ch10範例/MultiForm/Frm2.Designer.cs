
namespace MultiForm
{
    partial class frm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.Rdb1 = new System.Windows.Forms.RadioButton();
            this.Rdb3 = new System.Windows.Forms.RadioButton();
            this.Rdb4 = new System.Windows.Forms.RadioButton();
            this.Rdb2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "學歷：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "專長：";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(197, 125);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "完成";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(22, 92);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(250, 22);
            this.TxtInput.TabIndex = 4;
            // 
            // Rdb1
            // 
            this.Rdb1.AutoSize = true;
            this.Rdb1.Location = new System.Drawing.Point(18, 37);
            this.Rdb1.Name = "Rdb1";
            this.Rdb1.Size = new System.Drawing.Size(47, 16);
            this.Rdb1.TabIndex = 5;
            this.Rdb1.TabStop = true;
            this.Rdb1.Text = "高中";
            this.Rdb1.UseVisualStyleBackColor = true;
            // 
            // Rdb3
            // 
            this.Rdb3.AutoSize = true;
            this.Rdb3.Location = new System.Drawing.Point(156, 37);
            this.Rdb3.Name = "Rdb3";
            this.Rdb3.Size = new System.Drawing.Size(47, 16);
            this.Rdb3.TabIndex = 6;
            this.Rdb3.TabStop = true;
            this.Rdb3.Text = "專科";
            this.Rdb3.UseVisualStyleBackColor = true;
            // 
            // Rdb4
            // 
            this.Rdb4.AutoSize = true;
            this.Rdb4.Location = new System.Drawing.Point(225, 37);
            this.Rdb4.Name = "Rdb4";
            this.Rdb4.Size = new System.Drawing.Size(47, 16);
            this.Rdb4.TabIndex = 7;
            this.Rdb4.TabStop = true;
            this.Rdb4.Text = "大學";
            this.Rdb4.UseVisualStyleBackColor = true;
            // 
            // Rdb2
            // 
            this.Rdb2.AutoSize = true;
            this.Rdb2.Location = new System.Drawing.Point(87, 37);
            this.Rdb2.Name = "Rdb2";
            this.Rdb2.Size = new System.Drawing.Size(47, 16);
            this.Rdb2.TabIndex = 8;
            this.Rdb2.TabStop = true;
            this.Rdb2.Text = "高職";
            this.Rdb2.UseVisualStyleBackColor = true;
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.Rdb2);
            this.Controls.Add(this.Rdb4);
            this.Controls.Add(this.Rdb3);
            this.Controls.Add(this.Rdb1);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm2";
            this.Text = "個人專長";
            this.Load += new System.EventHandler(this.frm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.RadioButton Rdb1;
        private System.Windows.Forms.RadioButton Rdb3;
        private System.Windows.Forms.RadioButton Rdb4;
        private System.Windows.Forms.RadioButton Rdb2;
    }
}