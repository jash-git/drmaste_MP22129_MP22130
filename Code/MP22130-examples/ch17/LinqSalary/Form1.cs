using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Salary[] s = new Salary[]
        {
            new Salary { Id="E0001", Name="比爾蓋茲", EmpSalary=60000 },
            new Salary { Id="E0002", Name="賈伯斯", EmpSalary=70000 },
            new Salary { Id="E0003", Name="祖克柏", EmpSalary=50000 },
            new Salary { Id="E0004", Name="馬斯克", EmpSalary=100000 },
            new Salary { Id="E0005", Name="賴利佩吉", EmpSalary=90000 },
            new Salary { Id="E0006", Name="貝佐斯", EmpSalary=80000 }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvSalary.DataSource = s;
        }
        // 按下 [依編號排] 鈕執行
        private void BtnId_Click(object sender, EventArgs e)
        {
            var result = from r in s
                         orderby r.Id
                         select r;
            DgvSalary.DataSource = result.ToList();
        }
        // 按下 [依姓名排] 鈕執行
        private void BtnName_Click(object sender, EventArgs e)
        {
            var result = from r in s
                         orderby r.Name
                         select r;
            DgvSalary.DataSource = result.ToList();
        }
        // 按下 [依薪資排] 鈕執行
        private void BtnSalary_Click(object sender, EventArgs e)
        {
            var result = from r in s
                         orderby r.EmpSalary descending
                         select r;
            DgvSalary.DataSource = result.ToList();
        }
        // 按下 [單筆查詢] 鈕執行
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = from r in s
                         where r.Id==TxtId.Text
                         select r;
            DgvSalary.DataSource = result.ToList();
        }
    }
}
