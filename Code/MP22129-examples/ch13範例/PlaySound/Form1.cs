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
//using System;

namespace PlaySound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ans;
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(String Filename, int Mod, int Flags);

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;
            Random ran = new Random();
            x = ran.Next(40, 70);
            y = ran.Next(30, 60);
            LblQ.Text = $"{x} + {y} =";
            ans = x + y;
            LblMsg.Text = $"請輸入{LblQ.Text}？";
        }

        private void TxtAns_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < '0' || c > '9') && c != 8)
            {
                if(c == 13)
                {
                    if (int.Parse(TxtAns.Text) == ans)
                    {
                        LblMsg.Text = "正確答案!";
                        PlaySound(@"c:\Windows\Media\tada.wav", 0, 1);
                    }
                    else
                    {
                        LblMsg.Text = "答案不正確!";
                        PlaySound(@"c:\Windows\Media\chimes.wav", 0, 1);
                    }

                }
                else
                {
                    LblMsg.Text = "請輸入數字鍵!";
                    e.Handled = true;
                    PlaySound(@"c:\Windows\Media\chord.wav", 0, 1);
                }
            }
            else
            {
                LblMsg.Text = "若輸入完成請按Enter鍵!";
            }
        }
    }
}
