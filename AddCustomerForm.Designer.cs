namespace KaihatsuEnshuu
{
    partial class AddCustomerForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.oI21Database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.顧客BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.顧客TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.顧客TableAdapter();
            this.顧客IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.顧客名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住所DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.メールDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Fax = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.Fax);
            this.groupBox1.Controls.Add(this.Tel);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.CustomerName);
            this.groupBox1.Controls.Add(this.CustomerID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.顧客IDDataGridViewTextBoxColumn,
            this.顧客名DataGridViewTextBoxColumn,
            this.住所DataGridViewTextBoxColumn,
            this.tELDataGridViewTextBoxColumn,
            this.fAXDataGridViewTextBoxColumn,
            this.メールDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.顧客BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 580);
            this.dataGridView1.TabIndex = 0;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oI21Database1DataSetBindingSource
            // 
            this.oI21Database1DataSetBindingSource.DataSource = this.oI21Database1DataSet;
            this.oI21Database1DataSetBindingSource.Position = 0;
            // 
            // 顧客BindingSource
            // 
            this.顧客BindingSource.DataMember = "顧客";
            this.顧客BindingSource.DataSource = this.oI21Database1DataSetBindingSource;
            // 
            // 顧客TableAdapter
            // 
            this.顧客TableAdapter.ClearBeforeFill = true;
            // 
            // 顧客IDDataGridViewTextBoxColumn
            // 
            this.顧客IDDataGridViewTextBoxColumn.DataPropertyName = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.HeaderText = "顧客ID";
            this.顧客IDDataGridViewTextBoxColumn.Name = "顧客IDDataGridViewTextBoxColumn";
            // 
            // 顧客名DataGridViewTextBoxColumn
            // 
            this.顧客名DataGridViewTextBoxColumn.DataPropertyName = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.HeaderText = "顧客名";
            this.顧客名DataGridViewTextBoxColumn.Name = "顧客名DataGridViewTextBoxColumn";
            // 
            // 住所DataGridViewTextBoxColumn
            // 
            this.住所DataGridViewTextBoxColumn.DataPropertyName = "住所";
            this.住所DataGridViewTextBoxColumn.HeaderText = "住所";
            this.住所DataGridViewTextBoxColumn.Name = "住所DataGridViewTextBoxColumn";
            // 
            // tELDataGridViewTextBoxColumn
            // 
            this.tELDataGridViewTextBoxColumn.DataPropertyName = "TEL";
            this.tELDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.tELDataGridViewTextBoxColumn.Name = "tELDataGridViewTextBoxColumn";
            // 
            // fAXDataGridViewTextBoxColumn
            // 
            this.fAXDataGridViewTextBoxColumn.DataPropertyName = "FAX";
            this.fAXDataGridViewTextBoxColumn.HeaderText = "FAX";
            this.fAXDataGridViewTextBoxColumn.Name = "fAXDataGridViewTextBoxColumn";
            // 
            // メールDataGridViewTextBoxColumn
            // 
            this.メールDataGridViewTextBoxColumn.DataPropertyName = "メール";
            this.メールDataGridViewTextBoxColumn.HeaderText = "メール";
            this.メールDataGridViewTextBoxColumn.Name = "メールDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "顧客ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "顧客名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "TEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "FAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "メール";
            // 
            // CustomerID
            // 
            this.CustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "顧客ID", true));
            this.CustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "顧客ID", true));
            this.CustomerID.Location = new System.Drawing.Point(140, 36);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(100, 24);
            this.CustomerID.TabIndex = 1;
            // 
            // CustomerName
            // 
            this.CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "顧客名", true));
            this.CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "顧客名", true));
            this.CustomerName.Location = new System.Drawing.Point(140, 78);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 24);
            this.CustomerName.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "住所", true));
            this.Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "住所", true));
            this.Address.Location = new System.Drawing.Point(140, 129);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(175, 24);
            this.Address.TabIndex = 1;
            this.Address.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tel
            // 
            this.Tel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "TEL", true));
            this.Tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "TEL", true));
            this.Tel.Location = new System.Drawing.Point(140, 168);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(100, 24);
            this.Tel.TabIndex = 1;
            // 
            // Fax
            // 
            this.Fax.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "FAX", true));
            this.Fax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "FAX", true));
            this.Fax.Location = new System.Drawing.Point(140, 212);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(100, 24);
            this.Fax.TabIndex = 1;
            // 
            // Mail
            // 
            this.Mail.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.顧客BindingSource, "メール", true));
            this.Mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.顧客BindingSource, "メール", true));
            this.Mail.Location = new System.Drawing.Point(140, 256);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 24);
            this.Mail.TabIndex = 1;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Name = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.顧客BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oI21Database1DataSetBindingSource;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 顧客BindingSource;
        private OI21Database1DataSetTableAdapters.顧客TableAdapter 顧客TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 顧客名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn メールDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox Fax;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
