using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
            Assert.AreEqual("car", car.VehicleName().ToLower());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "License plate must be at least 7 characters long.")]
        public void SetTestForLengtOfLisencePlateTrueFail()
        {
            // Arrange
            Car car = new Car();

            // Act
            car.LicensePlate = "123456"; // Burde give fejl
        }

        [TestMethod()]
        public void SetTestForLengtOfLisencePlateTrue()
        {
            // Arrange
            Car car = new Car();

            // Act
            car.LicensePlate = "1234567"; // den er højere end 6 så den burde give grønt lys

            // Assert
            Assert.AreEqual("1234567", car.LicensePlate);
        }


        [TestMethod()]
        public void CarTEstForBroBiss()
        {
            // Arange
            Car car = new Car();

            // ACt
            double expectedprice = 228;

            // Assert
            Assert.AreEqual((double)expectedprice, car.Price(true));

        }
    }

}