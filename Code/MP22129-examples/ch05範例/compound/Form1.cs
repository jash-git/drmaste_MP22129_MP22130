using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            double money = double.Parse(TxtCapi.Text);   //本金
            double years = double.Parse(TxtYear.Text);   //年期
            double yrate = double.Parse(TxtRate.Text);   //年利率
            double total;     //本利和
            total = money * Math.Pow((1 + yrate / 100), years);
            label4.Text = $"本利和 = NT$ {total : #,#.0} 元";
            label4.Text += $"\n總利息 = NT$ {(total - money) : #,#.0} 元";
        }
    }
}
