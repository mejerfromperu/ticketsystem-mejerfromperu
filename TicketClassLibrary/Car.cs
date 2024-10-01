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
        /// constructer med paremeter hvor vi bruger propsne fra base klasssen
        /// </summary>
        /// <param name="string licensPlate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate; 
            Date = date;                 
        }


        /// <summary>
        /// Metode til prisen som er fixed på 240
        /// </summary>
        /// <returns>prisen som er 240</returns>
        public override double Price(bool b = false)
        {
            if(b == true)
            {
                return 240 * 0.95;
            }

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
