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

namespace KaihatsuEnshuu
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {

            InitializeComponent();

            
        }
        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            FillComboBox("empname", "empno", comboBox1, "emp");
            FillComboBox("customerName", "customerId", comboBox2, "customers");
        }

        DataTable dt = new DataTable();
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            string customerid, employeeid;
            employeeid = comboBox1.SelectedValue.ToString();
            customerid = comboBox2.SelectedValue.ToString();


            
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [order](orderDate,orderEmpno,orderCustomerId) values(date(),@orderEmpno,@orderCustomerId)";
            cmd.Parameters.AddWithValue("@orderEmpno", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@orderCustomerId", comboBox2.SelectedValue); 
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("An order has been started");


            string lastAddedId = "select id from [order]  order by orderdate desc ";
            cmd.CommandText = lastAddedId;
            
            var orderId = cmd.ExecuteScalar();

            MessageBox.Show(orderId.ToString());



            MessageBox.Show("New order by " + comboBox1.SelectedIndex.ToString() + " for the " + comboBox2.SelectedText.ToString());
            OrderForm order = new OrderForm(employeeid,customerid,orderId.ToString());
            order.Show();
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void FillComboBox(String displayMember, String valueMember, ComboBox combo, String table)
        {
            
            DataTable dt = new DataTable();
            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            string sql1 = "SELECT "+ displayMember +  "  , "+valueMember+ " FROM "+ table ;
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
