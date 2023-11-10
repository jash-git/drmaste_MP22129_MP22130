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


namespace WinBinaryWR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = @"c:\my\data.bin";

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo finfo = new FileInfo(filename);
            string path = finfo.DirectoryName;
            if (!Directory.Exists(path))           // 若指定的來源檔案資料夾不存在
                Directory.CreateDirectory(path);   // 則建立該資料夾
            BtnRead.Enabled = false;               // 讀取檔案按鈕失效

        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(@"c:\data.bin", FileMode.OpenOrCreate);
            BinaryWriter bwa = new BinaryWriter(new FileStream(@"c:\my\data.bin", FileMode.OpenOrCreate));

            FileStream fsOut = new FileStream(filename, FileMode.Create);  // 建立檔案串流
            BinaryWriter bw = new BinaryWriter(fsOut);
            bw.Write(TxtPad.Text);
            bw.Flush();                         // 清除緩衝區
            bw.Close();                         // 關閉資料串流
            fsOut.Close();                      // 關閉檔案串流
            BtnRead.Enabled = true;             // 讀取檔案按鈕有效
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            TxtPad.Text = "";
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            FileStream fsIn = new FileStream(filename, FileMode.Open); // 開啟檔案輸入串流
            BinaryReader br = new BinaryReader(fsIn);
            TxtPad.Text = br.ReadString();
            br.Close();
            fsIn.Close();
        }
    }
}
