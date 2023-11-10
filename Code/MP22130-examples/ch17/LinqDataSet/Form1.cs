using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LinqDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtProduct;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();  //建立SqlConnection物件cn
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
              "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
              "Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter
                ("SELECT 產品編號,產品,單價,庫存量 FROM 產品資料", cn);
            DataSet ds = new DataSet(); //建立DataSet物件ds
            da.Fill(ds);    //將da物件所取得的資料填入ds物件
            dtProduct = ds.Tables[0];
            DgvShow.DataSource = dtProduct;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new
                         {
                             產品編號 = r.Field<int>("產品編號"),
                             產品 = r.Field<string>("產品"),
                             單價 = r.Field<decimal>("單價"),
                             庫存量 = r.Field<short>("庫存量")
                         };
            DgvShow.DataSource = result.Where(r => r.產品.Contains(TxtSearch.Text)).ToList();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new
                         {
                             單價 = r.Field<decimal>("單價")
                         };
            string str = $"資料筆數：{result.Count()}\n"+
                         $"最高單價：{result.Max(r => r.單價)}\n"+
                         $"最低單價：{result.Min(r => r.單價)}\n"+
                         $"平均單價：{(int)result.Average(r => r.單價)}\n"+
                         $"單價總和：{result.Sum(r => r.單價)}";
            MessageBox.Show(str,"產品資訊");
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new
                         {
                             產品編號 = r.Field<int>("產品編號"),
                             產品 = r.Field<string>("產品"),
                             單價 = r.Field<decimal>("單價"),
                             庫存量 = r.Field<short>("庫存量")
                         };
            DgvShow.DataSource = result.OrderBy(r => r.單價).ToList();
        }

        private void BtnAmount_Click(object sender, EventArgs e)
        {
            var result = from r in dtProduct.AsEnumerable()
                         select new
                         {
                             產品編號 = r.Field<int>("產品編號"),
                             產品 = r.Field<string>("產品"),
                             單價 = r.Field<decimal>("單價"),
                             庫存量 = r.Field<short>("庫存量")
                         };
            DgvShow.DataSource = result.OrderByDescending(r => r.庫存量).ToList();
        }

    }
}
