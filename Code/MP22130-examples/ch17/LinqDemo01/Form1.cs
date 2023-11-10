using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqDemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Jasper", "Marco", "Chih-Hsin" };
            var result1 = from name in names
                          where name == "Marco"
                          select name;
            string msg1 = "";
            foreach (var r in result1)
            {
                msg1 += (r + "\n");
            }
            MessageBox.Show(msg1, "簡例1");

            int[] scores = new int[] { 100, 6, 90, 88, 44 };
            var result2 = from s in scores
                          where s >= 60
                          orderby s descending
                          select s;
            string msg2 = "";
            foreach (var r in result2)
            {
                msg2 += (r + "\n");
            }
            MessageBox.Show(msg2, "簡例2");
            Application.Exit();
        }
    }
}
