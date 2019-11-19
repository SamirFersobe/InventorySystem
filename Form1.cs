using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void FillComboBox(String displayMember, String valueMember, ComboBox combo, String table)
        {

            DataTable dt = new DataTable();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql1 = "SELECT " + displayMember + "  , " + valueMember + " FROM " + table;
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);

            da.Fill(dt);

            combo.DataSource = dt.DefaultView;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;

            con.Close();
        }
    }
}
