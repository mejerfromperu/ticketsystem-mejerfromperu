using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oresundbron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbron.Tests
{
    [TestClass()]
    public class OresundBronCarTests
    {
        

        [TestMethod()]
        public void PriceTestWithbrobizz()
        {
            //Arange
            OresundBronCar car = new OresundBronCar();

            // act
            double expectedPrice = 161;
            // assert

            Assert.AreEqual(expectedPrice, car.Price(true));
        }

        [TestMethod()]
        public void PriceTestWithNObrobizz()
        {
            //Arange
            OresundBronCar car = new OresundBronCar();

            // act
            double expectedPrice = 410;
            // assert

            Assert.AreEqual(expectedPrice, car.Price(false));
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arange
            OresundBronCar car = new OresundBronCar();

            // act
            string expectedVehicle = "Oresund car";
            // assert

            Assert.AreEqual(expectedVehicle, car.VehicleName());
        }


    }
}