using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] PicFire = new PictureBox[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            PicTank.Image = Image.FromFile("tank.png");
            for(int i = 0; i < 10; i++)
            {
                PicFire[i] = new PictureBox();
                PicFire[i].Size = new Size(6, 3);
                PicFire[i].BackColor = Color.Red;
                PicFire[i].Visible = false;
                this.Controls.Add(PicFire[i]);
            }
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Up):
                    PicTank.Top -= 5;
                    break;
                case (Keys.Down):
                    PicTank.Top += 5;
                    break;
                case (Keys.Space):
                    for(int i = 0; i < 10; i++)
                    {
                        if(PicFire[i].Visible == false)
                        {
                            PicFire[i].Location = new Point(PicTank.Left + 61, PicTank.Top + 10);
                            PicFire[i].Visible = true;
                            break;
                        }
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                if(PicFire[i].Visible == true)
                {
                    PicFire[i].Left += 8;
                    if (PicFire[i].Left > 300)
                        PicFire[i].Visible = false;
                }
            }
        }
    }
}
