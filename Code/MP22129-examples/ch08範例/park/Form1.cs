﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace park
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DtpTime.Format = DateTimePickerFormat.Custom;
            DtpTime.CustomFormat = "MM/dd  hh:mm";
            DtpTime.ShowUpDown = true;
            DtpTime.MaxDate = DateTime.Now;
            LblMsg.Text = "請輸入入場時間後按計算鈕";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TimeSpan t_span = DateTime.Now - DtpTime.Value;
            double t_min = t_span.TotalMinutes;  //起訖時間的總分鐘數
            double hours = t_span.TotalHours;    //起訖時間的總小時數
            int mins = t_span.Minutes; //分鐘數
            int total = 0;       //設停車費為0元
            if (t_min > 15)
            {
                total = (int)hours * 40;  //每小時40元
                if (mins >= 15 && mins < 30) //15~30分收費20元
                    total += 20;
                else if (mins >= 30)  //31~59分收費40元
                    total += 40;
            }
            LblMsg.Text = $"共停 {(int)hours}小時{mins}分, 停車費 {total} 元";
            DtpTime.MaxDate = DateTime.Now;
        }
    }
}
