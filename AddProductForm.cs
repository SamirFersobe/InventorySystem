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
    public partial class AddProductForm : template.Form1
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void AddProductForm_Load(object sender, EventArgs e)
        {

            // change to OLEDB 

            try
            {
                string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
                OleDbConnection con = new OleDbConnection(str);
                string sql1 = "SELECT * FROM products";

                OleDbDataAdapter da = new OleDbDataAdapter(sql1, con);
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "ProductError");
            }


            
                // TODO: このコード行はデータを 'oI21Database1DataSet.カテゴリー' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
                this.カテゴリーTableAdapter.Fill(this.oI21Database1DataSet.カテゴリー);
                // TODO: このコード行はデータを 'oI21Database1DataSet.サイズ' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
                this.サイズTableAdapter.Fill(this.oI21Database1DataSet.サイズ);
                // TODO: このコード行はデータを 'oI21Database1DataSet.色' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
                this.色TableAdapter.Fill(this.oI21Database1DataSet.色);
                // TODO: このコード行はデータを 'oI21Database1DataSet.商品' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
                this.商品TableAdapter.Fill(this.oI21Database1DataSet.商品);


                DataGridView dgv = dataGridView1;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel);

                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string name;
            string price;
            string explanation;
            string category;
            string size;
            string color;

            name = ProductNameMaskedTextBox.Text.ToString();
            price = productPrice.Text.ToString();



            string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\B8328\source\repos\KaihatsuEnshuu\KaihatsuEnshuu\OI21Database1.accdb";
            OleDbConnection con = new OleDbConnection(str);
            con.Open();
           // OleDbCommand cmmd = new OleDbCommand("INSERT INTO 商品(商品名,商品価格) Values(@Name,@Price)", con);
            if(con.State == ConnectionState.Open)
            {
               // cmmd.Parameters.Add("@Category", OleDbType.VarWChar, 20).Value = category;
                //cmmd.Parameters.Add("@Name", OleDbType.VarWChar, 20).Value = name;
               // cmmd.Parameters.Add("@Price", OleDbType.Currency, 20).Value = price;

               // cmmd.Parameters.Add("@Price", OleDbType.VarWChar, 20).Value = price;
             //   cmmd.Parameters.Add("@Color", OleDbType.VarWChar, 20).Value = color;
               // cmmd.Parameters.Add("@Size", OleDbType.VarWChar, 20).Value = size;

                try
                {
                 //   cmmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (OleDbException expe)
                {
                    MessageBox.Show(expe.Message);
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("CON FAILED");
            }

            OleDbConnection conReload = new OleDbConnection(str);
            string sql1 = "SELECT * FROM 商品";

            OleDbDataAdapter da = new OleDbDataAdapter(sql1, conReload);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           




        }
    }
    }


