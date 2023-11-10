using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StuScore
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
                "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                "Integrated Security=True";
            DataSet ds = new DataSet();

            SqlDataAdapter daScore = new SqlDataAdapter("SELECT * FROM 成績", cn);
            daScore.Fill(ds, "成績");

            TxtId.DataBindings.Add("Text", ds, "成績.學號");
            TxtName.DataBindings.Add("Text", ds, "成績.姓名");
            TxtChi.DataBindings.Add("Text", ds, "成績.國文");
            TxtEng.DataBindings.Add("Text", ds, "成績.英文");
            TxtMath.DataBindings.Add("Text", ds, "成績.數學");
            bm = this.BindingContext[ds, "成績"];
            HScrollBar1.SmallChange = 1;
            HScrollBar1.LargeChange = 1;
            HScrollBar1.Minimum = 0;
            HScrollBar1.Maximum = bm.Count-1 ;
            HScrollBar1.Value = 0;
            LblCount.Text = $"{bm.Position + 1} / {bm.Count}";
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bm.Position = HScrollBar1.Value;
            LblCount.Text = $"{bm.Position + 1} / {bm.Count}";
        }

        private void BtnCls_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtChi.Text = "";
            TxtEng.Text = "";
            TxtMath.Text = "";
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DataBindingsClear()
        {
            TxtId.DataBindings.Clear();
            TxtName.DataBindings.Clear();
            TxtChi.DataBindings.Clear();
            TxtEng.DataBindings.Clear();
            TxtMath.DataBindings.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Edit("INSERT INTO 成績(學號,姓名,國文,英文,數學) " +
                $"VALUES ('{TxtId.Text}',N'{TxtName.Text}'," +
                $"{TxtChi.Text},{TxtEng.Text},{TxtMath.Text})");
            DataBindingsClear();
            Form1_Load(sender, e);  
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Edit("UPDATE 成績 SET 姓名='" +
                $"N'{TxtName.Text}',國文={TxtChi.Text},英文={TxtEng.Text}," +
                $",數學={TxtMath.Text} WHERE 學號='{TxtId.Text}'");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            Edit($"DELETE FROM 成績 WHERE 學號='{TxtId.Text}'") ;
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
