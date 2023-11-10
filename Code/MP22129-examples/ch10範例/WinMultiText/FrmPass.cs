using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMultiText
{
    public partial class FrmPass : Form
    {
        public FrmPass()
        {
            InitializeComponent();
        }
        int num = 0;
        private void BtnOK_Click(object sender, EventArgs e)
        {
            num++;
            if(TxtID.Text== "happy" && TxtPW.Text== "168")
            {
                this.Close();
            }
            else
            {
                if(num < 3)
                {
                    DialogResult result = MessageBox.Show("再試一次", "密碼錯誤", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        TxtID.Text = TxtPW.Text = "";
                        TxtID.Focus();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("連續三次密碼錯誤", "結束程式", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
    }
}
