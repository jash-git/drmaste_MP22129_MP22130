using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            fontDialog1.ShowColor = true;   //可以設定字型顏色
            TxtCom.Text = "○○股份有限公司";
            TxtTitle.Text = "資訊長";
            TxtName.Text = "張三";
            PicLogo.Image = Image.FromFile("logo.png");
        }

        private void MnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.ActiveControl.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ActiveControl.Font = fontDialog1.Font;
                this.ActiveControl.ForeColor = fontDialog1.Color;
            }
        }

        private void MnuSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog(); 
            printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void MnuPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog(); 
        }

        private void MnuPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print(); 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Single x = printDocument1.DefaultPageSettings.Margins.Left; 
            Single y = printDocument1.DefaultPageSettings.Margins.Top;  
            Font f = new Font(TxtCom.Font.Name, TxtCom.Font.Size, TxtCom.Font.Style);
            SolidBrush b = new SolidBrush(TxtCom.ForeColor);
            g.DrawString(TxtCom.Text, f, b, TxtCom.Left + x, TxtCom.Top + y);
            f = new Font(TxtTitle.Font.Name, TxtTitle.Font.Size, TxtTitle.Font.Style);
            b = new SolidBrush(TxtTitle.ForeColor);
            g.DrawString(TxtTitle.Text, f, b, TxtTitle.Left + x, TxtTitle.Top + y);
            f = new Font(TxtName.Font.Name, TxtName.Font.Size, TxtName.Font.Style);
            b = new SolidBrush(TxtName.ForeColor);
            g.DrawString(TxtName.Text, f, b, TxtName.Left + x, TxtName.Top + y); 
            g.DrawImage(PicLogo.Image, PicLogo.Left + x, PicLogo.Top + y, PicLogo.Width, PicLogo.Height);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
