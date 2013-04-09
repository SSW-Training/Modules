using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSW.Training.Tests.Unit
{
    public class MyItem
    {
        public decimal UnitPrice { get; private set; }
        public decimal Discount { get; private set; }

        public MyItem(decimal unitPrice)
        {
            this.UnitPrice = unitPrice;
        }

        public MyItem(decimal unitPrice, decimal discount)
        {
            this.UnitPrice = unitPrice;
            this.Discount= discount;
        }
    }

    public class Utilities
    {
        // A business rule – it should be unit tested
        public decimal CalculateTotal(List<MyItem> items)
        {
            decimal total = 0.0M;
            foreach (MyItem i in items)
            {
                total += i.UnitPrice * (1 - i.Discount);
            }
            return total;
        }
    }

    [TestClass()]
    public class UtilitiesTests
    {

        [TestMethod()]
        public void CalculateTotalSimpleTest()
        {
            List<MyItem> items = new List<MyItem>();
            items.Add(new MyItem(12.50M));
            items.Add(new MyItem(4.75M));
            items.Add(new MyItem(9.05M));
            items.Add(new MyItem(6.55M));
            items.Add(new MyItem(20.12M));

            decimal expected = 52.97M;
            Utilities u = new Utilities();
            decimal actual = u.CalculateTotal(items);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalWithDiscountTest()
        {
            List<MyItem> items = new List<MyItem>();
            items.Add(new MyItem(12.50M, 0.1M));
            items.Add(new MyItem(4.75M));
            items.Add(new MyItem(9.05M));
            items.Add(new MyItem(6.55M));
            items.Add(new MyItem(20.12M));

            decimal expected = 51.72M;
            Utilities u = new Utilities();
            Assert.IsNotNull(u);

            decimal actual = u.CalculateTotal(items);
            Assert.AreEqual(expected, actual);
        }
    }

}
