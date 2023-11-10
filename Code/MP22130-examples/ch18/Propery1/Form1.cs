using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propery1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class PadClass
        {
            private int price;    // 欄位
            public int Price     // 屬性
            {
                get { return price; }
                set { price = value; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PadClass bsus = new PadClass();
            bsus.Price = 25900;       // 將25900傳給set存取子的value
            label1.Text = $"BSUS 平板電腦單價 : {bsus.Price} ";
        }
    }
}
