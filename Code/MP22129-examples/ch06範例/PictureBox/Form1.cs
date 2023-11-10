﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicShow.Image = Image.FromFile("高跟鞋.jpg");  //載入圖檔
            RdbOn.Checked = true;   //預設動態秀圖開啟
            RdbLeft.Checked = true;  //預設為向左移入
            timer1.Interval = 100;  //計時器每0.1秒觸發一次
        }

        private void RdbOn_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbOn.Checked == true)  //若選取開啟動態秀圖
                timer1.Enabled = true;  //啟動計時器
            else
                timer1.Enabled = false;  //關閉計時器
        }

        private void RdbLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbLeft.Checked == true)  //若選取向左移入
            {
                PicShow.SizeMode = PictureBoxSizeMode.Zoom;  //圖像依控制項比例調整
                PicShow.Size = new Size(264, 180);  //指定控制項的寬和高為 264和 180
                PicShow.Location = new Point(264, 12);  //指定控制項的位置為(264, 12)
            }
            else
            {
                PicShow.SizeMode = PictureBoxSizeMode.StretchImage;//圖像和控制項同大小
                PicShow.Location = new Point(25, 12);  //指定控制項的位置為(25, 12)
                PicShow.Size = new Size(264, 0);  //指定控制項的寬和高為 264和 0
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RdbLeft.Checked == true)  //若選取向左移入
            {
                if (PicShow.Left > -254)  //若左邊界座標大於-254
                    PicShow.Left -= 10;   //左移10點
                else
                    PicShow.Left = 264;   //左邊界移到264
            }
            else
            {
                if (PicShow.Height < 180)  //若高度小於180
                    PicShow.Height += 10;  //高度加10
                else
                    PicShow.Height = 0;    //高度設為0
            }
        }
    }
}
