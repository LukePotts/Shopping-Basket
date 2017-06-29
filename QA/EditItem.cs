using ShoppingBasket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class EditItem : Form
    {

        private ShoppingBasket.ShoppingBasket ThisBasket;
        OrderItem UpdatedItem;
        OrderItem OldItem;

        public EditItem(OrderItem Item)
        {
            InitializeComponent();
            UpdatedItem = Item;
            OldItem = Item;
            ThisBasket = ShoppingBasket.ShoppingBasket.Instance;
        }
        private void EditItem_Load(object sender, EventArgs e)
        {
            ProductName.Text = UpdatedItem.ProductName;
            Quantity.Text = Convert.ToString(UpdatedItem.Quantity);
            LatestPrice.Text = Convert.ToString(UpdatedItem.LastestPrice);
        }
        private void CancelUpdateButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void ConfitmUpdateButton_Click(object sender, EventArgs e)
        {            
            try
            {
                UpdatedItem.ProductName = ProductName.Text;
                UpdatedItem.Quantity = Convert.ToInt32(Quantity.Text);
                UpdatedItem.LastestPrice = Convert.ToDecimal(LatestPrice.Text);
                if (ThisBasket.ValidName(UpdatedItem.ProductName) && ThisBasket.ValidPrice(UpdatedItem.LastestPrice) && ThisBasket.ValidQuantity(UpdatedItem.Quantity))
                {
                    ThisBasket.RemoveProduct(OldItem.ProductName);
                    ThisBasket.AddProduct(UpdatedItem.ProductName, UpdatedItem.LastestPrice, UpdatedItem.Quantity);

                    ThisBasket.UpdateBasketDetails();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("One or more of the values is invalid.");
                }
            }
            catch
            {
                MessageBox.Show("One or more of the values is invalid.");
            }            
        }
    }
}
