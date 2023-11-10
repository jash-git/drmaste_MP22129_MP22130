using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSystemSounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "請輸入額溫(可含小數)";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                double tmp = double.Parse(TxtInput.Text);
                if (tmp < 35)
                {
                    System.Media.SystemSounds.Question.Play();
                    LblMsg.Text = "額溫過低請重新測量！";
                }
                else if (tmp > 37)
                {
                    System.Media.SystemSounds.Beep.Play();
                    LblMsg.Text = "額溫過高！不能進入！";
                }
                else
                {
                    LblMsg.Text = "額溫正常！歡迎參觀！";
                }
            }
            catch (Exception)
            {
                System.Media.SystemSounds.Asterisk.Play();
                LblMsg.Text = "輸入的資料不正確！";
            }
        }
    }
}
