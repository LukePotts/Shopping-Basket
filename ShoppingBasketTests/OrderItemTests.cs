using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Tests
{
    [TestClass()]
    public class OrderItemTests
    {
        [TestMethod()]
        public void AddItemsTest()
        {
            string TestProductName = "TestProduct";
            int TestQuantity = 2;
            int TestAddQuantity = 3;

            int ExpectedResult = TestQuantity + TestAddQuantity;

            ShoppingBasket.Instance.AddProduct(TestProductName, 0, TestQuantity);
            OrderItem TestItem = ShoppingBasket.Instance.GetOrderItemByName(TestProductName);
            TestItem.AddItems(TestAddQuantity);

            int ActualResult = TestItem.Quantity;
                      
            Assert.AreEqual(ExpectedResult,ActualResult);
        }
        [TestMethod()]
        public void SubtractItemsTest()
        {
            string TestProductName = "TestProduct2";
            int TestQuantity = 5;
            int TestTakeQuantity = 3;

            int ExpectedResult = TestQuantity - TestTakeQuantity;

            ShoppingBasket.Instance.AddProduct(TestProductName, 0, TestQuantity);
            OrderItem TestItem = ShoppingBasket.Instance.GetOrderItemByName(TestProductName);
            TestItem.RemoveItems(TestTakeQuantity);

            int ActualResult = TestItem.Quantity;

            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}