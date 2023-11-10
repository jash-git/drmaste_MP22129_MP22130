using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RdbTime.Checked = true; //預設顯示時間
            RdbSet1.Checked = true; //預設第一個設定項目
            timer1.Enabled = true;  //啟動計時器
        }

        private void RdbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbTime.Checked == true)   //若選取時間類型
            {
                RdbSet1.Text = "每一秒";   //第一個設定項目文字改變
                RdbSet1.Checked = true;    //預設選第一個項目
                RdbSet2.Text = "每五秒";   //第二個設定項目文字改變
            }
            else
            {
                RdbSet1.Text = "日期";   //第一個設定項目文字改變
                RdbSet2.Text = "星期";   //第二個設定項目文字改變
                timer1.Interval = 1000;  //每1秒觸動Tick事件
            }
        }

        private void RdbSet1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSet1.Checked == true)
            {
                if (RdbTime.Checked == true) timer1.Interval = 1000;  //每1秒觸動Tick事件
            }
            else
            {
                if (RdbTime.Checked == true) timer1.Interval = 5000;   //每5秒觸動Tick事件
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RdbTime.Checked == true)   //若選取時間類型
                LblTime.Text = DateTime.Now.ToLongTimeString();  //顯示目前時間
            else
            {
                if (RdbSet1.Checked == true)    //若選取日期設定
                    LblTime.Text = DateTime.Today.ToLongDateString();  //顯示今天日期
                else       //若選取星期設定
                    LblTime.Text = DateTime.Today.DayOfWeek.ToString();  //顯示今天的星期
            }
        }
    }
}
