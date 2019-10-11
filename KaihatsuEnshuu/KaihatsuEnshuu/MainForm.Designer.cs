namespace KaihatsuEnshuu
{
    partial class MainForm
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
            this.openProductForm = new System.Windows.Forms.Button();
            this.addStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openProductForm
            // 
            this.openProductForm.Location = new System.Drawing.Point(12, 216);
            this.openProductForm.Name = "openProductForm";
            this.openProductForm.Size = new System.Drawing.Size(111, 45);
            this.openProductForm.TabIndex = 0;
            this.openProductForm.Text = "商品追加";
            this.openProductForm.UseVisualStyleBackColor = true;
            this.openProductForm.Click += new System.EventHandler(this.openProductForm_Click);
            // 
            // addStock
            // 
            this.addStock.Location = new System.Drawing.Point(12, 288);
            this.addStock.Name = "addStock";
            this.addStock.Size = new System.Drawing.Size(108, 45);
            this.addStock.TabIndex = 1;
            this.addStock.Text = "倉庫入荷";
            this.addStock.UseVisualStyleBackColor = true;
            this.addStock.Click += new System.EventHandler(this.addStock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addStock);
            this.Controls.Add(this.openProductForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openProductForm;
        private System.Windows.Forms.Button addStock;
    }
}