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

        [TestMethod]
        public void Test_Buy_1_volumeOne_and_1_volumeTwo_price_should_be_190()
        {
            // arrange
            var target = new ShoppingCart();
            var order = new List<PotterSeries>
            {
                new PotterSeries { Volume = "One", Quantity = 1 },
                new PotterSeries { Volume = "Two", Quantity = 1 }
            };

            // act
            int actual = target.CheckOut(order);
            var expected = 190;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Buy_1_volumeOne_and_1_volumeTwo_and_1_volumeThree_price_should_be_270()
        {
            // arrange
            var target = new ShoppingCart();
            var order = new List<PotterSeries>
            {
                new PotterSeries { Volume = "One", Quantity = 1 },
                new PotterSeries { Volume = "Two", Quantity = 1 },
                new PotterSeries { Volume = "Three", Quantity = 1 }
            };

            // act
            int actual = target.CheckOut(order);
            var expected = 270;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
