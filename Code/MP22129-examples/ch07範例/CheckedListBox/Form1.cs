using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int div;    //存放因數
        private void Form1_Load(object sender, EventArgs e)
        {
            
            BtnCheck.Enabled = BtnClear.Enabled = false;
            LblMsg.Text = "請出題...";
            ClstTest.MultiColumn = true;
            ClstTest.ColumnWidth = 50;
            ClstTest.CheckOnClick = true;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Random rndNum = new Random();
            div = rndNum.Next(1, 6);    //隨機出現1~5的因數
            LblDiv.Text = $"請勾選 {div} 的倍數：";
            ClstTest.Items.Clear();
            //隨機產生18個 1~99 的整數
            for (int x = 0; x <= 17; x++)
                ClstTest.Items.Add(rndNum.Next(1, 100));
            LblMsg.Text = "請作答...";
            BtnNew.Enabled = false;
            BtnCheck.Enabled = BtnClear.Enabled = true;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int right = 0;  //預設答對0題
            int num;        //存放題目
            for (int x = 0; x <= 17; x++)
            {
                num = int.Parse(ClstTest.Items[x].ToString());
                if (ClstTest.GetItemChecked(x) == true && num % div == 0)
                    right++;
            }
            LblMsg.Text = $"勾選正確：{right} 個";
            BtnNew.Enabled = BtnClear.Enabled = true;
            BtnCheck.Enabled = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < ClstTest.Items.Count; x++)
                ClstTest.SetItemChecked(x, false);
            LblMsg.Text = "請重新作答";
            BtnNew.Enabled = false;
            BtnCheck.Enabled = BtnClear.Enabled = true;
        }
    }
}
