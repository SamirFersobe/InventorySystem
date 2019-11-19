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
    public partial class OrderForm : template.Form1
    {

        /**
         *  Things we have to do , debug the system so that the functions run on the first click
         *  also we need to make the tables display the names as they should
         *  make selecting items easier and faster so as to increase 注文スピード
         * 
         * 
         * 
         * 
         * 
         
             
             
             
         **/
        string DatabaseConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
        public OrderForm(string customerID , string employeeID, string orderId)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            InitializeComponent();

            try
            {
                OleDbConnection con1 = new OleDbConnection(DatabaseConnectionString);
                string sql1 = "SELECT pBrand,pName,Pprice FROM products";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con1);
                da.Fill(dt1);

                dataGridView1.DataSource = dt1;
                //MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 1");
            }

            try
            {
                OleDbConnection con2 = new OleDbConnection(DatabaseConnectionString);
                string sql2 = "SELECT  * FROM orderDetails where orderId = " + orderId;

                OleDbDataAdapter da = new OleDbDataAdapter(sql2, con2);
                da.Fill(dt2);

                dataGridView2.DataSource = dt2;
               // MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 2");
            }

            // get the values for 
    

            FillComboBox("pName", "pId", comboBox1, "products");



        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string currentItem = comboBox1.SelectedValue.ToString();
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            lastAddedId = "select orderCustomerId from [order]  order by orderdate desc ";
            cmd.CommandText = lastAddedId;
            string customerString = cmd.ExecuteScalar().ToString();
            double price = 944;

            string sql2 = "INSERT INTO orderDetails(orderId,customerId,pId,quantity,pCurrentPrice) values (@orderId,@customerId,@pId,@quantity,@pCurrentPrice)";
            cmd.CommandText = sql2;


            
            try
            {


                cmd.Parameters.AddWithValue("@orderId", orderString);
                cmd.Parameters.AddWithValue("@customerId", customerString);
                cmd.Parameters.AddWithValue("@pId", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@quanity", textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@pCurrentPrice", price);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Item added to list");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                DataTable dt3 = new DataTable();
                OleDbConnection con3 = new OleDbConnection(DatabaseConnectionString);
                string sql3 = "SELECT  * FROM orderDetails where orderId = " + orderString;

                OleDbDataAdapter da = new OleDbDataAdapter(sql3, con3);
                da.Fill(dt3);

                dataGridView2.DataSource = dt3;
                // MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 3");
            }
            dataGridView2.Refresh();
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            deleteLastOrder();

        }


        private void deleteAllAddedItems()
        {
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            string cmdString = "DELETE * from orderdetails where orderid = " + orderString;
            cmd.CommandText = cmdString;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }

            reloadDGV(orderString);
            
        }


        private void deleteLastOrder()
        {

            deleteAllAddedItems();
            OleDbConnection con = new OleDbConnection(DatabaseConnectionString);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            con.Open();//opening connection
            string currentItem = comboBox1.SelectedValue.ToString();
            string lastAddedId = "select id from [order]  order by orderdate desc ";  //getting values
            cmd.CommandText = lastAddedId;
            string orderString = cmd.ExecuteScalar().ToString();
            string cmdString = "DELETE * from [order] where id = " + orderString;
            cmd.CommandText = cmdString;
            cmd.ExecuteNonQuery();

            this.Close();

            
        }
       
 
        


        private void reloadDGV(string orderString)
        {

            try
            {
                DataTable dt3 = new DataTable();
                OleDbConnection con3 = new OleDbConnection(DatabaseConnectionString);
                string sql3 = "SELECT  * FROM orderDetails where orderId = " + orderString;

                OleDbDataAdapter da = new OleDbDataAdapter(sql3, con3);
                da.Fill(dt3);

                dataGridView2.DataSource = dt3;
                // MessageBox.Show("Values loaded ...!!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " 3");
            }
            dataGridView2.Refresh();

        }

        private void ClearOrder_Click(object sender, MouseEventArgs e)
        {
            deleteAllAddedItems();


        }


    
    }

   


}
