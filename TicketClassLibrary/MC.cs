using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// public Klasse Mc som indeholder 2 props (lisensplate, og datetime) indeholder 2 metoder med pris og vehicle
    /// </summary>
    public class MC
    {
        /// <summary>
        /// default constructer
        /// </summary>
        public MC()
        {
            
        }

        /// <summary>
        /// default constructer med parameter
        /// </summary>
        /// <param name="licensPlate"></param>
        /// <param name="date"></param>
        public MC(string licensPlate, DateTime date)
        {
            _licensPlate = licensPlate;
            _date = date;
        }

        private string _licensPlate;
        private DateTime _date;

        /// <summary>
        /// prop for at kunne få fat i licenseplate
        /// </summary>
        public string LicensPlate
        {
            get { return _licensPlate; }
            set { _licensPlate = value; }
        }

        /// <summary>
        /// prop så man kan se hvornår objektet blev oprettet
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// public metode som retunere en double 
        /// </summary>
        /// <returns>retunere prisen </returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// public metode som retunere en string
        /// </summary>
        /// <returns>retunere MC</returns>
        public string Vehicle()
        {
            return "MC";
        }



    }
}
