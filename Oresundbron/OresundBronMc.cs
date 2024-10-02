using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace Oresundbron
{
    public class OresundBronMc : MC
    {
        /// <summary>
        /// default Constructer
        /// </summary>
        public OresundBronMc():base()
        {
            
        }
        /// <summary>
        /// default constructer med parameter 
        /// </summary>
        /// <param name="lisenseplate">licensplate</param>
        /// <param name="date">dato parameter</param>
        public OresundBronMc(string lisenseplate, DateTime date):base()
        {
            LicensePlate = lisenseplate;
            Date = date;
        }
        /// <summary>
        /// public double metode som retunere prisen
        /// </summary>
        /// <param name="b">bool for brobizz</param>
        /// <returns>retunerer prisen </returns>
        public override double Price(bool b = false)
        {
            if (b)
            {
                return 73;
            }

            return  210;
        }

        /// <summary>
        /// Public metode som er blevet override til at retunere oresund Mc
        /// </summary>
        /// <returns>retunere oresund Mc</returns>
        public override string VehicleName()
        {
            return "Oresund MC";
        }
        /// <summary>
        /// tostring metode for at få skrevet probs ud
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{{{nameof(LicensePlate)}={LicensePlate}, {nameof(Date)}={Date.ToString()}}}";
        }
    }
}
