using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            double x, sum = 0;
            int count = 0;
            BtnSum.Enabled = false;
            StreamReader sr;
            try
            {
                sr = new StreamReader("in.txt");
            }
            catch
            {
                TxtShow.Text = "檔案開啟失敗";
                return;
            }
            while (true)
            {
                string data = sr.ReadLine();
                if (data == null)
                    break;
                else
                {
                    if (double.TryParse(data, out x) == true)
                    {
                        sum += x;
                        count ++;
                    }
                }
            }
            TxtShow.Text = $"總合：{sum:#.00}  平均：{(sum/count):#.00}";
            sr.Close();
        }
    }
}

