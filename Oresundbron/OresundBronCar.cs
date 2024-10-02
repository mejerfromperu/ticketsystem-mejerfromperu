using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace Oresundbron
{
    public class OresundBronCar : Car
    {
        /// <summary>
        /// default constructer
        /// </summary>
        public OresundBronCar():base()
        {
            
        }

        public OresundBronCar(string lisenceplate, DateTime date) : base()
        {
            LicensePlate = lisenceplate;
            Date = date;
        }
        /// <summary>
        /// public metode som retunere prisen for at kører over øresundbroen
        /// </summary>
        /// <param name="b">bool så hvis man har brobizz skal man skarive true i parametet listen</param>
        /// <returns>retunere en double som er prisen</returns>
        public override double Price(bool b = false)
        {
            if(b)
            {
                return 161;
            }

            return 410;
        }

        /// <summary>
        /// public metode som retunere en string med køretøjs navn og bro
        /// </summary>
        /// <returns>retunere hvilket slags kørertøj det er og bro navn</returns>
        public override string VehicleName()
        {
            return "Oresund car";
        }

        /// <summary>
        /// tostring metode for at få skrevet propsne ud 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{{{nameof(LicensePlate)}={LicensePlate}, {nameof(Date)}={Date.ToString()}}}";
        }
    }
}
