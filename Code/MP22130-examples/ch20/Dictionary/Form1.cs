using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 建立Dictionary物件openWith，其索引鍵與值的型別皆為字串
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");   // 加入資料到物件openWith中
            openWith.Add("bmp", "paint.exe");     // Key不能重複
            openWith.Add("rtf", "wordpad.exe");
            openWith.Add("dib", "paint.exe");    // Value可以重複
            if (!openWith.ContainsKey("doc"))     // 若索引鍵不包含指"doc"
                openWith["doc"] = "winword.exe";  // 加入配對資料
            
            LblTitle.Text = "Dictionary 泛型物件Key與Value組配對資料：";
            foreach (KeyValuePair<string, string> kvp in openWith)
                TxtDic.Text += $"Key = {kvp.Key} ,    Value = {kvp.Value} \r\n";
        }
    }
}
