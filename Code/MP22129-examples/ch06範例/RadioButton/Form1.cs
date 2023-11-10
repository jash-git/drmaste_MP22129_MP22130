using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RdbUSD_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbUSD.Checked == true)  //如果是被選取
            {
                double usd, twd;    //宣告double變數存放美金和台幣金額
                try
                {
                    twd = double.Parse(TxtInput.Text);    //轉換使用者輸入的台幣金額
                }
                catch
                {
                    LblOutput.Text = "請輸入金額數值！";  //顯示提示訊息
                    return;
                }
                usd = Math.Round(twd / 28.32, 2);    //轉換成美元並四捨五入到小數二位
                LblOutput.Text = $"美金 {usd} 元";   //顯示美元金額
            }
        }

        private void RdbJPY_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbJPY.Checked == true)  //如果是被選取
            {
                double jpy, twd;    //宣告double變數存放日幣和台幣金額
                try
                {
                    twd = double.Parse(TxtInput.Text);    //轉換使用者輸入的台幣金額
                }
                catch
                {
                    LblOutput.Text = "請輸入金額數值！";  //顯示提示訊息
                    return;
                }
                jpy = Math.Round(twd / 0.2679, 2);    //轉換成日幣並四捨五入到小數二位
                LblOutput.Text = $"日幣 {jpy} 元";    //顯示日幣金額
            }
        }
    }
}
