using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;  // 匯入System.Collections命名空間

namespace StackEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack SName;     //宣告Stack集合類別SName堆疊物件

        public String data(IEnumerable myList)    //傳回堆疊內的元素
        {
            string st = "";
            foreach (Object obj in myList)
                st += $"{obj} \r\n";
            return st;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SName = new Stack();  // 建立Stack類別物件SName堆疊
            string[] aryName = { "David", "Tom", "Jack", "Mary", "Bob" };
            for (int i = 0; i < aryName.Length; i++)
            {
                SName.Push(aryName[i]);   //由堆疊頂端加入一元素 
            }
            TxtName.Text = data(SName);
            LblMsg.Text = $"原始資料,元素共計：{SName.Count}";
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SName.Pop();       //由SName堆疊頂端移除一個元素
            TxtName.Text = data(SName);
            LblMsg.Text = $"移除一筆,元素共計：{SName.Count}";
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            LblMsg.Text = $"第一個資料：{SName.Peek()}"; //讀取最前面資料
        }

        private void BtnCln_Click(object sender, EventArgs e)
        {
            SName.Clear();     //清除Sname堆疊中所有元素
            TxtName.Text = data(SName);
            LblMsg.Text = "移除所有資料";
            BtnDel.Enabled = false;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(TxtAdd.Text == ""))   //如果文字方塊內有內容
            {
                SName.Push(TxtAdd.Text);    //由堆疊頂端加入一元素
                TxtName.Text = data(SName);
                LblMsg.Text = $"新增資料,元素共計：{SName.Count}";
                TxtAdd.Text = "";
                BtnDel.Enabled = true;
            }
        }
    }
}
