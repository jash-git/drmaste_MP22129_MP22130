using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] range;

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbl0.Text = "";
            Lbl1.Text = "";
            Lbl2.Text = "";
            Lbl3.Text = "";
            Lbl4.Text = "";
            Lbl5.Text = "";
            BtnSort.Enabled = false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int min = 1, max = 49, rndNum = 6;
            range = new int[rndNum];
            MakeRnd Rnd = new MakeRnd();
            Rnd.GetRnd(range, min, max, rndNum);
            Lbl0.Text = range[0].ToString();
            Lbl1.Text = range[1].ToString();
            Lbl2.Text = range[2].ToString();
            Lbl3.Text = range[3].ToString();
            Lbl4.Text = range[4].ToString();
            Lbl5.Text = range[5].ToString();
            BtnSort.Enabled = true;
            BtnSort.Enabled = true;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(range);
            Lbl0.Text = range[0].ToString();
            Lbl1.Text = range[1].ToString();
            Lbl2.Text = range[2].ToString();
            Lbl3.Text = range[3].ToString();
            Lbl4.Text = range[4].ToString();
            Lbl5.Text = range[5].ToString();
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
