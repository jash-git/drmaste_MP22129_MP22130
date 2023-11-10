using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPicBrowse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png";
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrmPic FPic = new FrmPic();     
                    FPic.MdiParent = this;          
                    FPic.Text = openFileDialog1.FileName;
                    FPic.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                    FPic.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請選取適當格式的圖檔", "注意");
                }
            }
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form ActForm = this.ActiveMdiChild;
                ActForm.BackgroundImage.Save(saveFileDialog1.FileName);
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
