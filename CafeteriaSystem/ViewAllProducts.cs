using System;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class ViewAllProducts : Form
    {
        public ViewAllProducts()
        {
            InitializeComponent();
        }

        private void ViewAllProducts_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            ProductCategoryComboBox.Items.Add("All Categories");

            foreach (Details CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(CategoryDetail.Name);
            }

            ProductCategoryComboBox.SelectedIndex = 0;
        }

        private void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductsGridView.Rows.Clear();

            if (ProductCategoryComboBox.SelectedIndex == 0)
            {
                DataAccess _DataAccess = new DataAccess();

                foreach (Details ProductDetail in _DataAccess.RetreiveAllProducts())
                {
                    ProductsGridView.Rows.Add(ProductDetail.ID, ProductDetail.Name, ProductDetail.Price, ProductDetail.Category, ProductDetail.Description, ProductDetail.Picture);
                }
            }
            else if (ProductCategoryComboBox.SelectedIndex > 0)
            {
                string CategoryName = ProductCategoryComboBox.SelectedItem.ToString();

                DataAccess _DataAccess = new DataAccess();

                int CategoryID = _DataAccess.ReturnCategoryID(CategoryName);

                foreach (Details ProductDetail in _DataAccess.RetreiveProductsFromCategory(CategoryID))
                {
                    ProductsGridView.Rows.Add(ProductDetail.ID, ProductDetail.Name, ProductDetail.Price, CategoryName, ProductDetail.Description, ProductDetail.Picture);
                }
            }
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteProductColumn")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product\nfrom Database", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value);

                        DataAccess _DataAccess = new DataAccess();

                        if (_DataAccess.DeleteProduct(ProductID))
                        {
                            ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        }
                        else if (!_DataAccess.DeleteProduct(ProductID))
                        {
                            MessageBox.Show("Product Not Deleted");
                        }
                    }
                }
                else if (ProductsGridView.Columns[e.ColumnIndex].Name == "EditProductColumn")
                {
                    int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value);

                    string ProductName = ProductsGridView.Rows[e.RowIndex].Cells["ProductNameColumn"].Value.ToString();

                    decimal ProductPrice = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["ProductPriceColumn"].Value.ToString());

                    string ProductCategory = ProductsGridView.Rows[e.RowIndex].Cells["ProductCategoryColumn"].Value.ToString();

                    string ProductDescription = ProductsGridView.Rows[e.RowIndex].Cells["ProductDescriptionColumn"].Value.ToString();

                    byte[] ProductPicture = (byte[])ProductsGridView.Rows[e.RowIndex].Cells["ProductImageColumn"].Value;

                    UpdateProucts UpdateProductForm = new UpdateProucts(ProductID, ProductName, ProductPrice, ProductCategory, ProductDescription, ProductPicture);

                    if (UpdateProductForm.ShowDialog() == DialogResult.OK)
                    {
                        DataAccess _DataAccess = new DataAccess();

                        Details UpdatedProductDetail = _DataAccess.RetreiveProductDetails(ProductID);

                        ProductsGridView.Rows[e.RowIndex].Cells["ProductNameColumn"].Value = UpdatedProductDetail.Name;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductPriceColumn"].Value = UpdatedProductDetail.Price;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductCategoryColumn"].Value = UpdatedProductDetail.Category;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductDescriptionColumn"].Value = UpdatedProductDetail.Description;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductImageColumn"].Value = UpdatedProductDetail.Picture;
                    }
                }
            }
        }
    }
}
