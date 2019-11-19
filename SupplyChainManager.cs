using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KaihatsuEnshuu
{
    public partial class SupplyChainManager : template.Form1
    {
        public SupplyChainManager()
        {
            InitializeComponent();
        }

        string orderDetails;
        DataTable dt1 = new DataTable(); // This one has the orders
        DataTable dt2 = new DataTable();//This one display the orders 内容
        private void SupplyChainManager_Load(object sender, EventArgs e)
        {

            //loading all the values for the order table
            try
            {
                string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
                OleDbConnection con = new OleDbConnection(str);
                string sql1 = "SELECT * FROM [order]";
               
                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                MessageBox.Show("Values loaded ...!!!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //check if row index is not 
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                 orderDetails =  dataGridView1.CurrentCell.Value.ToString();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql2 = "SELECT * FROM orderDetails";
            if (orderDetails != null)
            {
                sql2 = "SELECT products.pName,products.Pbrand,orderdetails.pCurrentPrice FROM orderDetails inner join products on (products.pid = orderdetails.pid) where orderID = " + orderDetails;
            }
            OleDbDataAdapter da2 = new OleDbDataAdapter(sql2, con);
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            MessageBox.Show("Values changed");
        }
    }
}
