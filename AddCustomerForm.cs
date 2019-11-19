using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class AddCustomerForm : template.Form1
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'oI21Database1DataSet.顧客' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.顧客TableAdapter.Fill(this.oI21Database1DataSet.顧客);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
