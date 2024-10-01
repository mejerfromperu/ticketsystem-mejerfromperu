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
    public class Car : Vehicle
    {

        /// <summary>
        /// default construckter
        /// </summary>
        public Car()
        {
            
        }

        /// <summary>
        /// constructer med paremeter
        /// </summary>
        /// <param name="string licensPlate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date)
        {
            _licensPlate = licensePlate; 
            _date = date;      
        }

        private string _licensPlate;
        private DateTime _date;

        /// <summary>
        /// prop for at få licenseplate og grunden til at vi overrider er for at få lov til at bruge classes egne instans felter
        /// </summary>
        public override string LicensePlate
        {
            get { return _licensPlate; }
            set { _licensPlate = value; }
        }

        /// <summary>
        /// prop for at få Date og grunden til at vi overrider er for at få lov til at bruge classes egne instans felter
        /// </summary>
        public override DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// Metode til prisen som er fixed på 240
        /// </summary>
        /// <returns>prisen som er 240</returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// public metode som retunere en string om hvad køretøj det er
        /// </summary>
        /// <returns>retunere "car"</returns>
        public override string VehicleName()
        {
            return "Car";
        }



    }
}
