using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] pic = new PictureBox[9];   //宣告圖片方塊物件陣列
        int hit = 0;    //紀錄擊中次數
        int miss = 0;   //紀錄失誤次數
        int mouse = 0;  //紀錄地鼠的位置
        double sec;     //紀錄剩餘秒數
        private void Form1_Load(object sender, EventArgs e)
        {
            pic[0] = Pic1; pic[1] = Pic2; pic[2] = Pic3;//指定圖片方塊物件陣列元素
            pic[3] = Pic4; pic[4] = Pic5; pic[5] = Pic6;
            pic[6] = Pic7; pic[7] = Pic8; pic[8] = Pic9;
            for (int i = 0; i < 9; i++)
            {
                pic[i].Image = ImgPic.Images[0];    //載入第一個圖
                pic[i].Enabled = false; //不能使用
                pic[i].Tag = i;         //設Tag屬性值為i
                if (i > 0)
                    pic[i].Click += Pic1_Click;     //訂閱共享事件
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            hit = 0; miss = 0;  //預設擊中和失誤次數都為0
            LblHit.Text = $"擊中： {hit} 次";
            LblMiss.Text = $"失誤： {miss} 次";
            for (int i = 0; i < 9; i++)
            {
                pic[i].Image = ImgPic.Images[0];    //載入第一個圖
                pic[i].Enabled = true;              //可以使用
            }
            BtnStart.Enabled = false;   //開始鈕不能使用
            sec = 30;               //設剩餘秒數為30
            TmrT.Enabled = true;    //計時器啟動
            Random rnd = new Random();  //宣告亂數物件rnd
            mouse = rnd.Next(0, 9); //產生0~8亂數為地鼠位置
            pic[mouse].Image = ImgPic.Images[1];//該圖片方塊載入第二個圖
        }

        private void TmrT_Tick(object sender, EventArgs e)
        {
            LblTime.Text = $"{(sec -= 0.1):#.0}秒"; //秒數-0.1並顯示
            if (sec <= 0)   //若剩餘秒數歸零
            {
                TmrT.Enabled = false;       //計時器關閉
                for (int i = 0; i < 9; i++)
                {
                    pic[i].Enabled = false; //圖片方塊不能使用
                }
                BtnStart.Enabled = true;    //開始鈕可以使用
            }
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            PictureBox picClick = (PictureBox)sender;   //將sender轉型為圖片物件picClick
            if ((int)picClick.Tag == mouse)   //若picClick.Tag=地鼠位置
            {
                hit += 1;   //擊中次數加1
                LblHit.Text = $"擊中： {hit} 次";
                picClick.Image = ImgPic.Images[0];//載入第一個圖
                Random rnd = new Random();
                mouse = rnd.Next(0, 9);//產生0~8亂數為地鼠位置
                pic[mouse].Image = ImgPic.Images[1];//該圖片方塊載入第二個圖
            }
            else
            {
                miss += 1;  //失誤次數加1
                LblMiss.Text = $"失誤： {miss} 次";
            }
        }
    }
}
