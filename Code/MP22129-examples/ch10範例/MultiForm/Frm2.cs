﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            Rdb1.Checked = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtInput.Text))
            {
                MessageBox.Show("請輸入專長");
            }
            else
            {
                string sT;
                if (Rdb1.Checked)
                    sT = Rdb1.Text;
                else if(Rdb2.Checked)
                    sT = Rdb2.Text;
                else if (Rdb3.Checked)
                    sT = Rdb3.Text;
                else
                    sT = Rdb4.Text;
                PubClass.sMsg += PubClass.NewLine("學歷：" + sT);
                PubClass.sMsg += PubClass.NewLine("專長：" + TxtInput.Text);
                Close();
                FrmMain f = new FrmMain();
                f.Show();
            }
        }
    }
}
