using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void addproduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
