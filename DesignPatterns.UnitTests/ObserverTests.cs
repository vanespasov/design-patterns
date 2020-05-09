using System;
using DesignPatterns.Behavioral.Observer.RealScenario;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.unit_tests
{
    [TestClass]
    public class ObserverUnitTests
    {
        [TestMethod]
        public void Observer_RealScenario_Notify_Two_Investors_When_Price_Changes()
        {
            // arrange
            double price = 120.00;
            double newPrice = 120.10;
            var ibm = new Stock("IBM", price);
            var investor1 = new Investor("Sorros");
            var investor2 = new Investor("Berkshire");
            ibm.Attach(investor1);
            ibm.Attach(investor2);
            
            // act
            ibm.Price = newPrice;

            //assert
            Assert.AreEqual(newPrice, investor1.Stock.Price);
            Assert.AreEqual("IBM", investor1.Stock.Symbol);

            Assert.AreEqual(newPrice, investor2.Stock.Price);
            Assert.AreEqual("IBM", investor2.Stock.Symbol);
        }
    }
}
