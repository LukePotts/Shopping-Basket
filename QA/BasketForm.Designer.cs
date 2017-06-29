namespace QA
{
    partial class BasketForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.LatestPrice = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.LatestPriceLabel = new System.Windows.Forms.Label();
            this.BasketLabel = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.ListBox();
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearBasketButton = new System.Windows.Forms.Button();
            this.ItemNoLabel = new System.Windows.Forms.Label();
            this.NoItems = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.ProductNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(13, 14);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.Location = new System.Drawing.Point(16, 30);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(265, 20);
            this.ProductName.TabIndex = 1;
            this.ProductNameToolTip.SetToolTip(this.ProductName, "Enter a name for the product you are adding to the basket. This name must be two " +
        "or more characters in length.");
            this.ProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductName_KeyDown);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity.Location = new System.Drawing.Point(287, 30);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(120, 20);
            this.Quantity.TabIndex = 2;
            this.ProductNameToolTip.SetToolTip(this.Quantity, "Choose the quantity you wish to add to the basket. Set this to 0 of you wish to u" +
        "pdate the price without adding any more items.");
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LatestPrice
            // 
            this.LatestPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LatestPrice.Location = new System.Drawing.Point(413, 30);
            this.LatestPrice.Name = "LatestPrice";
            this.LatestPrice.Size = new System.Drawing.Size(107, 20);
            this.LatestPrice.TabIndex = 3;
            this.ProductNameToolTip.SetToolTip(this.LatestPrice, "Select the latest price for the product. enter the value with no currency symbol." +
        "");
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(526, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.ProductNameToolTip.SetToolTip(this.AddButton, "Add an item with the details entered in the boxes to the left.");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(287, 14);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // LatestPriceLabel
            // 
            this.LatestPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LatestPriceLabel.AutoSize = true;
            this.LatestPriceLabel.Location = new System.Drawing.Point(410, 14);
            this.LatestPriceLabel.Name = "LatestPriceLabel";
            this.LatestPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.LatestPriceLabel.TabIndex = 6;
            this.LatestPriceLabel.Text = "Latest Price";
            // 
            // BasketLabel
            // 
            this.BasketLabel.AutoSize = true;
            this.BasketLabel.Location = new System.Drawing.Point(16, 57);
            this.BasketLabel.Name = "BasketLabel";
            this.BasketLabel.Size = new System.Drawing.Size(40, 13);
            this.BasketLabel.TabIndex = 7;
            this.BasketLabel.Text = "Basket";
            // 
            // Basket
            // 
            this.Basket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Basket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Basket.FormattingEnabled = true;
            this.Basket.Location = new System.Drawing.Point(16, 73);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(504, 264);
            this.Basket.TabIndex = 12;
            this.ProductNameToolTip.SetToolTip(this.Basket, "List of all items currently in your basket, displaying name, quantity, price and " +
        "total.");
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAllButton.Location = new System.Drawing.Point(526, 73);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(75, 20);
            this.RemoveAllButton.TabIndex = 7;
            this.RemoveAllButton.Text = "Remove All";
            this.ProductNameToolTip.SetToolTip(this.RemoveAllButton, "Removes all items of the selected product in the basket.");
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Location = new System.Drawing.Point(526, 177);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 20);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.ProductNameToolTip.SetToolTip(this.EditButton, "Edit the details of the selected item in the basket.");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(526, 229);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 20);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.ProductNameToolTip.SetToolTip(this.SaveButton, "Save a receipt for the items in your basket.");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearBasketButton
            // 
            this.ClearBasketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBasketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBasketButton.Location = new System.Drawing.Point(526, 281);
            this.ClearBasketButton.Name = "ClearBasketButton";
            this.ClearBasketButton.Size = new System.Drawing.Size(75, 20);
            this.ClearBasketButton.TabIndex = 11;
            this.ClearBasketButton.Text = "Clear Basket";
            this.ProductNameToolTip.SetToolTip(this.ClearBasketButton, "Removes all items from the basket.");
            this.ClearBasketButton.UseVisualStyleBackColor = true;
            this.ClearBasketButton.Click += new System.EventHandler(this.ClearBasketButton_Click);
            // 
            // ItemNoLabel
            // 
            this.ItemNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemNoLabel.AutoSize = true;
            this.ItemNoLabel.Location = new System.Drawing.Point(16, 359);
            this.ItemNoLabel.Name = "ItemNoLabel";
            this.ItemNoLabel.Size = new System.Drawing.Size(49, 13);
            this.ItemNoLabel.TabIndex = 17;
            this.ItemNoLabel.Text = "No Items";
            // 
            // NoItems
            // 
            this.NoItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NoItems.Cursor = System.Windows.Forms.Cursors.No;
            this.NoItems.Location = new System.Drawing.Point(71, 356);
            this.NoItems.Name = "NoItems";
            this.NoItems.ReadOnly = true;
            this.NoItems.Size = new System.Drawing.Size(100, 20);
            this.NoItems.TabIndex = 4;
            this.ProductNameToolTip.SetToolTip(this.NoItems, "Shows the total number of items in your basket.");
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(526, 357);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 20);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ProductNameToolTip.SetToolTip(this.ExitButton, "Closes the basket.");
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.Cursor = System.Windows.Forms.Cursors.No;
            this.Total.Location = new System.Drawing.Point(420, 357);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 5;
            this.ProductNameToolTip.SetToolTip(this.Total, "Shows the total cost of al items in the basket.");
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(379, 360);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 21;
            this.TotalLabel.Text = "Total";
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.Location = new System.Drawing.Point(526, 125);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 20);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "Remove";
            this.ProductNameToolTip.SetToolTip(this.Remove, "Removes a single item of the selected product in the basket.");
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.NoItems);
            this.Controls.Add(this.ItemNoLabel);
            this.Controls.Add(this.ClearBasketButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.BasketLabel);
            this.Controls.Add(this.LatestPriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LatestPrice);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Basket Application";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.TextBox LatestPrice;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label LatestPriceLabel;
        private System.Windows.Forms.Label BasketLabel;
        private System.Windows.Forms.ListBox Basket;
        private System.Windows.Forms.Button RemoveAllButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearBasketButton;
        private System.Windows.Forms.Label ItemNoLabel;
        private System.Windows.Forms.TextBox NoItems;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.ToolTip ProductNameToolTip;
    }
}

