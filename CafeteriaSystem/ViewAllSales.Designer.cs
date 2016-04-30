namespace CafeteriaSystem
{
    partial class ViewAllSales
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
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.SaleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.SalesGridView);
            this.SalesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(590, 348);
            this.SalesGroupBox.TabIndex = 1;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Sales";
            // 
            // SalesGridView
            // 
            this.SalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleIDColumn,
            this.TimeColumn,
            this.SalesmanColumn,
            this.TotalBillColumn,
            this.ProductsColumn});
            this.SalesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGridView.Location = new System.Drawing.Point(3, 16);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.Size = new System.Drawing.Size(584, 329);
            this.SalesGridView.TabIndex = 0;
            this.SalesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellContentClick);
            // 
            // SaleIDColumn
            // 
            this.SaleIDColumn.HeaderText = "ID";
            this.SaleIDColumn.Name = "SaleIDColumn";
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            // 
            // SalesmanColumn
            // 
            this.SalesmanColumn.HeaderText = "Salesman";
            this.SalesmanColumn.Name = "SalesmanColumn";
            // 
            // TotalBillColumn
            // 
            this.TotalBillColumn.HeaderText = "Total Bill";
            this.TotalBillColumn.Name = "TotalBillColumn";
            // 
            // ProductsColumn
            // 
            this.ProductsColumn.HeaderText = "Products";
            this.ProductsColumn.Name = "ProductsColumn";
            this.ProductsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ViewAllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 372);
            this.Controls.Add(this.SalesGroupBox);
            this.Name = "ViewAllSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewAllSales";
            this.Load += new System.EventHandler(this.ViewAllSales_Load);
            this.SalesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBillColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ProductsColumn;
    }
}