namespace CafeteriaSystem
{
    partial class ViewAllProducts
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
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsGridView);
            this.ProductsGroupBox.Location = new System.Drawing.Point(12, 36);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Size = new System.Drawing.Size(590, 325);
            this.ProductsGroupBox.TabIndex = 0;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Products";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductCategoryColumn,
            this.ProductDescriptionColumn,
            this.ProductImageColumn,
            this.EditProductColumn,
            this.DeleteProductColumn});
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.Location = new System.Drawing.Point(3, 16);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(584, 306);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.Name = "ProductIDColumn";
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductCategoryColumn
            // 
            this.ProductCategoryColumn.HeaderText = "Category";
            this.ProductCategoryColumn.Name = "ProductCategoryColumn";
            // 
            // ProductDescriptionColumn
            // 
            this.ProductDescriptionColumn.HeaderText = "Description";
            this.ProductDescriptionColumn.Name = "ProductDescriptionColumn";
            // 
            // ProductImageColumn
            // 
            this.ProductImageColumn.HeaderText = "Image";
            this.ProductImageColumn.Name = "ProductImageColumn";
            this.ProductImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditProductColumn
            // 
            this.EditProductColumn.HeaderText = "Edit";
            this.EditProductColumn.Name = "EditProductColumn";
            this.EditProductColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditProductColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteProductColumn
            // 
            this.DeleteProductColumn.HeaderText = "Delete";
            this.DeleteProductColumn.Name = "DeleteProductColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Category";
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(100, 12);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(499, 21);
            this.ProductCategoryComboBox.Sorted = true;
            this.ProductCategoryComboBox.TabIndex = 2;
            this.ProductCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryComboBox_SelectedIndexChanged);
            // 
            // ViewAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 372);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsGroupBox);
            this.Name = "ViewAllProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View All Products";
            this.Load += new System.EventHandler(this.ViewAllProducts_Load);
            this.ProductsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescriptionColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditProductColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProductColumn;
    }
}