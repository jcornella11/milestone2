using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milestone1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Driver Code

            Inventory item = new Inventory();

            //Setter Methods for Class
            string[] searchtags = { "Lightweight", "Steet Running" };
            item.itemName = "Nike FreeRuns";
            item.itemPrice = 99.99;
            item.itemSize = "Medium";
            item.customerComment = "These are great shoes";
            item.productCategory = "Running Shoes";
            item.searchTags = searchtags;

            //Get Methods for Class
            string itemName = item.itemName;
            double itemPrice = item.itemPrice;
            string itemSize = item.itemSize;
            string customerComment = item.customerComment;
            string productCategory = item.productCategory;
            string[] searchresults = item.searchTags;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
