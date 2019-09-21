using NUnit.Framework;
using SuperMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketTests
{
    [TestFixture]
    public class SupermarketTest
    {
        [Test]
        public void Checkout1()
        {
            List<string> items = new List<string> { "A" };

            Checkout<List<string>> c = new Checkout<List<string>>(items);

            Assert.AreEqual(50, c.Total());

            items.Add("A");
            items.Add("A");
            items.Add("A");
            items.Add("A");
            items.Add("A");
            items.Add("A");

            c = new Checkout<List<string>>(items);
            Assert.AreEqual(310, c.Total());

        }

        [Test]
        public void Checkout2()
        {
            List<string> items = new List<string> { "B" };

            Checkout<List<string>> c = new Checkout<List<string>>(items);

            Assert.AreEqual(30, c.Total());

            items.Add("B");
            items.Add("B");
            items.Add("B");
            items.Add("B");
            items.Add("B");
            items.Add("B");

            c = new Checkout<List<string>>(items);
            Assert.AreEqual(165, c.Total());

        }

        [Test]
        public void Checkout3()
        {
            List<string> items = new List<string> { "D", "A", "B", "A", "C", "B", "C", "B", "B", "A" };

            Checkout<List<string>> c = new Checkout<List<string>>(items);
            Assert.AreEqual(275, c.Total());

        }
    }
}
