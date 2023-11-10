using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int sec;       //記錄倒數的秒數

        private void Form1_Load(object sender, EventArgs e)
        {
            NudMin.Minimum = 0; NudMin.Maximum = 10;  //設定分鐘的範圍
            NudMin.Value = 0;         //預設分鐘為0
            NudSec.Minimum = 0; NudSec.Maximum = 60;  //設定秒數的範圍
            NudSec.Value = 30;        //預設秒數為30
            LblSec.Text = "";
            timer1.Interval = 1000;   //每秒觸發一次
        }

        private void btnStart_Click(object sender, EventArgs e)
        {   //計算倒數秒數
            sec = (int)NudMin.Value * 60 + (int)NudSec.Value;
            BtnStart.Enabled = false;      //開始鈕不能使用
            LblSec.Text = sec.ToString();  //顯示剩餘秒數
            timer1.Start();                //啟動計時器
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            sec--;                //減一秒
            LblSec.Text = sec.ToString();    //顯示剩餘秒數
            if (sec == 0)         //若剩餘0秒
            {
                timer1.Stop();    //關閉計時器
                LblSec.Text = "時間到";
                BtnStart.Enabled = true;    //開始鈕可以使用
            }
        }
    }
}
