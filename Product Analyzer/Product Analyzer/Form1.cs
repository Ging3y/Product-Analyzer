﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FAQ faqPage = new FAQ();
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code to change window here
            faqPage.Show();
        }
    }
}
