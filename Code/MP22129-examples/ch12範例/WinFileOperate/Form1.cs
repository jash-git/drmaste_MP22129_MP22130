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

namespace WinFileOperate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //設定第一個操作畫面
            TxtSource.Text = @"c:\my\test1.txt";  //來源檔案文字方塊預設值
            TxtSource.Focus();                    //來源檔案文字方塊取得駐點
            TxtShow.ReadOnly = true;     //訊息文字方塊唯讀
            TxtDest.Enabled = false;     //目的檔案文字方塊失效
            TxtDir.Enabled = false;      //資料夾名稱文字方塊失效
            TxtShow.Text = "請輸入「來源檔案」完整名稱後，按 [建立] 鈕。";
            BtnCopy.Enabled = false;     //複製按鈕失效
            BtnMove.Enabled = false;     //搬移按鈕失效
            BtnCheck.Enabled = false;    //查看按鈕失效
            BtnDelete.Enabled = false;   //刪除按鈕失效
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string filename = TxtSource.Text;
            FileInfo fInfo = new FileInfo(filename);
            string path = fInfo.DirectoryName;
            if (!Directory.Exists(path))           //若指定的來源檔案資料夾不存在
                Directory.CreateDirectory(path);   //則建立該資料夾
            if (fInfo.Exists)                      //若來源檔案存在，顯示訊息
                TxtShow.Text = $"{fInfo.Name} 檔案已存在！";
            else                                   //若來源檔案不存在，建立檔案
            {
                FileStream fs = fInfo.Create();    //建立檔案串流物件fs，開啟檔案                 
                TxtShow.Text = $"{fInfo.FullName} 檔案建立成功！";
                fs.Close();                        //關閉檔案
            }
            //設定第二個操作畫面
            BtnCreate.Enabled = false;　　　　　//建立按鈕失效
            BtnCopy.Enabled = true;             //複製按鈕有效
            TxtDest.Enabled = true;             //目的檔案文字方塊有效
            TxtDest.Text = @"c:\my\copy.doc";    //目的檔案文字方塊預設值
            TxtDest.Focus();　　　　            //目的檔案文字方塊取得駐點
            TxtSource.Enabled = false;          //來源檔案文字方塊失效
            TxtShow.Text += "\r\n\r\n\r\n";
            TxtShow.Text += "再來\r\n";
            TxtShow.Text += "輸入「目的檔案」完整名稱後，按 [複製] 鈕。";
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            FileInfo SourceInfo = new FileInfo(TxtSource.Text);
            FileInfo DestInfo = new FileInfo(TxtDest.Text);
            string path = DestInfo.DirectoryName;
            if (!Directory.Exists(path))               //若指定的目的檔案資料夾不存在
                Directory.CreateDirectory(path);       //則建立該資料夾
            SourceInfo.CopyTo(TxtDest.Text, true);     //將來源檔案拷貝到目的檔案
            TxtShow.Text = $"{SourceInfo.FullName} 檔案成功複製給\r\n";
            TxtShow.Text += DestInfo.FullName;
            //設定第三個操作畫面
            BtnCopy.Enabled = false;             //複製按鈕失效
            BtnCheck.Enabled = true;             //查看按鈕有效
            TxtDest.Enabled = false;             //目的檔案文字方塊失效
            TxtDir.Enabled = true;               //資料夾名稱文字方塊有效
            TxtDir.Text = @"c:\my\";               //資料夾名稱文字方塊預設值
            TxtDir.Focus();                      //資料夾名稱文字方塊駐點
            TxtShow.Text += "\r\n\r\n\r\n";
            TxtShow.Text += "接著\r\n";
            TxtShow.Text += "輸入來源檔案的「資料夾名稱」後，按 [查看] 鈕";
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FileInfo DestInfo = new FileInfo(TxtDir.Text);
            string path = DestInfo.DirectoryName;
            int no = 0;
            if (Directory.Exists(path))     //若path指定的資料夾存在時
            {
                string[] listName = new string[] { };
                listName = Directory.GetFiles(path);  //取得path指定資料夾內所有檔案名稱
                TxtShow.Text = $"該資料夾有{listName.Length}個檔案, 表列如下 \r\n";
                foreach (string fname in listName)
                {
                    no++;
                    TxtShow.Text += $"{no}.   {fname}\r\n";
                }
            }
            else
                TxtShow.Text = "無此資料夾！";

            //設定第四個操作畫面
            BtnCheck.Enabled = false;            //複製按鈕失效
            BtnDelete.Enabled = true;            //刪除按鈕有效
            TxtDir.Enabled = false;              //資料夾名稱文字方塊失效
            TxtShow.Text += "\r\n";
            TxtShow.Text += "接著\r\n";
            TxtShow.Text += "按 [刪除] 鈕，刪除「目的檔案」指定的檔案。";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FileInfo DestInfo = new FileInfo(TxtDest.Text);
            DestInfo.Delete();                //刪除檔案 
            TxtShow.Text = $"{DestInfo.FullName} 檔案成功刪除。";
            TxtDest.Text = "";
            //設定第五個操作畫面
            BtnDelete.Enabled = false;        //刪除按鈕有效
            BtnMove.Enabled = true;           //搬移按鈕失效
            TxtDest.Enabled = true;           //目的檔案文字方塊有效
            TxtDest.Focus();
            TxtShow.Text += "\r\n\r\n\r\n";
            TxtShow.Text += "最後\r\n";
            TxtShow.Text += "輸入「目的檔案」完整名稱後，按 [搬移] 鈕";
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            FileInfo SourceInfo = new FileInfo(TxtSource.Text);
            FileInfo DestInfo = new FileInfo(TxtDest.Text);
            string path = DestInfo.DirectoryName;
            if (!Directory.Exists(path))           //若指定的目的檔案資料夾不存在
                Directory.CreateDirectory(path);   //則建立該資料夾
            if (DestInfo.Exists)                   //若目的檔案存在
                DestInfo.Delete();                 //則刪除該檔案           
            TxtShow.Text =  $"{SourceInfo.FullName} 檔案成功搬移到\r\n";
            TxtShow.Text += DestInfo.FullName;
            SourceInfo.MoveTo(TxtDest.Text);       //將來源檔案搬移到目的檔案
            // 設定第六個操作畫面
            TxtSource.Text = "";                   //來源檔案文字方塊設成空白
            TxtDest.Enabled = false;               //目的檔案文字方塊失效
            BtnMove.Enabled = false;               //搬移按鈕失效
            TxtShow.Text += "\r\n\r\n\r\n";
            TxtShow.Text += "請關閉程式視窗。";
        }
    }
}
