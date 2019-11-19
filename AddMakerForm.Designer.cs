namespace KaihatsuEnshuu
{
    partial class AddMakerForm
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
            this.仕入先IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.企業名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.アドレス１DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.アドレス２DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.住所DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.郵便番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.国DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eメールDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.支払方法DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仕入先BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.仕入先TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.仕入先TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.MakerIdMTB = new System.Windows.Forms.MaskedTextBox();
            this.MakerPostalCodeMTB = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MakerAddress1MTB = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MakerNameMTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MakerAddress3MTB = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MakerAddress2MTB = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MakerCountryMTB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MakerPhoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MakerFaxMTB = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MakerEmailMTB = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MakerURLMTB = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MakerHowToPayMTB = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EnableEditingCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.NoTextBox = new System.Windows.Forms.TextBox();
            this.PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.仕入先BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MakerHowToPayMTB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.MakerURLMTB);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.MakerEmailMTB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MakerCountryMTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MakerPhoneMTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MakerFaxMTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MakerAddress2MTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MakerAddress3MTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MakerNameMTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MakerAddress1MTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MakerPostalCodeMTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MakerIdMTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Size = new System.Drawing.Size(352, 560);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.仕入先IDDataGridViewTextBoxColumn,
            this.企業名DataGridViewTextBoxColumn,
            this.アドレス１DataGridViewTextBoxColumn,
            this.アドレス２DataGridViewTextBoxColumn,
            this.住所DataGridViewTextBoxColumn,
            this.郵便番号DataGridViewTextBoxColumn,
            this.国DataGridViewTextBoxColumn,
            this.電話番号DataGridViewTextBoxColumn,
            this.fAXDataGridViewTextBoxColumn,
            this.eメールDataGridViewTextBoxColumn,
            this.uRLDataGridViewTextBoxColumn,
            this.支払方法DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.仕入先BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 580);
            this.dataGridView1.TabIndex = 0;
            // 
            // 仕入先IDDataGridViewTextBoxColumn
            // 
            this.仕入先IDDataGridViewTextBoxColumn.DataPropertyName = "仕入先ID";
            this.仕入先IDDataGridViewTextBoxColumn.HeaderText = "仕入先ID";
            this.仕入先IDDataGridViewTextBoxColumn.Name = "仕入先IDDataGridViewTextBoxColumn";
            this.仕入先IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 企業名DataGridViewTextBoxColumn
            // 
            this.企業名DataGridViewTextBoxColumn.DataPropertyName = "企業名";
            this.企業名DataGridViewTextBoxColumn.HeaderText = "企業名";
            this.企業名DataGridViewTextBoxColumn.Name = "企業名DataGridViewTextBoxColumn";
            this.企業名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // アドレス１DataGridViewTextBoxColumn
            // 
            this.アドレス１DataGridViewTextBoxColumn.DataPropertyName = "アドレス１";
            this.アドレス１DataGridViewTextBoxColumn.HeaderText = "アドレス１";
            this.アドレス１DataGridViewTextBoxColumn.Name = "アドレス１DataGridViewTextBoxColumn";
            this.アドレス１DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // アドレス２DataGridViewTextBoxColumn
            // 
            this.アドレス２DataGridViewTextBoxColumn.DataPropertyName = "アドレス２";
            this.アドレス２DataGridViewTextBoxColumn.HeaderText = "アドレス２";
            this.アドレス２DataGridViewTextBoxColumn.Name = "アドレス２DataGridViewTextBoxColumn";
            this.アドレス２DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 住所DataGridViewTextBoxColumn
            // 
            this.住所DataGridViewTextBoxColumn.DataPropertyName = "住所";
            this.住所DataGridViewTextBoxColumn.HeaderText = "住所";
            this.住所DataGridViewTextBoxColumn.Name = "住所DataGridViewTextBoxColumn";
            this.住所DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 郵便番号DataGridViewTextBoxColumn
            // 
            this.郵便番号DataGridViewTextBoxColumn.DataPropertyName = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.HeaderText = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.Name = "郵便番号DataGridViewTextBoxColumn";
            this.郵便番号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 国DataGridViewTextBoxColumn
            // 
            this.国DataGridViewTextBoxColumn.DataPropertyName = "国";
            this.国DataGridViewTextBoxColumn.HeaderText = "国";
            this.国DataGridViewTextBoxColumn.Name = "国DataGridViewTextBoxColumn";
            this.国DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 電話番号DataGridViewTextBoxColumn
            // 
            this.電話番号DataGridViewTextBoxColumn.DataPropertyName = "電話番号";
            this.電話番号DataGridViewTextBoxColumn.HeaderText = "電話番号";
            this.電話番号DataGridViewTextBoxColumn.Name = "電話番号DataGridViewTextBoxColumn";
            this.電話番号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fAXDataGridViewTextBoxColumn
            // 
            this.fAXDataGridViewTextBoxColumn.DataPropertyName = "FAX";
            this.fAXDataGridViewTextBoxColumn.HeaderText = "FAX";
            this.fAXDataGridViewTextBoxColumn.Name = "fAXDataGridViewTextBoxColumn";
            this.fAXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eメールDataGridViewTextBoxColumn
            // 
            this.eメールDataGridViewTextBoxColumn.DataPropertyName = "eメール";
            this.eメールDataGridViewTextBoxColumn.HeaderText = "eメール";
            this.eメールDataGridViewTextBoxColumn.Name = "eメールDataGridViewTextBoxColumn";
            this.eメールDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uRLDataGridViewTextBoxColumn
            // 
            this.uRLDataGridViewTextBoxColumn.DataPropertyName = "URL";
            this.uRLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.uRLDataGridViewTextBoxColumn.Name = "uRLDataGridViewTextBoxColumn";
            this.uRLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 支払方法DataGridViewTextBoxColumn
            // 
            this.支払方法DataGridViewTextBoxColumn.DataPropertyName = "支払方法";
            this.支払方法DataGridViewTextBoxColumn.HeaderText = "支払方法";
            this.支払方法DataGridViewTextBoxColumn.Name = "支払方法DataGridViewTextBoxColumn";
            this.支払方法DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 仕入先BindingSource
            // 
            this.仕入先BindingSource.DataMember = "仕入先";
            this.仕入先BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 仕入先TableAdapter
            // 
            this.仕入先TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "仕入先ID";
            // 
            // MakerIdMTB
            // 
            this.MakerIdMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "仕入先ID", true));
            this.MakerIdMTB.Location = new System.Drawing.Point(115, 27);
            this.MakerIdMTB.Name = "MakerIdMTB";
            this.MakerIdMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerIdMTB.TabIndex = 1;
            // 
            // MakerPostalCodeMTB
            // 
            this.MakerPostalCodeMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "郵便番号", true));
            this.MakerPostalCodeMTB.Location = new System.Drawing.Point(115, 255);
            this.MakerPostalCodeMTB.Name = "MakerPostalCodeMTB";
            this.MakerPostalCodeMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerPostalCodeMTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "郵便番号";
            // 
            // MakerAddress1MTB
            // 
            this.MakerAddress1MTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "アドレス１", true));
            this.MakerAddress1MTB.Location = new System.Drawing.Point(115, 117);
            this.MakerAddress1MTB.Name = "MakerAddress1MTB";
            this.MakerAddress1MTB.Size = new System.Drawing.Size(217, 24);
            this.MakerAddress1MTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "アドレス1";
            // 
            // MakerNameMTB
            // 
            this.MakerNameMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "企業名", true));
            this.MakerNameMTB.Location = new System.Drawing.Point(115, 74);
            this.MakerNameMTB.Name = "MakerNameMTB";
            this.MakerNameMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerNameMTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "企業名";
            // 
            // MakerAddress3MTB
            // 
            this.MakerAddress3MTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "住所", true));
            this.MakerAddress3MTB.Location = new System.Drawing.Point(115, 207);
            this.MakerAddress3MTB.Name = "MakerAddress3MTB";
            this.MakerAddress3MTB.Size = new System.Drawing.Size(217, 24);
            this.MakerAddress3MTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "住所";
            // 
            // MakerAddress2MTB
            // 
            this.MakerAddress2MTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "アドレス２", true));
            this.MakerAddress2MTB.Location = new System.Drawing.Point(115, 165);
            this.MakerAddress2MTB.Name = "MakerAddress2MTB";
            this.MakerAddress2MTB.Size = new System.Drawing.Size(217, 24);
            this.MakerAddress2MTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "アドレス2";
            // 
            // MakerCountryMTB
            // 
            this.MakerCountryMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "国", true));
            this.MakerCountryMTB.Location = new System.Drawing.Point(115, 301);
            this.MakerCountryMTB.Name = "MakerCountryMTB";
            this.MakerCountryMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerCountryMTB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "国";
            // 
            // MakerPhoneMTB
            // 
            this.MakerPhoneMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "電話番号", true));
            this.MakerPhoneMTB.Location = new System.Drawing.Point(115, 342);
            this.MakerPhoneMTB.Name = "MakerPhoneMTB";
            this.MakerPhoneMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerPhoneMTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 14;
         
            // 
            // MakerFaxMTB
            // 
            this.MakerFaxMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "FAX", true));
            this.MakerFaxMTB.Location = new System.Drawing.Point(115, 379);
            this.MakerFaxMTB.Name = "MakerFaxMTB";
            this.MakerFaxMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerFaxMTB.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "FAX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "電話番号";
            // 
            // MakerEmailMTB
            // 
            this.MakerEmailMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "eメール", true));
            this.MakerEmailMTB.Location = new System.Drawing.Point(115, 423);
            this.MakerEmailMTB.Name = "MakerEmailMTB";
            this.MakerEmailMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerEmailMTB.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "eメール";
            // 
            // MakerURLMTB
            // 
            this.MakerURLMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "URL", true));
            this.MakerURLMTB.Location = new System.Drawing.Point(115, 469);
            this.MakerURLMTB.Name = "MakerURLMTB";
            this.MakerURLMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerURLMTB.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "URL";
            // 
            // MakerHowToPayMTB
            // 
            this.MakerHowToPayMTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.仕入先BindingSource, "支払方法", true));
            this.MakerHowToPayMTB.Location = new System.Drawing.Point(115, 511);
            this.MakerHowToPayMTB.Name = "MakerHowToPayMTB";
            this.MakerHowToPayMTB.Size = new System.Drawing.Size(217, 24);
            this.MakerHowToPayMTB.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 518);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "支払方法";
            // 
            // EnableEditingCheckBox1
            // 
            this.EnableEditingCheckBox1.AutoSize = true;
            this.EnableEditingCheckBox1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EnableEditingCheckBox1.ForeColor = System.Drawing.Color.Lavender;
            this.EnableEditingCheckBox1.Location = new System.Drawing.Point(840, 75);
            this.EnableEditingCheckBox1.Name = "EnableEditingCheckBox1";
            this.EnableEditingCheckBox1.Size = new System.Drawing.Size(127, 21);
            this.EnableEditingCheckBox1.TabIndex = 18;
            this.EnableEditingCheckBox1.Text = "EnableEditing";
            this.EnableEditingCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.Color.Cornsilk;
            this.label14.Location = new System.Drawing.Point(450, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 24);
            this.label14.TabIndex = 17;
            this.label14.Text = "Custom ID:";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(592, 66);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(192, 30);
            this.EmployeeIDTextBox.TabIndex = 16;
            this.EmployeeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.Cornsilk;
            this.label15.Location = new System.Drawing.Point(260, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "No:";
            // 
            // NoTextBox
            // 
            this.NoTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NoTextBox.Location = new System.Drawing.Point(308, 63);
            this.NoTextBox.Name = "NoTextBox";
            this.NoTextBox.Size = new System.Drawing.Size(100, 30);
            this.NoTextBox.TabIndex = 14;
            
            // 
            // PrefixComboBox
            // 
            this.PrefixComboBox.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefixComboBox.FormattingEnabled = true;
            this.PrefixComboBox.Location = new System.Drawing.Point(100, 64);
            this.PrefixComboBox.Name = "PrefixComboBox";
            this.PrefixComboBox.Size = new System.Drawing.Size(121, 25);
            this.PrefixComboBox.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.ForeColor = System.Drawing.Color.Cornsilk;
            this.label16.Location = new System.Drawing.Point(27, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Prefix:";
            // 
            // AddMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Controls.Add(this.EnableEditingCheckBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.NoTextBox);
            this.Controls.Add(this.PrefixComboBox);
            this.Controls.Add(this.label16);
            this.Name = "AddMakerForm";
            this.Load += new System.EventHandler(this.AddMakerForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.PrefixComboBox, 0);
            this.Controls.SetChildIndex(this.NoTextBox, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.EmployeeIDTextBox, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.EnableEditingCheckBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.仕入先BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 仕入先BindingSource;
        private OI21Database1DataSetTableAdapters.仕入先TableAdapter 仕入先TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仕入先IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 企業名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn アドレス１DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn アドレス２DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 住所DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 郵便番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 国DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eメールDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 支払方法DataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox MakerNameMTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MakerAddress1MTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MakerPostalCodeMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MakerIdMTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MakerCountryMTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MakerPhoneMTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MakerFaxMTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MakerAddress2MTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MakerAddress3MTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MakerURLMTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MakerEmailMTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox MakerHowToPayMTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox EnableEditingCheckBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NoTextBox;
        private System.Windows.Forms.ComboBox PrefixComboBox;
        private System.Windows.Forms.Label label16;
    }
}
