using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product[] p = new Product[]
        {
            new Product { Id="A01", Name="火影忍者", Price=1000 },
            new Product { Id="A02", Name="獵人", Price=800 },
            new Product { Id="A03", Name="墨世佛劫", Price=1100 },
            new Product { Id="A04", Name="甲賀忍法帖", Price=600 },
            new Product { Id="A05", Name="航海王", Price=450 },
            new Product { Id="A06", Name="墨武俠鋒", Price=1060 },
        };
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            DgvProduct.DataSource = p;
        }
        // 按下 [搜尋] 鈕執行
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = p.Where(r => r.Name.Contains(TxtSearch.Text));
            DgvProduct.DataSource = result.ToList();
        }
        // 按下 [產品資料] 鈕執行
        private void BtnList_Click(object sender, EventArgs e)
        {
            var result = p.OrderBy(r => r.Id);
            DgvProduct.DataSource = result.ToList();
        }
        // 按下 [遞增排序] 鈕執行
        private void BtnAsc_Click(object sender, EventArgs e)
        {
            var result = p.OrderBy(r => r.Price);
            DgvProduct.DataSource = result.ToList();
        }
        // 按下 [遞減排序] 鈕執行
        private void BtnDesc_Click(object sender, EventArgs e)
        {
            var result = p.OrderByDescending(r => r.Price);
            DgvProduct.DataSource = result.ToList();
        }
    }
}
