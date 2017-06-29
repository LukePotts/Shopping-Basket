using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class OrderItem
    {
        public OrderItem(string ThisProductName, decimal ThisLatestPrice)
        {
            ProductName = ThisProductName;
            LastestPrice = ThisLatestPrice;
            Quantity = 1;
            UpdateTotalOrder();
        }
        public OrderItem(string ThisProductName , decimal ThisLatestPrice, int ThisQuantity)
        {
            ProductName = ThisProductName;
            LastestPrice = ThisLatestPrice;
            Quantity = ThisQuantity;
            UpdateTotalOrder();
        }
        public string ProductName;
        public decimal LastestPrice;
        public int Quantity;
        public decimal TotalOrder;
        public void AddItems(decimal NewLatestPrice , int QuantityAdd)
        {
            LastestPrice = NewLatestPrice;
            Quantity += QuantityAdd;
            UpdateTotalOrder();
        }
        public void AddItems(int QuantityAdd)
        {
            Quantity += QuantityAdd;
            UpdateTotalOrder();
        }
        public void AddItem()
        {
            Quantity++;
            UpdateTotalOrder();
        }
        public void RemoveItems(int QuantityRemove)
        {
            Quantity -= QuantityRemove;
            UpdateTotalOrder();
        }
        public void RemoveItem()
        {
            Quantity--;
            UpdateTotalOrder();
        }        
        private void UpdateTotalOrder()
        {
            TotalOrder = LastestPrice * Quantity;
        }
    }
}
