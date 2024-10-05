using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class RepositoryClassTests
    {
        [TestMethod()]
        public void repository_AddTicketTest()
        {
            //Arange
            CarWeekendd carWeekendd = new CarWeekendd();
            Car car = new Car();
            MC mc = new MC();
            IRepositoryClass repositoryClass = new RepositoryClass();
            // act
            repositoryClass.AddTicket(car);
            repositoryClass.AddTicket(mc);
            repositoryClass.AddTicket(carWeekendd);

            //assert

            Assert.AreEqual(3, repositoryClass.GetAll().Count);
        }
    }
}