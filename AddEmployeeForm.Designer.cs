namespace KaihatsuEnshuu
{
	partial class AddEmployeeForm
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
			if(disposing && (components != null))
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
            this.社員ファイルBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.社員ファイルBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.社員ファイルTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.社員ファイルTableAdapter();
            this.社員ID = new System.Windows.Forms.Label();
            this.社員名 = new System.Windows.Forms.Label();
            this.入社日 = new System.Windows.Forms.Label();
            this.物流担当 = new System.Windows.Forms.Label();
            this.営業担当 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.EmployeeID);
            this.groupBox1.Controls.Add(this.営業担当);
            this.groupBox1.Controls.Add(this.物流担当);
            this.groupBox1.Controls.Add(this.入社日);
            this.groupBox1.Controls.Add(this.社員名);
            this.groupBox1.Controls.Add(this.社員ID);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 580);
            this.dataGridView1.TabIndex = 0;
            // 
            // 社員ファイルBindingSource1
            // 
            this.社員ファイルBindingSource1.DataMember = "社員ファイル";
            this.社員ファイルBindingSource1.DataSource = this.oI21Database1DataSetBindingSource;
            // 
            // oI21Database1DataSetBindingSource
            // 
            this.oI21Database1DataSetBindingSource.DataSource = this.oI21Database1DataSet;
            this.oI21Database1DataSetBindingSource.Position = 0;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 社員ファイルBindingSource
            // 
            this.社員ファイルBindingSource.DataMember = "社員ファイル";
            this.社員ファイルBindingSource.DataSource = this.oI21Database1DataSetBindingSource;
            // 
            // 社員ファイルTableAdapter
            // 
            this.社員ファイルTableAdapter.ClearBeforeFill = true;
            // 
            // 社員ID
            // 
            this.社員ID.AutoSize = true;
            this.社員ID.Location = new System.Drawing.Point(36, 64);
            this.社員ID.Name = "社員ID";
            this.社員ID.Size = new System.Drawing.Size(57, 17);
            this.社員ID.TabIndex = 0;
            this.社員ID.Text = "社員ID";
            this.社員ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // 社員名
            // 
            this.社員名.AutoSize = true;
            this.社員名.Location = new System.Drawing.Point(36, 112);
            this.社員名.Name = "社員名";
            this.社員名.Size = new System.Drawing.Size(59, 17);
            this.社員名.TabIndex = 1;
            this.社員名.Text = "社員名";
            // 
            // 入社日
            // 
            this.入社日.AutoSize = true;
            this.入社日.Location = new System.Drawing.Point(36, 153);
            this.入社日.Name = "入社日";
            this.入社日.Size = new System.Drawing.Size(59, 17);
            this.入社日.TabIndex = 2;
            this.入社日.Text = "入社日";
            // 
            // 物流担当
            // 
            this.物流担当.AutoSize = true;
            this.物流担当.Location = new System.Drawing.Point(36, 199);
            this.物流担当.Name = "物流担当";
            this.物流担当.Size = new System.Drawing.Size(76, 17);
            this.物流担当.TabIndex = 3;
            this.物流担当.Text = "物流担当";
            // 
            // 営業担当
            // 
            this.営業担当.AutoSize = true;
            this.営業担当.Location = new System.Drawing.Point(36, 241);
            this.営業担当.Name = "営業担当";
            this.営業担当.Size = new System.Drawing.Size(76, 17);
            this.営業担当.TabIndex = 4;
            this.営業担当.Text = "営業担当";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.社員ファイルBindingSource, "社員ID", true));
            this.EmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.社員ファイルBindingSource, "社員ID", true));
            this.EmployeeID.Location = new System.Drawing.Point(142, 57);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(100, 24);
            this.EmployeeID.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.社員ファイルBindingSource, "社員名", true));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.社員ファイルBindingSource, "社員名", true));
            this.textBox3.Location = new System.Drawing.Point(142, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 24);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.社員ファイルBindingSource, "物流担当", true));
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.社員ファイルBindingSource, "物流担当", true));
            this.checkBox1.Location = new System.Drawing.Point(142, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.社員ファイルBindingSource, "営業担当", true));
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.社員ファイルBindingSource, "営業担当", true));
            this.checkBox2.Location = new System.Drawing.Point(142, 241);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 24);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Name = "AddEmployeeForm";
            this.Text = "社員";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.社員ファイルBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oI21Database1DataSetBindingSource;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 社員ファイルBindingSource;
        private OI21Database1DataSetTableAdapters.社員ファイルTableAdapter 社員ファイルTableAdapter;
        private System.Windows.Forms.Label 物流担当;
        private System.Windows.Forms.Label 入社日;
        private System.Windows.Forms.Label 社員名;
        private System.Windows.Forms.Label 社員ID;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.Label 営業担当;
        private System.Windows.Forms.BindingSource 社員ファイルBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
