using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal ani = new Animal();      // 建立父類別物件
            Person per = new Person();      // 建立子類別物件 
            label1.Text = ani.msg();        // 呼叫父類別的msg()方法
            label2.Text = per.msg();        // 呼叫子類別的msg()方法
            ani = per;                      // 父類別物件參照指向子類別
            label3.Text = ani.msg();        // 現在是呼叫誰的msg()方法呢?
        }
    }
}
