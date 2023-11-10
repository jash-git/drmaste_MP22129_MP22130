using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;  // 引用DllImport命名空間

namespace BeepPlay
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        private void Btn1_Click(object sender, EventArgs e)
        {
            int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };
            Button btn = (Button)sender;
            btn.Enabled = false;
            Beep(freq[btn.TabIndex - 1], 300);
            btn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn2.Click += Btn1_Click;
            Btn3.Click += Btn1_Click;
            Btn4.Click += Btn1_Click;
            Btn5.Click += Btn1_Click;
            Btn6.Click += Btn1_Click;
            Btn7.Click += Btn1_Click;
            Btn8.Click += Btn1_Click;
        }
    }
}
