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
    public partial class FrmText : Form
    {
        public FrmText()
        {
            InitializeComponent();
        }

        private void FrmText_Load(object sender, EventArgs e)
        {
            TxtInput.Multiline = true;
            TxtInput.Dock = DockStyle.Fill;
            TxtInput.ScrollBars = ScrollBars.Both;
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            if (TxtInput.SelectedText != "")
                TxtInput.Copy();
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            TxtInput.Paste();
        }

        private void MnuCut_Click(object sender, EventArgs e)
        {
            if (TxtInput.SelectedText != "")
                TxtInput.Cut();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
