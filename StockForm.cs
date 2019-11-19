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
    public partial class StockForm : template.Form1
    {
        public StockForm()
        {
            InitializeComponent();

            DataTable dt = new DataTable
                ();
            try
            {
                string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
                OleDbConnection con = new OleDbConnection(str);
                string sql1 = "SELECT * FROM 倉庫 s   left outer join 商品 p on (p.商品ID = s.商品ID)";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                da.Fill(dt);

                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");
            }
        }


    }
}
