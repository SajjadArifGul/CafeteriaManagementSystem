namespace CafeteriaSystem
{
    partial class AddCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.CategoryDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.CategoryPictureBox = new System.Windows.Forms.PictureBox();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Picture";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(126, 6);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(146, 20);
            this.CategoryNameBox.TabIndex = 3;
            // 
            // CategoryDescriptionRBox
            // 
            this.CategoryDescriptionRBox.Location = new System.Drawing.Point(126, 32);
            this.CategoryDescriptionRBox.Name = "CategoryDescriptionRBox";
            this.CategoryDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.CategoryDescriptionRBox.TabIndex = 4;
            this.CategoryDescriptionRBox.Text = "";
            // 
            // CategoryPictureBox
            // 
            this.CategoryPictureBox.Location = new System.Drawing.Point(126, 111);
            this.CategoryPictureBox.Name = "CategoryPictureBox";
            this.CategoryPictureBox.Size = new System.Drawing.Size(146, 102);
            this.CategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryPictureBox.TabIndex = 5;
            this.CategoryPictureBox.TabStop = false;
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(12, 140);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(85, 23);
            this.UploadPictureButton.TabIndex = 6;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddCategoryButton.Location = new System.Drawing.Point(71, 227);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(130, 23);
            this.AddCategoryButton.TabIndex = 7;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.CategoryPictureBox);
            this.Controls.Add(this.CategoryDescriptionRBox);
            this.Controls.Add(this.CategoryNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.RichTextBox CategoryDescriptionRBox;
        private System.Windows.Forms.PictureBox CategoryPictureBox;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.Button AddCategoryButton;
    }
}