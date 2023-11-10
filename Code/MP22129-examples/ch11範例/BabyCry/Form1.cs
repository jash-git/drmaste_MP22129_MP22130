using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyCry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool drag = false;  // 記錄是否可拖曳，預設為不允許拖曳
        int sX, sY;         // 記錄滑鼠按下時的座標値
        bool move = false;  // 記錄是否隨滑鼠移動圖片，預設為不可
        private void Form1_Load(object sender, EventArgs e)
        {
            PicBaby.Image = ImgBaby.Images[0];
        }

        private void PicBaby_MouseEnter(object sender, EventArgs e)
        {
            PicBaby.Image = ImgBaby.Images[1];
        }

        private void PicBaby_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;                 // 設為可拖曳
            sX = e.X; sY = e.Y;          // 記錄滑鼠指標的座標値
        }

        private void PicBaby_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)   // 若drag=true
            {
                PicBaby.Left += (e.X - sX); // 設圖片X位置
                PicBaby.Top += (e.Y - sY);  // 設圖片Y位置
            }
        }

        private void PicBaby_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; ;    //設為不可拖曳
        }

        private void PicBaby_MouseLeave(object sender, EventArgs e)
        {
            PicBaby.Image = ImgBaby.Images[0];
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move = true;
                PicBaby.Image = ImgBaby.Images[2];
            }
            else
            {
                move = false;
                PicBaby.Image = ImgBaby.Images[0];
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
                PicBaby.Location = new Point(e.X + 5, e.Y + 5);
        }
    }
}
