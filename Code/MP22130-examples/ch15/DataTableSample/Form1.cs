using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立記憶體的DataTable物件tableProduct，用來存放產品資料
            DataTable tableProduct = new DataTable();
            //在tableProudct依序建立編號、品名、訂價三個DataColumn資料欄物件
            tableProduct.Columns.Add(new DataColumn("編號"));
            tableProduct.Columns.Add(new DataColumn("品名"));
            tableProduct.Columns.Add(new DataColumn("訂價"));

            //在tableProduct新增第一筆資料記錄DataRow物件
            DataRow row1 = tableProduct.NewRow();
            row1["編號"] = "A01";
            row1["品名"] = "洗衣機";
            row1["訂價"] = "18200";
            tableProduct.Rows.Add(row1);

            //在tableProduct新增第二筆資料記錄DataRow物件
            DataRow row2 = tableProduct.NewRow();
            row2["編號"] = "A02";
            row2["品名"] = "洗碗機";
            row2["訂價"] = "5800";
            tableProduct.Rows.Add(row2);

            //在tableProduct新增第三筆資料記錄DataRow物件
            DataRow row3 = tableProduct.NewRow();
            row3["編號"] = "A03";
            row3["品名"] = "烘乾機";
            row3["訂價"] = "13000";
            tableProduct.Rows.Add(row3);

            string data = "";

            //使用for迴圈讀出tableProudct的欄位名稱
            for (int i = 0; i < tableProduct.Columns.Count; i++)
            {
                data += $"{tableProduct.Columns[i].ColumnName}\t";
            }

            //使用巢狀for迴圈讀出tableProudct的所有記錄
            for (int i = 0; i < tableProduct.Rows.Count; i++)
            {
                data += "\n";
                for (int k = 0; k < tableProduct.Columns.Count; k++)
                {
                    data += $"{tableProduct.Rows[i][k]}\t";
                }
            }
            MessageBox.Show(data, "訂價資訊");
        }
    }
}
