using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KaihatsuEnshuu
{
    public partial class AddMakerForm : template.Form1
    {
        public AddMakerForm()
        {
            InitializeComponent();
        }

        private void AddMakerForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'oI21Database1DataSet.仕入先' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.仕入先TableAdapter.Fill(this.oI21Database1DataSet.仕入先);

        }



    }
}
