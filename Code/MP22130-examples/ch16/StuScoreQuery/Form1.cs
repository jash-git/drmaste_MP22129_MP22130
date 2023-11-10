using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StuScoreQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtSqlCmd1.Text = "SELECT 學號,姓名,國文,英文,數學,(國文+英文+數學) AS 總分 FROM 成績 WHERE (國文+英文+數學)>250";
            TxtSqlCmd2.Text = "SELECT TOP 3 學號,姓名,國文,英文,數學,(國文+英文+數學) AS 總分 FROM 成績 ORDER BY 總分 DESC";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                               "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                                "Integrated Security=True";
                DataSet ds = new DataSet();
                SqlDataAdapter daScore = new SqlDataAdapter(toolStripTextBox1.Text, cn);
                daScore.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCopy1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = TxtSqlCmd1.Text;
        }

        private void BtnCopy2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = TxtSqlCmd2.Text;
        }

    }
}
