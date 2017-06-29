using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class ShoppingBasket
    {

        private static ShoppingBasket _Instance = null;
        private static readonly object padlock = new object();

        private ShoppingBasket() { }

        public static ShoppingBasket Instance
        {
            get
            {
                if(_Instance == null)
                {
                    lock (padlock)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new ShoppingBasket();
                        }
                    }
                }
                return _Instance;
            }
        }

        public void AddProduct(string ProductName , decimal LatestProductValue , int ProductQuantity)
        {
            if (IsProductInBasket(ProductName))
            {
                GetOrderItemByName(ProductName).AddItems(LatestProductValue,ProductQuantity);
            }
            else
            {
                OrderItem NewItem = new OrderItem(ProductName, LatestProductValue, ProductQuantity);
                OrderItems.Add(NewItem);
            }          
            UpdateBasketDetails();
        }

        public void AddProduct(string ProductName, decimal LatestProductValue)
        {
            {
                if (IsProductInBasket(ProductName))
                {
                    GetOrderItemByName(ProductName).AddItems(LatestProductValue,1);
                }
                else
                {
                    OrderItem NewItem = new OrderItem(ProductName, LatestProductValue);
                    OrderItems.Add(NewItem);
                }
                UpdateBasketDetails();
            }
        }

        public void RemoveProduct(string ProductName, int QuantityRemove)
        {
            if (IsProductInBasket(ProductName))
            {
                if (GetOrderItemByName(ProductName).Quantity - QuantityRemove <= 0)
                {
                    RemoveProduct(GetOrderItemByName(ProductName).ProductName);
                }
                else
                {
                    GetOrderItemByName(ProductName).RemoveItem();
                }
            }
                UpdateBasketDetails();
            }
            
        

        public void RemoveProduct(string ProductName)
        {
            if (IsProductInBasket(ProductName))
            {
                OrderItems.Remove(GetOrderItemByName(ProductName));
                UpdateBasketDetails();
            }            
        }

        public void ClearBasket()
        {
            OrderItems.Clear();
            UpdateBasketDetails();
        }

        public List<OrderItem> OrderItems = new List<OrderItem>();

        public int NumberOfProducts;

        public decimal BasketTotal;

        public int NumberOfItems;
        
        public decimal CurrentPrice(string ProductName)
        {
            return GetOrderItemByName(ProductName).LastestPrice;
        }
        
        public bool IsProductInBasket(string ProductName)
        {            
            bool Exists = false;
            foreach (OrderItem i in OrderItems)
            {
                if (i.ProductName == ProductName)
                {
                    Exists = true;
                }
            }
            return Exists;
        }

        private void SaveBasket()
        {
            UpdateBasketDetails();
        }
        public void UpdateBasketDetails()
        {

            NumberOfProducts = OrderItems.Count();

            BasketTotal = 0;

            NumberOfItems = 0;
                
            foreach (OrderItem i in OrderItems)
            {
                BasketTotal += i.TotalOrder;
            }

            foreach (OrderItem i in OrderItems)
            {
                NumberOfItems += i.Quantity;
            }
        }
        public OrderItem GetOrderItemByName(string ProductName)
        {
            return OrderItems.Where(x => x.ProductName.Equals(ProductName)).FirstOrDefault();
        }
        public bool ValidName(string Name)
        {
            if (Name.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidQuantity(int Quantity)
        {
            if (Quantity > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidPrice(decimal Price)
        {
            if (Price >= 0 && BitConverter.GetBytes(decimal.GetBits(Price)[3])[2] < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
