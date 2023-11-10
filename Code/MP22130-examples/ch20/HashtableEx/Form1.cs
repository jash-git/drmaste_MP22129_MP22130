using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HashtableEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable HScore;   // 宣告Hashtable類別物件HScore

        public String data(IEnumerable openWith)    //傳出雜湊表的索引鍵和值
        {
            string st = "";
            foreach (DictionaryEntry de in openWith) 
            {
                st += $"Key = {de.Key}     Value = {de.Value} \r\n";
            }
            return st; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HScore = new Hashtable();  //建立Hashtable類別物件HScore
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(TxtName.Text == "" || TxtScore.Text == ""))  //文字方塊有內容 
            {
                try
                {
                    HScore.Add(TxtName.Text, TxtScore.Text);
                    TxtBrows.Text = data(HScore);
                    TxtName.Text = "";
                    TxtScore.Text = "";
                }
                catch
                {
                    MessageBox.Show("資料已存在，不能重複加入！");
                }
            }
        }
              
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (HScore.ContainsKey(TxtDel.Text) == true)
            {
                HScore.Remove(TxtDel.Text);
                LblMsg.Text = $"{TxtDel.Text} 資料已移除 ... ";
            }
            else
            { 
                LblMsg.Text = $"{TxtDel.Text} 資料不存在！... "; 
            }
            TxtBrows.Text = data(HScore);
        }

        private void TxtDel_TextChanged(object sender, EventArgs e)
        {
            LblMsg.Text = "訊息";
        }
    }
}
