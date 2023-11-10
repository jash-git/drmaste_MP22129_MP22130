using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> mystr = new List<string>();   // 建立處理字串型別的物件
            mystr.Add("Tom");                    // 物件mystr加入字串資料
            mystr.Add("Mary");
            mystr.Add("John");
            mystr.Add("Kevin");
            mystr.Add("Helen");
            foreach (string mydata in mystr)         // 顯示物件mystr內的所有資料
                TxtString.Text += $"{mydata}  \r\n";
            // -----------------------------------------------------------------------
            List<double> mydouble = new List<double>();  // 建立可處理數值的物件
            mydouble.Add(67.4);                   // 物件mydouble加入數值資料
            mydouble.Add(-89);
            mydouble.Add(0.0006);
            mydouble.Add(3.1416);
            mydouble.Add(-93000);
            foreach (double mydata in mydouble)  // 顯示物件mydouble內的所有資料
                TxtDouble.Text += $"{mydata}  \r\n";
        }
    }
}
