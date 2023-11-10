using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPW.MaxLength = 12;       //設最多輸入12個字元
            TxtPW.PasswordChar = '*';   //設密碼輸入時顯示的字元
            TxtMoney.Enabled = false;   //金額不能輸入
            LblMsg.Text = "請輸入晶片密碼(6~12位)後按下 Enter 鍵";
        }

        private void TxtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')   //若小於0或大於9
            {
                if (e.KeyChar == (char)Keys.Enter)      //若是Enter鍵
                {
                    if (TxtPW.Text == "123456") //若密碼正確
                    {
                        LblMsg.Text = "請輸入提款金額後按下 Enter 鍵";
                        TxtPW.Enabled = false;  //密碼不能輸入
                        TxtMoney.Enabled = true;//金額可以輸入
                        TxtMoney.Focus();       //金額文字方塊取得焦點
                    }
                    else
                    {
                        LblMsg.Text = "密碼錯誤！請再試一次";
                        TxtPW.SelectAll();  //選取所有字元
                    }
                }
                else if (e.KeyChar != (char)Keys.Back)	//若不是退位鍵
                {
                    LblMsg.Text = "請按數字鍵";
                    e.Handled = true;       //不接收字元
                }
            }
        }

        private void TxtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (key < 48 || key > 57)   //若小於0或大於9
            {
                if (key == 13)      //若是Enter鍵
                {
                    LblMsg.Text = $"您的提款金額為 {TxtMoney.Text} 元";
                    TxtMoney.Enabled = false;
                }
                else if (key != 8)  //若不是退位鍵
                {
                    LblMsg.Text = "請按數字鍵";
                    e.Handled = true;   	//不接收字元
                }
            }
        }
    }
}
