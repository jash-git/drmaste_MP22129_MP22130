using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;  // 指定視窗最大化
            WebViewer.Url = new Uri("https://www.google.com.tw");  // 設定瀏覽網址
            MnuMsg.Text = "";
        }

        private void TsTxtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')  // 若輸入Enter鍵時
            {
                if (!String.IsNullOrEmpty(TsTxtUrl.Text))   // 若有輸入網址
                { WebViewer.Navigate(TsTxtUrl.Text); }// 移到指定的網址
            }
        }

        private void WebViewer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            MnuMsg.Text = "網頁下載中....";
        }

        private void WebViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MnuMsg.Text = "網頁下載完成";
        }

        private void MnuBack_Click(object sender, EventArgs e)
        {
            if (WebViewer.GoBack() == false)  // 回上一頁
            { MessageBox.Show("已經到最前面", "注意", MessageBoxButtons.OK); }
        }

        private void MnuForward_Click(object sender, EventArgs e)
        {
            if (WebViewer.GoForward() == false)   // 回下一頁
            { MessageBox.Show("已經到最後面", "注意", MessageBoxButtons.OK); }
        }

        private void MnuRefresh_Click(object sender, EventArgs e)
        {
            WebViewer.Refresh();  // 用Refresh方法重新整理網頁
        }

        private void MnuHome_Click(object sender, EventArgs e)
        {
            WebViewer.GoHome();  // 用GoHome方法回到首頁
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
