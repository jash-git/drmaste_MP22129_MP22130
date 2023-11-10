using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        // 每隔一秒鐘在畫面上顯示目前時間
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        // 要執行計算的副程式
        int Add(int x, int y)
        {
            Thread.Sleep(5000);     // 模擬需要 5 秒鐘才能執行完畢 !
            return x + y;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            int no1 = int.Parse(txtNo1.Text);
            int no2 = int.Parse(txtNo2.Text);
            int answer = Add(no1, no2);
            lstAnswers.Items.Add(answer);
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            int no1 = int.Parse(txtNo1.Text);
            int no2 = int.Parse(txtNo2.Text);
            // TODO: 非同步呼叫
        }
    }
}
