using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products = new BindingList<Product>();
        public Form1()
        {
            InitializeComponent();
            listProducts.DataSource = products;
            listProducts.DisplayMember = "Description";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editor1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void registerKeypad1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
