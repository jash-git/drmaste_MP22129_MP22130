using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int R, G, B;    //分存放 紅、綠、藍 三原色的色階

        private void Form1_Load(object sender, EventArgs e)
        {
            TkbRed.Maximum = 255;
            TkbGreen.Maximum = 255;
            TkbBlue.Maximum = 255;
            R = TkbRed.Value;
            G = TkbGreen.Value;
            B = TkbBlue.Value;
            PicColor.BackColor = Color.FromArgb(R, G, B); //設定圖片方塊背景色
        }

        private void TkbRed_Scroll(object sender, EventArgs e)
        {
            R = TkbRed.Value;
            PicColor.BackColor = Color.FromArgb(R, G, B);
        }

        private void TkbGreen_Scroll(object sender, EventArgs e)
        {
            G = TkbGreen.Value;
            PicColor.BackColor = Color.FromArgb(R, G, B);
        }
        
        private void TkbBlue_Scroll(object sender, EventArgs e)
        {
            B = TkbBlue.Value;
            PicColor.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
