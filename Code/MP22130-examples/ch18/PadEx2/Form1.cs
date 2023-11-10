using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadEx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        class PadClass   // 定義PadClass類別
        {
            public int price;
            public void setPrice(int tPrice)	// 公用方法成員(設定單價)
            {  price = tPrice;  }
            public int getPrice()     	    	// 公用方法成員(取得單價)
            {  return price;  }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PadClass bsus = new PadClass();
            bsus.setPrice(25900);        // 呼叫設定單價方法成員
            label1.Text = $"BSUS 平板電腦單價 : {bsus.getPrice()}"; 
                                          // 呼叫讀取得單價方法成員
        }
    }
}
