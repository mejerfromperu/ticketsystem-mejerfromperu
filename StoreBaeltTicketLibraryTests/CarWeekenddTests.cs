using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class CarWeekenddTests
    {


        [TestMethod()]
        public void PriceTestWeekendmedBrobizz()
        {

            // arange 
            CarWeekendd car = new CarWeekendd("AJSKWE23", new DateTime(2024, 10, 27));
            double expectedPrice = 240 - (240 * 0.20);
            expectedPrice = expectedPrice - (expectedPrice * 0.05);
            // aact

            double actprice = car.Price(brobizz: true);

            // assert
            Assert.AreEqual(expectedPrice, actprice, 0.01);
        }

        [TestMethod]
        public void PriceTestWeekendUdenBrobizz()
        {
            // Arrange
            CarWeekendd car = new CarWeekendd("1234567", new DateTime(2024, 10, 27)); // weekend
            double expectedPrice = 240 - (240 * 0.20); 

            // Act
            double actualPrice = car.Price(brobizz: false);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Price should reflect the weekend discount without Brobizz discount.");
        }
    }
}