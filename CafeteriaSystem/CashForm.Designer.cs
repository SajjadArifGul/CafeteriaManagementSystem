namespace CafeteriaSystem
{
    partial class CashForm
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
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.CashGivenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CashReturnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmCheckoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bill";
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Location = new System.Drawing.Point(99, 16);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(132, 20);
            this.TotalBillBox.TabIndex = 1;
            // 
            // CashGivenBox
            // 
            this.CashGivenBox.Location = new System.Drawing.Point(99, 42);
            this.CashGivenBox.Name = "CashGivenBox";
            this.CashGivenBox.Size = new System.Drawing.Size(132, 20);
            this.CashGivenBox.TabIndex = 3;
            this.CashGivenBox.TextChanged += new System.EventHandler(this.CashGivenBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cash Given";
            // 
            // CashReturnBox
            // 
            this.CashReturnBox.Location = new System.Drawing.Point(99, 68);
            this.CashReturnBox.Name = "CashReturnBox";
            this.CashReturnBox.Size = new System.Drawing.Size(132, 20);
            this.CashReturnBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cash Return";
            // 
            // ConfirmCheckoutButton
            // 
            this.ConfirmCheckoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmCheckoutButton.Location = new System.Drawing.Point(60, 104);
            this.ConfirmCheckoutButton.Name = "ConfirmCheckoutButton";
            this.ConfirmCheckoutButton.Size = new System.Drawing.Size(144, 23);
            this.ConfirmCheckoutButton.TabIndex = 6;
            this.ConfirmCheckoutButton.Text = "Confirm Checkout";
            this.ConfirmCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // CashForm
            // 
            this.AcceptButton = this.ConfirmCheckoutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 139);
            this.Controls.Add(this.ConfirmCheckoutButton);
            this.Controls.Add(this.CashReturnBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashGivenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmCheckoutButton;
        public System.Windows.Forms.TextBox TotalBillBox;
        public System.Windows.Forms.TextBox CashGivenBox;
        public System.Windows.Forms.TextBox CashReturnBox;
    }
}