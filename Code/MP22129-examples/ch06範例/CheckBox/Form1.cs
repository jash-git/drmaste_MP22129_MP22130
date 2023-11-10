﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "請先勾選產品，然後輸入數量，最後按<結帳>鈕";
        }

        private void Chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk1.Checked == true)  //如果有勾選
            { TxtQty1.Text = "1"; }    //設數量為1
            else
            { TxtQty1.Clear(); }       //數量清成空白
        }

        private void Chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk2.Checked == true)  //如果有勾選
            { TxtQty2.Text = "1"; }    //設數量為1
            else
            { TxtQty2.Clear(); }       //數量清成空白
        }

        private void Chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk3.Checked == true)  //如果有勾選
            { TxtQty3.Text = "1"; }    //設數量為1
            else
            { TxtQty3.Clear(); }       //數量清成空白
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int qty1 = 0, qty2 = 0, qty3 = 0, total = 0;  //預設三個商品的購買數量為0
            bool chk = false;           //預設chk = false，若有勾選商品就改設為true
            if (Chk1.Checked == true)   //若有勾選Chk1
            {
                try
                { qty1 = int.Parse(TxtQty1.Text); }  //將TxtQty1.Text轉成整數
                catch
                { LblMsg.Text = "請輸入正整數！"; return; }  //顯示錯誤提示訊息
                if (qty1 <= 0)  //若輸入的數量<= 0
                { LblMsg.Text = "數量不能小於等於零！"; return; }
                else
                {
                    total += qty1 * 50;  //總價加上(數量 x 50)
                    chk = true;          //設chk = true表有勾選商品
                }
            }
            
            if (Chk2.Checked == true)   //若有勾選Chk2
            {
                try
                { qty2 = int.Parse(TxtQty2.Text); }  //將TxtQty2.Text轉成整數
                catch
                { LblMsg.Text = "請輸入正整數！"; return; }  //顯示錯誤提示訊息
                if (qty2 <= 0)  //若輸入的數量<= 0
                { LblMsg.Text = "數量不能小於等於零！"; return; }  //顯示錯誤提示訊息
                else
                {
                    total += qty2 * 80;  //總價加上數量 x 80
                    chk = true;          //設chk = true表有勾選商品
                }
            }
           
            if (Chk3.Checked == true)   //若有勾選Chk3
            {
                try
                { qty3 = int.Parse(TxtQty3.Text); }  //將TxtQty3.Text轉成整數
                catch
                { LblMsg.Text = "請輸入正整數！"; return; }  //顯示錯誤提示訊息
                if (qty3 <= 0)  //若輸入的數量<= 0
                { LblMsg.Text = "數量不能小於等於零！"; return; }  //顯示錯誤提示訊息
                else
                {
                    total += qty3 * 60;  //總價加上數量 x 60
                    chk = true;  //設chk = true表有勾選商品
                }
            }

            if (chk == true)    //若有勾選商品
                LblMsg.Text = $"{qty1 + qty2 + qty3} 件產品總價等於 {total} 元";
            else
                LblMsg.Text = "請勾選產品並輸入數量後，再按<結帳>鈕";
        }
    }
}
