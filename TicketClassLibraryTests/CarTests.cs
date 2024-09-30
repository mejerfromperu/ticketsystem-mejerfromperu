using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // Arange
            Car car = new Car();

            // ACt
            double expectedPrice = 240;

            // ASsert
            Assert.AreEqual(expectedPrice, car.Price());
            
        }

        [TestMethod()]
        public void VehicleTest()
        {
            // Arange
            Car car = new Car();

            // ACt

            // Assert
            Assert.AreEqual("car", car.Vehicle().ToLower());
        }
    }
}