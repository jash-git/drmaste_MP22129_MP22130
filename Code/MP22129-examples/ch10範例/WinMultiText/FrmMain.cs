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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        int num = 0;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            BtnAdd.Enabled = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmPass fP = new FrmPass();
            fP.ShowDialog();
            BtnAdd.Enabled = true;
            BtnLogin.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            num++;
            FrmText fT = new FrmText();
            fT.Text = $"文件{num}";
            fT.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
