using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace NavigatorProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingManagerBase bm;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();
            SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM 產品資料", cn);
            daProduct.Fill(ds, "產品資料");

            TxtId.DataBindings.Add("Text", ds, "產品資料.產品編號");
            TxtName.DataBindings.Add("Text", ds, "產品資料.產品");
            TxtPrice.DataBindings.Add("Text", ds, "產品資料.單價");
            TxtQty.DataBindings.Add("Text", ds, "產品資料.庫存量");
            bm = this.BindingContext[ds, "產品資料"];
            CheckButton();
        }

        private void CheckButton()
        {
            if (bm.Position == 0)
            {
                BtnFirst.Enabled = false;
                BtnPrev.Enabled = false;
                BtnNext.Enabled = true;
                BtnLast.Enabled = true;
            }
            else if (bm.Position == bm.Count - 1)
            {
                BtnFirst.Enabled = true;
                BtnPrev.Enabled = true;
                BtnNext.Enabled = false;
                BtnLast.Enabled = false;
            }
            else
            {
                BtnFirst.Enabled = true;
                BtnPrev.Enabled = true;
                BtnNext.Enabled = true;
                BtnLast.Enabled = true;
            }
            LblCount.Text = $"{bm.Position + 1} / {bm.Count}";
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            CheckButton();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (bm.Position > 0)
            {
                bm.Position -= 1;
            }
            CheckButton();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (bm.Position < bm.Count - 1)
            {
                bm.Position += 1;
            }
            CheckButton();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
            CheckButton();
        }
    }
}
