using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicPicture.Left = 5; PicPicture.Top = 0;//預設圖片的位置
            TsCboPic.SelectedIndex = 0;     //預設選取下拉式清單第一個項目
            LblMsg.Text = TsTxtMsg.Text;    //設LblMsg顯示TsTxtMsg的文字內容
            LblMsg.Parent = PicPicture;     //設LblMsg為PicPicture的子物件
            LblMsg.BackColor = Color.Transparent;   //設為透明背景色
        }

        private void TsBtnStart_Click(object sender, EventArgs e)
        {
            TmrMove.Enabled = true;      //開啟計時器
        }

        private void TsBtnStop_Click(object sender, EventArgs e)
        {
            TmrMove.Enabled = false;//關閉計時器
        }

        private void TmrMove_Tick(object sender, EventArgs e)
        {
            PicPicture.Left -= 5;//向左
            if (PicPicture.Left <= -375)//若圖片全部移出就重新開始
                PicPicture.Left = 375;
        }

        private void TsCboPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TsCboPic.SelectedIndex)
            {   //根據清單得選項來指定圖片為專案資源檔內不同的圖檔
                case 0:
                    PicPicture.Image = Properties.Resources._1; break;
                case 1:
                    PicPicture.Image = Properties.Resources._2; break;
                case 2:
                    PicPicture.Image = Properties.Resources._3; break;
                case 3:
                    PicPicture.Image = Properties.Resources._4; break;
                case 4:
                    PicPicture.Image = Properties.Resources._5; break;
                case 5:
                    PicPicture.Image = Properties.Resources._6; break;
            }
        }

        private void TsTxtMsg_TextChanged(object sender, EventArgs e)
        {
            LblMsg.Text = TsTxtMsg.Text;  // 設LblMsg顯示TsTxtMsg的文字內容
        }
    }
}
