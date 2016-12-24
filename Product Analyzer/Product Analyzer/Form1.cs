using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Product_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importFile(string path_, ref List<Product> productList_)
        {
            int position;
            string product;
            string link;
            string brand;
            int sellers;
            int variations;
            double price;
            string category;
            int rank;
            int sales;
            double revenue;
            int reviews;
            double rating;
            string type;

           // foreach(string element in values)
           

            //var inputFile = new StreamReader(File.OpenRead(path_));
            //while (!reader.EndOfStream)
            //{
            //    var line = reader.ReadLine();
            //    var values = line.Split(',');

            //    try
            //    {
            //        position = Int32.Parse((values[0]));

            //        Product myProduct = new Product(position, "Hammock", "www.mylink.com", "Upper Heights", 3, 24, 34.99, "Outdoor", 3, 441, 21000.44, 74, 3.5, "FBA");
            //        MessageBox.Show(myProduct.toStringFullInfo());
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Failure to load");
            //        position = 0;
            //    }
            //    //MessageBox.Show(position.ToString(), "Header");

            //    //Product myProduct = new Product(position, "Hammock", "www.mylink.com", "Upper Heights", 3, 24, 34.99, "Outdoor", 3, 441, 21000.44, 74, 3.5, "FBA");
            //    //MessageBox.Show(myProduct.toStringFullInfo());

            //    //listA.Add(values[0]);
            //    //listB.Add(values[1]);
            //    // Product myProduct = new Product_Analyzer.Product("Test", 54.99);
            //    // productList_.Add(myProduct);
        }

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
            List<Product> productList = new List<Product>();
             
            openFileDialogImport.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";

            if (openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialogImport.InitialDirectory + openFileDialogImport.FileName;

                importFile(strfilename, ref productList);

                //MessageBox.Show(productList[0].toString(), "Header");
            }
            else
            {
                MessageBox.Show("There was an error inputting the file.", "Header");
            }
        }
    }
}
