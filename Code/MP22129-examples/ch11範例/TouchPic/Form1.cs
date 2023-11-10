using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TouchPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int SM_DIGITIZER = 94;
        [DllImport("User32.dll")]
        public static extern int GetSystemMetrics(int n);
        private void Form1_Load(object sender, EventArgs e)
        {
            int digitizerStatus = GetSystemMetrics(SM_DIGITIZER);
            if ((digitizerStatus & (0x80 + 0x40)) != 0)
                MessageBox.Show("支援多點觸控");
            else
                MessageBox.Show("不支援多點觸控");
            PicT1.SizeMode = PictureBoxSizeMode.StretchImage;
            picT2.SizeMode = PictureBoxSizeMode.StretchImage;
            picT3.SizeMode = PictureBoxSizeMode.StretchImage;
            PicT1.Image = Image.FromFile("pic1.png");
            picT2.Image = Image.FromFile("pic2.png");
            picT3.Image = Image.FromFile("pic3.png");
            picT2.Click += PicT1_Click;
            picT3.Click += PicT1_Click;
            picT2.DoubleClick += PicT1_DoubleClick;
            picT3.DoubleClick += PicT1_DoubleClick;
            picT2.MouseClick += PicT1_MouseClick;
            picT3.MouseClick += PicT1_MouseClick;
            this.MouseWheel += new MouseEventHandler(PicZoom);
            //Lamda語法
            //this.MouseWheel += (object m_sender, MouseEventArgs m_e) =>
            //{
            //    if (m_e.Delta > 0)
            //    { this.Controls[0].Width += 8; this.Controls[0].Height += 6; }
            //    else
            //    { this.Controls[0].Width -= 8; this.Controls[0].Height -= 6; }
            //};
        }

        private void PicZoom(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            { this.Controls[0].Width += 8; this.Controls[0].Height += 6; }
            else
            { this.Controls[0].Width -= 8; this.Controls[0].Height -= 6; }
        }

        private void PicT1_Click(object sender, EventArgs e)
        {
            PictureBox picClick = (PictureBox)sender;
            this.Controls.SetChildIndex(picClick, 0);
            //picClick.BringToFront();
        }

        private void PicT1_DoubleClick(object sender, EventArgs e)
        {
            PictureBox picDClick = (PictureBox)sender;
            picDClick.Size = new Size(160, 120);
        }

        private void PicT1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox picMClick = (PictureBox)sender;
            if (e.Button == MouseButtons.Right)
                this.Controls.SetChildIndex(picMClick, this.Controls.Count - 1);
                //picMClick.SendToBack();
        }
    }
}
