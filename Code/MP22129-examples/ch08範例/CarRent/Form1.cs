using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            McaDate.MinDate = DateTime.Today;   	// 設可選擇最小日期為今天
            McaDate.MaxSelectionCount = 7;      	// 設最多可以選擇7天
            McaDate.SelectionStart = DateTime.Today; 	// 預設選擇日期為今天
        }

        private void McaDate_DateChanged(object sender, DateRangeEventArgs e)
        {   //根據選擇起始日期的月份來設定背景色
            double m = McaDate.SelectionStart.Month;   //使用Month屬性來取得所在的月份
            switch (Math.Floor((m - 1) / 3))    //使用Floor方法取得小於(m-1)/3的最大整數
            {
                case 0:   //1~3月背景設為淺綠色
                    this.BackColor = Color.LightGreen;
                    break;
                case 1:   //4~6月背景設為淺藍色
                    this.BackColor = Color.LightBlue;
                    break;
                case 2:   //7~9月背景設為橘色
                    this.BackColor = Color.Orange;
                    break;
                case 3:    //10~12月背景設為白色
                    this.BackColor = Color.White;
                    break;
            }

        }

        private void McaDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime d_start = McaDate.SelectionStart;  // d_start記錄選擇的起始日期
            DateTime d_end = McaDate.SelectionEnd;      // d_end記錄選擇的結束日期
            TimeSpan ts = d_end - d_start;  // ts為間隔時間
            int days = ts.Days + 1;         // 將間隔時間轉成天數
            int rest;            //紀錄租金
            switch (days)        //根據天數來設定租金
            {
                case 1:          //1天設定租金為2500元
                    rest = 2500;
                    break;
                case 2:          //2~3天設定租金為2300元
                case 3:
                    rest = 2300;
                    break;
                default:         //其餘天數設定租金為2000元
                    rest = 2000;
                    break;
            }
            LblMoney.Text = $"{days} 天的租金為 {days * rest} 元";
        }
    }
}
