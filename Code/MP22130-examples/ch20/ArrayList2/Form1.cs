using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;      // 匯入System.Collections命名空間

namespace ArrayList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList person;

        public String data(IEnumerable myList)   //傳回串列元素
        {
            string st = "";
            foreach (Object obj in myList)
                st += $"{obj}\r\n";
            return st;
        }

        public void clean()      //清理輸入框及資料顯示訊息
        {
            TxtName.Text = "";
            LblMsg.Text = "訊息";
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //建立person串列內容
            person = new ArrayList {"Fred", "David", "Tom", "Jack", "Mary"};
        }

        private void BtnPer_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            TxtPer.Text = data(person);
            clean();
        }
        private void BtnSort_Click(object sender, EventArgs e)
        {
            person.Sort();    //排序整個person物件中的項目
            TxtPer.Text = data(person);
            clean();
        }

        private void BtnRev_Click(object sender, EventArgs e)
        {
            person.Sort();    //排序整個person物件中的項目
            person.Reverse(); //反向排列整個person物件中的項目
            TxtPer.Text = data(person);
            clean();
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            if (person.Contains(name))
                LblMsg.Text = $"{name} 的索引值：{person.IndexOf(name)}";
            else
                LblMsg.Text = $"{name} 不在名單內";
        }
    }
}
