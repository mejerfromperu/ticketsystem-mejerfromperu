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
    public class MCTests
    {
        [TestMethod()]
        public void MCTestConstructer()
        {

            //Arnge
            DateTime date = DateTime.Now;
            

            // aCt
            MC mc = new MC("11223322", date);

            // Assert vi bruger true fordi vi har med tid at gøre og der er en lille tidsforskell i hold til .Now så vi sørger abre for at tidsforskellen ikke er størrere end 1 sek
            Assert.AreEqual("11223322", mc.LicensePlate) ;
            Assert.IsTrue((mc.Date - date).TotalSeconds < 1);

        }

        [TestMethod()]
        public void PriceTest()
        {
            //Arnge 
            MC mc = new MC();

            // aCt

            // Assert
            Assert.AreEqual(125, mc.Price());
        }

        [TestMethod()]
        public void VehicleTest()
        {
            //Arnge
            MC mc = new MC() ;

            // aCt

            // Assert
            Assert.AreEqual("MC", mc.VehicleName());
        }
    }
}