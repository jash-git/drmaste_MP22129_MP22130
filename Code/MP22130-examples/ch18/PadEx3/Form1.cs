﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadEx3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PadClass bsus = new PadClass();
            bsus.setPrice(25900);
            label1.Text = $"BSUS 平板電腦單價 : {bsus.getPrice()}";
        }
    }
}
