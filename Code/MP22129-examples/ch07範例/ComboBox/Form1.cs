using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list = new string[] { "奇萊山", "大霸尖山", "玉山", "雪山" };
            CboList.Items.AddRange(list);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {   // 檢查使用者輸入值(CboList.Text)，是否已經存在清單項目中
            bool exist = CboList.Items.Contains(CboList.Text);
            if (exist == false)  // 若不存在才新增項目
                CboList.Items.Add(CboList.Text);//將輸入值新增為新項目
            else
                MessageBox.Show($"{CboList.Text} 在百岳清單中已經存在");
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            CboList.Sorted = true;   //設清單項目自動排序
            CboList.Sorted = false;  //設清單項目不自動排序
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {   //使用RemoveAt方法刪除目前選取的項目
            CboList.Items.RemoveAt(CboList.SelectedIndex);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboList.Items.Clear();  //用Clear方法刪除所有項目
            CboList.Text = "";      //清空文字方塊內容
        }

       
    }
}
