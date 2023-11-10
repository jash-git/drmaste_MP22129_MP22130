using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdFly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TsLblSpeed.Text = "慢速";
            TmrFly.Interval = 500;      //預設計時器的間隔為500
            TsPrgFly.Maximum = 300;     //設進度列的最大值
            TsPrgFly.Value = 0;         //預設進度列的Value值為0
        }

        private void MnuFast_Click(object sender, EventArgs e)
        {
            TmrFly.Interval = 100;      //設計時器的間隔為100
            TsLblSpeed.Text = "快速";
        }

        private void MnuSlow_Click(object sender, EventArgs e)
        {
            TmrFly.Interval = 500;      //設計時器的間隔為500
            TsLblSpeed.Text = "慢速";
        }

        private void TsBtnSpeed_ButtonClick(object sender, EventArgs e)
        {
            PicBird.Left = 0;          //圖片由最左邊開始
            TmrFly.Enabled = true;     //啟動計時器
        }

        private void TmrFly_Tick(object sender, EventArgs e)
        {
            if (PicBird.Left < 300)    //若圖片左邊界小於300
            {
                PicBird.Left += 5;     //圖片左邊界+5
                TsPrgFly.Value = PicBird.Left;  //設進度列的值等於圖片的左邊界
                TsLblMsg.Text = $"進度：{TsPrgFly.Value / 3:#} %";
            }
            else
            {
                TmrFly.Enabled = false;   //關閉計時器
                TsLblMsg.Text = "完成";
            }
        }
    }
}
