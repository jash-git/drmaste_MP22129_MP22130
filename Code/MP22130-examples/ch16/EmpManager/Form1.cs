using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmpManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] depId;
        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                "Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnStr;
            SqlDataAdapter daDep = new SqlDataAdapter("SELECT * FROM 部門", cn);
            DataSet ds = new DataSet();
            daDep.Fill(ds, "部門");

            depId = new int[ds.Tables["部門"].Rows.Count];

            for (int i = 0; i < ds.Tables["部門"].Rows.Count; i++)
            {
                depId[i] = int.Parse(ds.Tables["部門"].Rows[i]["部門編號"].ToString());
                CboDep.Items.Add(ds.Tables["部門"].Rows[i]["部門名稱"].ToString());
            }
            CboDep.Text = (ds.Tables["部門"].Rows[0]["部門名稱"].ToString());
        }

        private void CboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnStr;
            SqlDataAdapter daEmp = new SqlDataAdapter
                ("SELECT 員工編號,姓名,職稱 FROM 員工 WHERE 部門編號=" + depId[CboDep.SelectedIndex].ToString(), cn);
            daEmp.Fill(ds, "員工");
            dataGridView1.DataSource = ds.Tables["員工"];
        }
        void Edit(string sqlstr)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = cnStr;
            cn.Open();
            SqlCommand cmd = new SqlCommand(sqlstr, cn);
            cmd.ExecuteNonQuery();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string empId, empName, empP;
                empId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                empName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                empP = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Edit("INSERT INTO 員工(員工編號,姓名,職稱,部門編號)VALUES(" + 
                    $"'{empId}',N'{empName}',N'{empP}'," + 
                    $"{depId[CboDep.SelectedIndex]})") ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string empId;
                empId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Edit($"DELETE FROM 員工 WHERE 員工編號='{empId}'");
                CboDep_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string empId, empName, empP;
                empId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                empName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                empP = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Edit("UPDATE 員工 SET 姓名=" +
                    $"N'{empName}', 職稱=N'{empP}' WHERE 員工編號='{empId}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
