using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domainUpDn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num1, num2, ans;     //題目1、題目2、答案

        private void Form1_Load(object sender, EventArgs e)
        {
            LblTest.Text = "";
            LblMsg.Text = "選擇運算元和位數後按出題鈕開始測驗！";
            BtnCheck.Enabled = false;    //對答按鈕不能使用
            DudOpt.Items.Add("加法"); 
            DudOpt.Items.Add("減法");
            DudOpt.SelectedIndex = 0;    //預設為第一個項目-加法
            DudNum.Items.Add("個位數"); 
            DudNum.Items.Add("二位數"); 
            DudNum.Items.Add("三位數");
            DudNum.SelectedIndex = 0;    //預設為第一個項目-個位數
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Random ran = new Random();  //物件亂數ran
            switch (DudNum.SelectedIndex)
            {
                case 0:   //選個位數時，產生1~9亂數
                    num1 = ran.Next(1, 9); 
                    num2 = ran.Next(1, 9);
                    break;
                case 1:   //選二位數時，產生10~99亂數
                    num1 = ran.Next(10, 99); 
                    num2 = ran.Next(10, 99);
                    break;
                case 2:   //選三位數時，產生100~999亂數
                    num1 = ran.Next(100, 999); 
                    num2 = ran.Next(100, 999);
                    break;
            }
            if (DudOpt.SelectedIndex == 0)  //若選第一個項目-加法
            {
                LblTest.Text = $"{num1} + {num2} =";  //顯示題目
                ans = num1 + num2;   //計算答案
            }
            else
            {
                LblTest.Text = $"{num1} - {num2} = ";
                ans = num1 - num2;
            }
            BtnTest.Enabled = false; 
            BtnCheck.Enabled = true;
            TxtAns.Clear();     //文字方塊清空
            LblMsg.Text = "請輸入答案！";
        }
        
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int s_ans;          //使用者輸入的答案
            try
            {
                s_ans = int.Parse(TxtAns.Text);   //取得使用者輸入的答案
            }  
            catch
            { 
                LblMsg.Text = "請輸入數值！"; 
                return; 
            }
            if (s_ans == ans)   //若答案正確
                LblMsg.Text = "太棒了！答案正確！"; 
            else
                LblMsg.Text = $"答錯了！答案是： {ans}"; 
            BtnTest.Enabled = true; 
            BtnCheck.Enabled = false;
        }

    }
}
