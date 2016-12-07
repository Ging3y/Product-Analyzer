using System;
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

        //Imports csv file
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogImport.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";

            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                Product myProduct = new Product_Analyzer.Product("Test", 54.99);

                MessageBox.Show(myProduct.toString(), "Header");
            }
            else
            {
                MessageBox.Show("There was an error inputting the file.", "Header");
            }
        }
    }
}
