namespace KaihatsuEnshuu
{
    partial class AddProductForm
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
            this.商品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oI21Database1DataSet = new KaihatsuEnshuu.OI21Database1DataSet();
            this.商品TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.商品TableAdapter();
            this.Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.カテゴリーBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.MaskedTextBox();
            this.productExplanation = new System.Windows.Forms.RichTextBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.色BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.サイズBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.色TableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.色TableAdapter();
            this.サイズTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.サイズTableAdapter();
            this.カテゴリーTableAdapter = new KaihatsuEnshuu.OI21Database1DataSetTableAdapters.カテゴリーTableAdapter();
            this.addProductButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリーBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.色BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.サイズBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.sizeComboBox);
            this.groupBox1.Controls.Add(this.colorComboBox);
            this.groupBox1.Controls.Add(this.productExplanation);
            this.groupBox1.Controls.Add(this.productPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProductNameMaskedTextBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Category);
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
            // 商品BindingSource
            // 
            this.商品BindingSource.DataMember = "商品";
            this.商品BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // oI21Database1DataSet
            // 
            this.oI21Database1DataSet.DataSetName = "OI21Database1DataSet";
            this.oI21Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 商品TableAdapter
            // 
            this.商品TableAdapter.ClearBeforeFill = true;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(54, 271);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(70, 17);
            this.Category.TabIndex = 0;
            this.Category.Text = "カテゴリー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品価格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品説明";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "色";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.カテゴリーBindingSource;
            this.categoryComboBox.DisplayMember = "カテゴリー名";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(139, 271);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(198, 25);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.ValueMember = "ID";
            // 
            // カテゴリーBindingSource
            // 
            this.カテゴリーBindingSource.DataMember = "カテゴリー";
            this.カテゴリーBindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // ProductNameMaskedTextBox
            // 
            this.ProductNameMaskedTextBox.Location = new System.Drawing.Point(139, 20);
            this.ProductNameMaskedTextBox.Name = "ProductNameMaskedTextBox";
            this.ProductNameMaskedTextBox.Size = new System.Drawing.Size(198, 24);
            this.ProductNameMaskedTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "サイズ";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(139, 61);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(198, 24);
            this.productPrice.TabIndex = 8;
            // 
            // productExplanation
            // 
            this.productExplanation.Location = new System.Drawing.Point(139, 92);
            this.productExplanation.Name = "productExplanation";
            this.productExplanation.Size = new System.Drawing.Size(198, 96);
            this.productExplanation.TabIndex = 9;
            this.productExplanation.Text = "";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DataSource = this.色BindingSource;
            this.colorComboBox.DisplayMember = "色";
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(139, 204);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(198, 25);
            this.colorComboBox.TabIndex = 10;
            this.colorComboBox.ValueMember = "ID";
            // 
            // 色BindingSource
            // 
            this.色BindingSource.DataMember = "色";
            this.色BindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DataSource = this.サイズBindingSource;
            this.sizeComboBox.DisplayMember = "サイズ省略";
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(139, 240);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(198, 25);
            this.sizeComboBox.TabIndex = 11;
            this.sizeComboBox.ValueMember = "サイズID";
            // 
            // サイズBindingSource
            // 
            this.サイズBindingSource.DataMember = "サイズ";
            this.サイズBindingSource.DataSource = this.oI21Database1DataSet;
            // 
            // 色TableAdapter
            // 
            this.色TableAdapter.ClearBeforeFill = true;
            // 
            // サイズTableAdapter
            // 
            this.サイズTableAdapter.ClearBeforeFill = true;
            // 
            // カテゴリーTableAdapter
            // 
            this.カテゴリーTableAdapter.ClearBeforeFill = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(139, 315);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(115, 23);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "追加";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1506, 757);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.商品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oI21Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.カテゴリーBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.色BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.サイズBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OI21Database1DataSet oI21Database1DataSet;
        private System.Windows.Forms.BindingSource 商品BindingSource;
        private OI21Database1DataSetTableAdapters.商品TableAdapter 商品TableAdapter;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.RichTextBox productExplanation;
        private System.Windows.Forms.MaskedTextBox productPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ProductNameMaskedTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.BindingSource 色BindingSource;
        private OI21Database1DataSetTableAdapters.色TableAdapter 色TableAdapter;
        private System.Windows.Forms.BindingSource サイズBindingSource;
        private OI21Database1DataSetTableAdapters.サイズTableAdapter サイズTableAdapter;
        private System.Windows.Forms.BindingSource カテゴリーBindingSource;
        private OI21Database1DataSetTableAdapters.カテゴリーTableAdapter カテゴリーTableAdapter;
        private System.Windows.Forms.Button addProductButton;
    }
}
