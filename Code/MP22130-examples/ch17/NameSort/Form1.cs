using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] names = { "Jessie", "Dolly", "Woody", "Peep", "Buzz", "Gabby", "Andy"};
        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "";
            foreach(string n in names)
                s += n + Environment.NewLine;
            TxtName.Text = s;
        }
        // 按下 [搜尋] 鈕執行
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = from n in names
                         where n == TxtSearch.Text
                         select n;
            if (result.Count() == 0)
                TxtName.Text = "查無資料";
            else
            {
                string s = $"查到{result.Count()}筆資料" + Environment.NewLine;
                foreach (var n in result)
                    s += n + Environment.NewLine;
                TxtName.Text = s;
            }
        }
        // 按下 [原始順序] 鈕執行
        private void BtnList_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        // 按下 [遞增排序] 鈕執行
        private void BtnAsc_Click(object sender, EventArgs e)
        {
            var result = from n in names
                         orderby n
                         select n;
            string s = "";
            foreach (var n in result)
                s += n + Environment.NewLine;
            TxtName.Text = s;
        }
        // 按下 [遞減排序] 鈕執行
        private void BtnDesc_Click(object sender, EventArgs e)
        {
            var result = from n in names
                         orderby n descending
                         select n;
            string s = "";
            foreach (var n in result)
                s += n + Environment.NewLine;
            TxtName.Text = s;
        }
    }
}
