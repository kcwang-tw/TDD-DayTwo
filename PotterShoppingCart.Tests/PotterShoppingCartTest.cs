using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Test_Buy_one_price_should_be_100()
        {
            // arrange
            var target = new ShoppingCart();
            var order = new List<PotterSeries>
            {
                new PotterSeries { Volume = "One", Quantity = 1 }
            };

            // act
            int actual = target.CheckOut(order);
            var expected = 100;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
