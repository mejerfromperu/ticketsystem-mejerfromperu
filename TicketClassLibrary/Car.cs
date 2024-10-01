using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Klasse car som indeholder 2 props licensplate og date
    /// </summary>
    public class Car
    {

        private string _licensPlate;
        private DateTime _date; 

        public string LicensPlate
        {
            get { return _licensPlate; }
            set { _licensPlate = value; }
        }

        public DateTime Date
        { 
            get { return _date; } 
            set { _date = value; } 
        }

        /// <summary>
        /// Metode til prisen som er fixed på 240
        /// </summary>
        /// <returns>prisen som er 240</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// public metode som retunere en string om hvad køretøj det er
        /// </summary>
        /// <returns>retunere "car"</returns>
        public string Vehicle()
        {
            return "Car";
        }



    }
}
