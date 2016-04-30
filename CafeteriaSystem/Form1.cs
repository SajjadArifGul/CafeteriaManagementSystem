using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard(int UserID)
        {
            InitializeComponent();

            SalesmanID = UserID;

            DataAccess _DataAccess = new DataAccess();

            Username = _DataAccess.ReturnUserName(UserID);
        }

        public int SalesmanID = 0;
        public string Username = string.Empty;

        public int RowIndex = 0;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UserNameIDMenuLabel.Text = Username + " (" + SalesmanID + ")";

            DataAccess _DataAccess = new DataAccess();

            ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

            foreach (Details Category in AllCategories)
            {
                Button btn = new Button();
                btn.Text = Category.Name;
                btn.Size = new System.Drawing.Size(80, 80);
                btn.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Category.Picture);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

                btn.Tag = Category.ID;

                CategoriesFlowPanel.Controls.Add(btn);

                btn.Click += CategoryButtonClick;
            }
        }

        void CategoryButtonClick(object sender, EventArgs e)
        {
            ProductsFlowPanel.Controls.Clear();

            Button btn = (Button)sender;

            int CategoryID = Convert.ToInt32(btn.Tag);

            DataAccess _DataAccess = new DataAccess();

            foreach (Details Product in _DataAccess.RetreiveProductsFromCategory(CategoryID))
            {
                Button ProductButton = new Button();
                ProductButton.Text = Product.Name;
                ProductButton.Size = new System.Drawing.Size(80, 80);
                ProductButton.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Product.Picture);
                ProductButton.Image = Image.FromStream(ms);
                ProductButton.Image = new Bitmap(ProductButton.Image, ProductButton.Size);

                ProductButton.Tag = Product.ID;

                ProductsFlowPanel.Controls.Add(ProductButton);

                ProductButton.Click += ProductButton_Click;

                //ProductButton.MouseClick += ProductButton_MouseClick;
            }
        }

        void ProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            //for loweing one quantity. do this.. <---------------------
            switch (e.Button)
            {
                case MouseButtons.Right:
                    MessageBox.Show("Right Click");
                    break;
                case MouseButtons.Left:
                    MessageBox.Show("Left Click");
                    break;
            }
        }

        void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;

            DataAccess _DataAccess = new DataAccess();

            int ProductID = Convert.ToInt32(ProductButton.Tag);

            Details ProductDetails = _DataAccess.RetreiveProductDetails(ProductID);

            if (CheckProductAlreadyAdded(ProductID))
            {
                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value);
                decimal Price = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductPriceColumn"].Value);

                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value = Quantity;
                ProductsGridView.Rows[RowIndex].Cells["TotalPriceColumn"].Value = TotalPrice;

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
        }

        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ProductIDColumn"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory _AddCategory = new AddCategory();

            //Retreive CatgeoriesAgain to Show on CategoriesFlow Panel

            if (_AddCategory.ShowDialog() == DialogResult.OK)
            {
                CategoriesFlowPanel.Controls.Clear();

                DataAccess _DataAccess = new DataAccess();

                ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

                foreach (Details Category in AllCategories)
                {
                    Button btn = new Button();
                    btn.Text = Category.Name;
                    btn.Size = new System.Drawing.Size(80, 80);
                    btn.ForeColor = Color.White;

                    MemoryStream ms = new MemoryStream(Category.Picture);
                    btn.Image = Image.FromStream(ms);
                    btn.Image = new Bitmap(btn.Image, btn.Size);

                    btn.Tag = Category.ID;

                    CategoriesFlowPanel.Controls.Add(btn);

                    btn.Click += CategoryButtonClick;
                }
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct _AddProduct = new AddProduct();
            _AddProduct.ShowDialog();
        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllProducts().ShowDialog();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllSales().ShowDialog();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CashForm _CashForm = new CashForm();

            _CashForm.TotalBillBox.Text = TotalBillBox.Text;

            if (_CashForm.ShowDialog() == DialogResult.OK)
            {
                ArrayList ProductsList = new ArrayList();

                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    try
                    {
                        string ProductName = Row.Cells["ProductNameColumn"].Value.ToString();
                        decimal ProductPrice = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                        int ProductQuantity = Convert.ToInt32(Row.Cells["ProductQuantityColumn"].Value);
                        decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                        ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Quantity = ProductQuantity, Total = ProductTotal });
                    }
                    catch
                    {
                        //means Rows are ended
                    }
                }

                DataAccess _DataAccess = new DataAccess();

                if (_DataAccess.RecordASale(ProductsList, DateTime.Now, SalesmanID, Convert.ToDecimal(_CashForm.CashGivenBox.Text), Convert.ToDecimal(_CashForm.TotalBillBox.Text), Convert.ToDecimal(_CashForm.CashReturnBox.Text)))
                {
                    MessageBox.Show("Sale Added");
                }
                else MessageBox.Show("Sale Not Added");
            }
        }

        private void ProductsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["TotalPriceColumn"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(TotalBillBox.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        TotalBillBox.Text = CurrentTotalBill.ToString();
                    }
                }
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
