using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqDemo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "張三", "李四", "王五", "張無忌" };
            var result = from n in names
                         where n.Substring(0,1) == "張"
                         select n;
            //強制立即執行，將第1個字元等於 張 的個數指定給n
            int i = result.Count();
            label1.Text = "第1個字元等於J的個數= " + i.ToString();
            //強制立即執行，將第1個字元等於 張 的資料顯示在listBox1	
            listBox1.DataSource = result.ToList();
        }
    }
}
