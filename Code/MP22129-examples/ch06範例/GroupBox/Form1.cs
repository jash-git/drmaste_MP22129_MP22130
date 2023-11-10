using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RdbNB1.Checked = true;
            RdbGift1.Checked = true;
            LblTotal.Text = "歡迎使用!";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int total = 0;
            string gift = "", sel = "";
            if (RdbNB1.Checked == true)
                total = 55000;
            else if (RdbNB2.Checked == true)
                total = 45000;
            else
                total = 30000;
            if (RdbGift1.Checked == true)
                gift = "行動電源";
            else
                gift = "燒錄機";
            if (ChkSelect1.Checked == true)
            {
                total += 1600;
                sel += "行動硬碟 ";
            }
            if (ChkSelect2.Checked == true)
            {
                total += 1200;
                sel += "無線傳輸器 ";
            }
            if (ChkSelect3.Checked == true)
            {
                total += 800;
                sel += "後背包 ";
            }
            sel = sel == "" ? "" : "\n選配： " + sel;  //如非空字串則顯示加點項目
            LblTotal.Text = $"總計： {total} 元 \n好禮：{gift + sel}"; 
        }
    }
}
