using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Details Category in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(Category.Name);
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

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            /*THIS IS THE MAIN CODE FOR HASHING*/

                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);

                /*Array of Binary numbers that have been converted*/
                byte[] ProductPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                /*HASHING END HERE*/


            if (_DataAccess.AddNewProductToDatabase(ProductNameBox.Text, Convert.ToDecimal(ProductPriceBox.Text), _DataAccess.ReturnCategoryID(ProductCategoryComboBox.SelectedItem.ToString()), ProductDescriptionRBox.Text, ProductPicture))
            {
                MessageBox.Show("Product Added");
            }
            else MessageBox.Show("Product Not Added");
        }
    }
}
