using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqBrowse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Book[] b = new Book[]
        {
            new Book { Id="AEL022131", Name="Python 基礎必修課", Price=450 },
            new Book { Id="AEL022700", Name="Visual C# 程式設計經典", Price=680 },
            new Book { Id="AEI006600", Name="Excel VAB 基礎必修課", Price=500 },
            new Book { Id="AEL020600", Name="C & C++ 程式設計經典", Price=600 },
            new Book { Id="AEL022500", Name="Java 基礎必修課", Price=540 },
            new Book { Id="AEL019900", Name="C 語言基礎必修課", Price=420 }
        };
        int index = 0;
        void ShowData(Book bd)
        {
            LblId.Text = bd.Id;                   //顯示書號
            LblName.Text = bd.Name;               //顯示書名
            LblPrice.Text = bd.Price.ToString();  //顯示定價
            LblIndex.Text = $"{index + 1} / {b.Count()}"; //顯示紀錄位置和總筆數
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = b.FirstOrDefault();    //取得b物件陣列的第一筆物件	
            ShowData(result);			//呼叫ShowData()方法，顯示第一筆物件
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            var result = b.Skip(index).FirstOrDefault();
            ShowData(result);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = b.Count() - 1;
            var result = b.Skip(index).FirstOrDefault();
            ShowData(result);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= b.Count())
                index = 0;
            var result = b.Skip(index).FirstOrDefault();
            ShowData(result);
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            index = b.Count() - 1;
            var result = b.Skip(index).FirstOrDefault();
            ShowData(result);
        }
    }
}
