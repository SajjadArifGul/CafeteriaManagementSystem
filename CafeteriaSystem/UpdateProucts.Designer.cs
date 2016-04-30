namespace CafeteriaSystem
{
    partial class UpdateProucts
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
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.ProductDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProductIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(126, 86);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(146, 21);
            this.ProductCategoryComboBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Product Category";
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Location = new System.Drawing.Point(126, 60);
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.Size = new System.Drawing.Size(146, 20);
            this.ProductPriceBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Product Price";
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateProductButton.Location = new System.Drawing.Point(142, 305);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(130, 23);
            this.UpdateProductButton.TabIndex = 27;
            this.UpdateProductButton.Text = "Update Product";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(12, 235);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(85, 23);
            this.UploadPictureButton.TabIndex = 26;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(126, 193);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(146, 102);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 25;
            this.ProductPictureBox.TabStop = false;
            // 
            // ProductDescriptionRBox
            // 
            this.ProductDescriptionRBox.Location = new System.Drawing.Point(126, 113);
            this.ProductDescriptionRBox.Name = "ProductDescriptionRBox";
            this.ProductDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.ProductDescriptionRBox.TabIndex = 24;
            this.ProductDescriptionRBox.Text = "";
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(126, 34);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(146, 20);
            this.ProductNameBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product Name";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(6, 305);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 23);
            this.CancelButton.TabIndex = 32;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProductIDBox
            // 
            this.ProductIDBox.Location = new System.Drawing.Point(126, 8);
            this.ProductIDBox.Name = "ProductIDBox";
            this.ProductIDBox.Size = new System.Drawing.Size(146, 20);
            this.ProductIDBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Product ID";
            // 
            // UpdateProucts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.ProductIDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.ProductDescriptionRBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProucts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Proucts";
            this.Load += new System.EventHandler(this.UpdateProucts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.RichTextBox ProductDescriptionRBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ProductIDBox;
        private System.Windows.Forms.Label label6;
    }
}