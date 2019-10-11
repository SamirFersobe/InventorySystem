namespace KaihatsuEnshuu
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.cancelProduct = new System.Windows.Forms.Button();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addproduct = new System.Windows.Forms.Button();
            this.商品名 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(467, 315);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(220, 96);
            this.productDescription.TabIndex = 31;
            this.productDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "商品説明";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(467, 149);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(220, 23);
            this.categoryComboBox.TabIndex = 29;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(467, 211);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(220, 23);
            this.colorComboBox.TabIndex = 28;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(467, 268);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(220, 23);
            this.supplierComboBox.TabIndex = 27;
            // 
            // cancelProduct
            // 
            this.cancelProduct.Location = new System.Drawing.Point(530, 436);
            this.cancelProduct.Name = "cancelProduct";
            this.cancelProduct.Size = new System.Drawing.Size(157, 64);
            this.cancelProduct.TabIndex = 26;
            this.cancelProduct.Text = "キャンセル";
            this.cancelProduct.UseVisualStyleBackColor = true;
            this.cancelProduct.Click += new System.EventHandler(this.cancelProduct_Click);
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(467, 85);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(220, 22);
            this.productPrice.TabIndex = 25;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(467, 27);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(220, 22);
            this.productName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "仕入先";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "カテゴリー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "商品価格";
            // 
            // addproduct
            // 
            this.addproduct.Location = new System.Drawing.Point(285, 436);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(157, 64);
            this.addproduct.TabIndex = 19;
            this.addproduct.Text = "追加";
            this.addproduct.UseVisualStyleBackColor = true;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // 商品名
            // 
            this.商品名.AutoSize = true;
            this.商品名.Location = new System.Drawing.Point(294, 27);
            this.商品名.Name = "商品名";
            this.商品名.Size = new System.Drawing.Size(52, 15);
            this.商品名.TabIndex = 18;
            this.商品名.Text = "商品名";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 625);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.cancelProduct);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.商品名);
            this.Name = "ProductForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox productDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Button cancelProduct;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Label 商品名;
    }
}