using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            PicBrid.Image = ImgBird.Images[n];
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TmrFly.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TmrFly.Enabled = false;
        }

        private void TmrFly_Tick(object sender, EventArgs e)
        {
            n = n == 5 ? 0 : n + 1;
            PicBrid.Image = ImgBird.Images[n];
            PicBrid.Left += 10;
            if (PicBrid.Left >= 300)
                PicBrid.Left = -50;
        }
    }
}
