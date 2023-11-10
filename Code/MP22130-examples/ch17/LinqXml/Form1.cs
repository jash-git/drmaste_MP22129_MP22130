using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XElement xf = XElement.Load("aqx.xml");

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = from s in xf.Elements()
                         select new
                         {
                             縣市 = (string)s.Element("county"),
                             測站 = (string)s.Element("Site"),
                             濃度 = (int)s.Element("PM25")
                         };
            DgvShow.DataSource = result.ToList();
        }

        private void BtnCounty_Click(object sender, EventArgs e)
        {
            var result = from s in xf.Elements()
                         orderby (string)s.Element("county")
                         select new
                         {
                             縣市 = (string)s.Element("county"),
                             測站 = (string)s.Element("Site"),
                             濃度 = (int)s.Element("PM25")
                         };
            DgvShow.DataSource = result.ToList();
        }

        private void BtnPM25_Click(object sender, EventArgs e)
        {
            var result = from s in xf.Elements()
                         orderby (int)s.Element("PM25") descending
                         select new
                         {
                             縣市 = (string)s.Element("county"),
                             測站 = (string)s.Element("Site"),
                             濃度 = (int)s.Element("PM25")
                         };
            DgvShow.DataSource = result.ToList();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = from s in xf.Elements()
                         where (int)s.Element("PM25")>=int.Parse(TxtSearch.Text)
                         select new
                         {
                             縣市 = (string)s.Element("county"),
                             測站 = (string)s.Element("Site"),
                             濃度 = (int)s.Element("PM25")
                         };
            DgvShow.DataSource = result.ToList();
        }
    }
}
