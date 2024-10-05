using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// public class Repositoryc´lass som indeholder 3 metoder AddTicket, GetAll, GetTicketsByLicensePlate og en statisk liste tickets.
    /// </summary>
    public class RepositoryClass : IRepositoryClass
    {
        /// <summary>
        /// public static list
        /// </summary>
        public static List<Vehicle> tickets = new List<Vehicle>();

        /// <summary>
        /// public metode så vi kan adde tickets til vores static liste
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddTicket(Vehicle vehicle)
        {
            tickets.Add(vehicle);
        }

        /// <summary>
        /// public metode som retunere alle tickets i en ny liste
        /// </summary>
        /// <returns>retunere alle items i tickets i en ny liste</returns>
        public List<Vehicle> GetAll()
        {
            return new List<Vehicle>(tickets);
        }

        /// <summary>
        /// retunere alle de tickets med den samme lisenceplate
        /// </summary>
        /// <param name="licensePlate">den valgte lisenplate som man vil tjekke for</param>
        /// <returns>retunere alle de fundne tickets</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {

            return tickets.FindAll(ticket => ticket.LicensePlate == licensePlate);
        }

    }
}
