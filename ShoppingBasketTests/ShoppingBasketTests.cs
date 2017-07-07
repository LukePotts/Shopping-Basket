using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingBasket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShoppingBasket.Tests
{
    [TestClass()]
    public class ShoppingBasketTests
    {
        [TestMethod()]
        public void SaveBasketTest1()
        {
            ShoppingBasket.Instance.ClearBasket();
            string ProductName = "TestProduct";
            decimal LatestPrice = 1 ;
            int ProductQuantity = 1;
            ShoppingBasket.Instance.AddProduct(ProductName, LatestPrice,ProductQuantity);
            string FileName = "TestFile";            
            Assert.IsTrue(ShoppingBasket.Instance.SaveBasket(FileName));
        }
        [TestMethod()]
        public void SaveBasketTest2()
        {
            ShoppingBasket.Instance.ClearBasket();
            string ProductName = "Test";
            decimal LatestPrice = 1;
            int ProductQuantity = 1;
            ShoppingBasket.Instance.AddProduct(ProductName, LatestPrice, ProductQuantity);
            string FileName = "TestFile2";
            ShoppingBasket.Instance.SaveBasket(FileName);
            string ActualFileText = File.ReadAllText("C:\\Users\\PottsL\\Documents\\" + FileName + ".txt");
            string ExpectedFileText = ShoppingBasket.Instance.ConvertBasketToReceiptFormat();
            Assert.AreEqual(ExpectedFileText,ActualFileText);
        }
    }
}