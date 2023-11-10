using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GList<string> mystr = new GList<string>();  //建立處理字串型別的物件
            mystr.SaveToAry("Tom");            //物件mystr加入字串資料
            mystr.SaveToAry("Mary");
            mystr.SaveToAry("John");
            mystr.SaveToAry("Kevin");
            mystr.SaveToAry("Helen");
            TxtString.Text = mystr.data();     //顯示物件mystr內的所有資料

            GList<double> mydouble = new GList<double>(); //建立可處理數值的物件
            mydouble.SaveToAry(67.4);          //物件mydouble加入數值資料
            mydouble.SaveToAry(-89);
            mydouble.SaveToAry(0.0006);
            mydouble.SaveToAry(3.1416);
            mydouble.SaveToAry(-93000);
            TxtDouble.Text = mydouble.data();  //顯示物件mydouble內的所有資料
        }
    }
}
