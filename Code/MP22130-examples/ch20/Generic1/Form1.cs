using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            GType<int> testInt = new GType<int>();       // 引用
            label1.Text = testInt.checkType(12345);      // 呼叫

            GType<double> testDouble = new GType<double>();
            label2.Text = testDouble.checkType(123.456);

            GType<string> testString = new GType<string>();
            label3.Text = testString.checkType("Hello!");

            GType<bool> testBool = new GType<bool>();
            label4.Text = testBool.checkType(false);
        }
    }
}
