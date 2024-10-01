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
    public class OresundBronMcTests
    {
        [TestMethod()]
        public void PriceTestWithbrobizz()
        {
            //Arange
            OresundBronMc car = new OresundBronMc();

            // act
            double expectedPrice = 73;
            // assert

            Assert.AreEqual(expectedPrice, car.Price(true));
        }

        [TestMethod()]
        public void PriceTestWithNObrobizz()
        {
            //Arange
            OresundBronMc car = new OresundBronMc();

            // act
            double expectedPrice = 210;
            // assert

            Assert.AreEqual(expectedPrice, car.Price(false));
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arange
            OresundBronMc car = new OresundBronMc();

            // act
            string expectedVehicle = "Oresund MC";
            // assert

            Assert.AreEqual(expectedVehicle, car.VehicleName());
        }
    }
}