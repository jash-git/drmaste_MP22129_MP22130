
namespace BeepPlay
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(14, 13);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(36, 48);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Do";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(53, 13);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(36, 48);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Re";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(131, 12);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(36, 48);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "Fa";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(92, 12);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(36, 48);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "Mi";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.ForeColor = System.Drawing.Color.Red;
            this.Btn8.Location = new System.Drawing.Point(287, 12);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(36, 48);
            this.Btn8.TabIndex = 8;
            this.Btn8.Text = "Do";
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(248, 12);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(36, 48);
            this.Btn7.TabIndex = 7;
            this.Btn7.Text = "Ti";
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(209, 13);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(36, 48);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "La";
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(170, 13);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(36, 48);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "Si";
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 70);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
    }
}

