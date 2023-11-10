using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBtnDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TstxtInput.Text = "Hello, World!";
            fontDialog1.ShowColor = true; 
            fontDialog1.MinSize = 12;     
            fontDialog1.MaxSize = 36;     
            colorDialog1.FullOpen = true; 
        }

        private void TstxtInput_TextChanged(object sender, EventArgs e)
        {
            BtnDesign.Text = TstxtInput.Text;
        }

        private void MnuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {   
                BtnDesign.Font = fontDialog1.Font;
                BtnDesign.ForeColor = fontDialog1.Color;
            }
        }

        private void MnuColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {   
                BtnDesign.BackColor = colorDialog1.Color;
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
