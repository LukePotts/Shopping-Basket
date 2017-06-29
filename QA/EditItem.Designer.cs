namespace QA
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.LatestPriceLabel = new System.Windows.Forms.Label();
            this.LatestPrice = new System.Windows.Forms.TextBox();
            this.CancelUpdateButton = new System.Windows.Forms.Button();
            this.ConfitmUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(13, 15);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(113, 12);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(138, 20);
            this.ProductName.TabIndex = 1;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(113, 64);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(138, 20);
            this.Quantity.TabIndex = 2;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(13, 67);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Quantity";
            // 
            // LatestPriceLabel
            // 
            this.LatestPriceLabel.AutoSize = true;
            this.LatestPriceLabel.Location = new System.Drawing.Point(13, 119);
            this.LatestPriceLabel.Name = "LatestPriceLabel";
            this.LatestPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.LatestPriceLabel.TabIndex = 8;
            this.LatestPriceLabel.Text = "Latest Price";
            // 
            // LatestPrice
            // 
            this.LatestPrice.Location = new System.Drawing.Point(113, 116);
            this.LatestPrice.Name = "LatestPrice";
            this.LatestPrice.Size = new System.Drawing.Size(138, 20);
            this.LatestPrice.TabIndex = 3;
            // 
            // CancelUpdateButton
            // 
            this.CancelUpdateButton.Location = new System.Drawing.Point(176, 174);
            this.CancelUpdateButton.Name = "CancelUpdateButton";
            this.CancelUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.CancelUpdateButton.TabIndex = 5;
            this.CancelUpdateButton.Text = "Cancel";
            this.CancelUpdateButton.UseVisualStyleBackColor = true;
            this.CancelUpdateButton.Click += new System.EventHandler(this.CancelUpdateButton_Click);
            // 
            // ConfitmUpdateButton
            // 
            this.ConfitmUpdateButton.Location = new System.Drawing.Point(16, 174);
            this.ConfitmUpdateButton.Name = "ConfitmUpdateButton";
            this.ConfitmUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.ConfitmUpdateButton.TabIndex = 4;
            this.ConfitmUpdateButton.Text = "Ok";
            this.ConfitmUpdateButton.UseVisualStyleBackColor = true;
            this.ConfitmUpdateButton.Click += new System.EventHandler(this.ConfitmUpdateButton_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 209);
            this.Controls.Add(this.ConfitmUpdateButton);
            this.Controls.Add(this.CancelUpdateButton);
            this.Controls.Add(this.LatestPrice);
            this.Controls.Add(this.LatestPriceLabel);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label LatestPriceLabel;
        private System.Windows.Forms.TextBox LatestPrice;
        private System.Windows.Forms.Button CancelUpdateButton;
        private System.Windows.Forms.Button ConfitmUpdateButton;
    }
}