using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] b_name = { "三國演義", "西遊記","唐詩三百首","楚辭",
                "西廂記","水滸傳","紅樓夢", "牡丹亭" };   //書名
        string[] author = {"羅貫中", "吳承恩", "孫洙", "劉向",
                "王實甫","施耐庵", "曹雪芹", "湯顯祖" };  //作者
        string[] kind = { "章回小說", "章回小說", "詩選", "詩歌", "戲曲",
                "章回小說","章回小說", "戲曲" };          //類別

        private void Form1_Load(object sender, EventArgs e)
        {
            LstvBooks.LargeImageList = ImgL;  //設定大圖示的影像來源
            LstvBooks.SmallImageList = ImgS;  //設定小圖示的影像來源
            LstvBooks.Activation = ItemActivation.TwoClick;  //設定按兩下才啟動
            CboView.Items.Add("大圖示");
            CboView.Items.Add("詳細資料");
            CboView.Items.Add("小圖示");
            CboView.Items.Add("清單");
            CboView.Items.Add("大圖示加詳細資料");  //新增CboView的項目
            CboView.SelectedIndex = 0;  //預設選取第一個項目
            LstvBooks.Columns.Add("書名", 100);   //新增 書名 欄位，寬度為100
            LstvBooks.Columns.Add("作者", 60);  //新增 作者 欄位，寬度為60
            LstvBooks.Columns.Add("類別", 60);  //新增 類別 欄位
            LstvBooks.BeginUpdate();    //暫停重繪
            for (int i = 0; i < b_name.Length; i++)
            {    //宣告一個ListViewItem物件
                ListViewItem lvi = new ListViewItem(b_name[i]);
                lvi.SubItems.Add(author[i].ToString());  //新增 作者 欄位資料
                lvi.SubItems.Add(kind[i]);  //新增 類別 欄位資料
                LstvBooks.Items.Add(lvi);  //新增項目
                LstvBooks.Items[i].ImageIndex = i;  //指定影像的索引值
            }
            LstvBooks.EndUpdate();  //重繪;
        }

        private void CboView_SelectedIndexChanged(object sender, EventArgs e)
        {   //根據CboView的SelectedIndex屬性值，設定檢視方式
            switch (CboView.SelectedIndex)
            {
                case 0:   //大圖示
                    LstvBooks.View = View.LargeIcon;
                    break;
                case 1:   //詳細資料
                    LstvBooks.View = View.Details;
                    break;
                case 2:    //小圖示
                    LstvBooks.View = View.SmallIcon;
                    break;
                case 3:    //清單
                    LstvBooks.View = View.List;
                    break;
                case 4:   //大圖示加詳細資料
                    LstvBooks.View = View.Tile;
                    break;
            }

        }

        private void LstvBooks_ItemActivate(object sender, EventArgs e)
        {
            bool exist = LstBorrow.Items.Contains(b_name[LstvBooks.SelectedIndices[0]]);
            if (exist != true)   // 若選取的書名不存在借書清單中
            {
                DialogResult dr = MessageBox.Show("確定要借閱嗎?",
                    b_name[LstvBooks.SelectedIndices[0]], MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)  // 若按 <是> 鈕
                {  // 新增項目到借書清單
                    LstBorrow.Items.Add(b_name[LstvBooks.SelectedIndices[0]]);
                }
            }
        }
    }
}
