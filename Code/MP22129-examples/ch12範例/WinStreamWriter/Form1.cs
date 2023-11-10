using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinStreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] product;    // 宣告陣列
        int k;               // 宣告陣列索引變數 
        // -------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPad.Text = "";
            TxtShow.Text = "";
            LblMsg.Text = "目前沒資料";
        }
        // ----------- 按 <清除> 鈕 -----------------------------------------------------------
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPad.Text = "";
            LblMsg.Text = "資料保留";
        }
        // --------- 按 <新增> 鈕 ----------------------------------
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string filename = @"c:\my\file.txt";   // 指定存入的文字檔檔名
            FileInfo finfo = new FileInfo(filename);
            if (!Directory.Exists(finfo.DirectoryName))  // 檢查路徑和檔名是否存在
                Directory.CreateDirectory(finfo.DirectoryName); // 不存在則建立
            StreamWriter sw = finfo.CreateText();
            sw.WriteLine(TxtPad.Text);
            sw.Flush();
            sw.Close();

            product = new string[999];             // 建立陣列
            k = 0;                                 // 陣列索引變數 
            foreach (string item in TxtPad.Lines)  // 將輸入資料置入陣列
            {
                product[k] = item;
                k++;
            }
            TxtShow.Lines = product;             // 將陣列資料顯示在txtShow控制項上
            LblMsg.Text = " 資料已新增 ! ...";
            TxtPad.Text = "";
        }
        // ------ 按 <加入> 鈕 -------------------------------------------------------------------------
        private void BtnAppend_Click(object sender, EventArgs e)
        {
            string filename = @"c:\my\file.txt";   // 指定存入的文字檔檔名
            FileInfo finfo = new FileInfo(filename);
            StreamWriter sw = finfo.AppendText();
            sw.WriteLine(TxtPad.Text);
            sw.Flush();
            sw.Close();
            LblMsg.Text = " 資料已加入 ! ...";
            foreach (string item in TxtPad.Lines)  // 將輸入資料置入陣列
            {
                product[k] = item;
                k++;
            }
            TxtShow.Lines = product;     // 將陣列資料顯示在txtShow控制項上
            TxtPad.Text = "";
        }
        // ---------- 按 <結束> 鈕 ------------------------------------------------------
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();   // 結束程式執行
        }
    }
}
