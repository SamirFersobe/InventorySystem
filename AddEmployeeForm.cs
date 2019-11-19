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
    public partial class AddEmployeeForm : template.Form1
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {


            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql1 = "SELECT * FROM  emp";

            OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
