using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class UpdateProucts : Form
    {
        int ProductID;
        string ProductName, ProductCategory, ProductDescription;
        decimal ProductPrice;
        byte[] ProductPicture;

        public UpdateProucts(int GivenProductID, string GivenProductName, decimal GivenProductPrice, string GivenProductCategory, string GivenProductDescription, byte[] GivenProductPicture)
        {
            InitializeComponent();

            ProductID = GivenProductID;
            ProductName = GivenProductName;
            ProductPrice = GivenProductPrice;
            ProductCategory = GivenProductCategory;
            ProductDescription = GivenProductDescription;
            ProductPicture = GivenProductPicture;
        }

        private void UpdateProucts_Load(object sender, EventArgs e)
        {
            ProductIDBox.Text = ProductID.ToString();
            ProductNameBox.Text = ProductName;
            ProductPriceBox.Text = ProductPrice.ToString();
            ProductCategoryComboBox.Text = ProductCategory;
            ProductDescriptionRBox.Text = ProductDescription;
            MemoryStream ms = new MemoryStream(ProductPicture);
            ProductPictureBox.Image = Image.FromStream(ms);

            DataAccess _DataAccess = new DataAccess();

            foreach (Details CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(CategoryDetail.Name);
            }
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            /*selecting image*/

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*if picture selected then load in the picture box*/
                ProductPictureBox.Load(ofd.FileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Update this Product?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess _DataAccess = new DataAccess();

                int ProductID = Convert.ToInt32(ProductIDBox.Text);

                string ProductName = ProductNameBox.Text;

                decimal ProductPrice = Convert.ToDecimal(ProductPriceBox.Text);

                string ProductCategory = ProductCategoryComboBox.Text;

                int ProductCategoryID = _DataAccess.ReturnCategoryID(ProductCategory);

                string ProductDescription = ProductDescriptionRBox.Text;

                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);

                /*Array of Binary numbers that have been converted*/
                byte[] MyProductPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                if (_DataAccess.UpdateProduct(ProductID, ProductName, ProductPrice, ProductCategoryID, ProductDescription, MyProductPicture))
                {
                    this.Close();
                }
                else MessageBox.Show("Poduct Not Updated", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
