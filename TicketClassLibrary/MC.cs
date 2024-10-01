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
    public class MC : Vehicle
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
        /// <param name="licensPlate">lisenseplate</param>
        /// <param name="date">datetime</param>
        public MC(string licensPlate, DateTime date)
        {
            LicensePlate = licensPlate;
            Date = date;
        }

        

        /// <summary>
        /// public metode som retunere en double
        /// 
        /// </summary>
        /// <returns>retunere prisen </returns>
        public override double Price(bool b = false)
        {

            if (b == true)
            {
                return 240 * 0.95;
            }
            return 125;
        }

        /// <summary>
        /// public metode som retunere en string
        /// </summary>
        /// <returns>retunere MC</returns>
        public override string VehicleName()
        {
            return "MC";
        }
        /// <summary>
        /// Tosting metode
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{{{nameof(LicensePlate)}={LicensePlate}, {nameof(Date)}={Date.ToString()}}}";
        }
    }
}
