using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class CarWeekendd : Vehicle
    {
        private const double Weekendtilbud = 0.20;
        /// <summary>
        /// Default constructer
        /// </summary>
        public CarWeekendd() :base()
        {
            
        }

        /// <summary>
        /// Default constructer med parameter
        /// </summary>
        /// <param name="lisenceplate">lisenceplate</param>
        /// <param name="date">date</param>
        public CarWeekendd(string lisenceplate, DateTime date)  
        {
            LicensePlate = lisenceplate;
            Date = date;
        }


        /// <summary>
        /// public metode som reuntere en double, dog tager denne metoder også weekend med, så hvis man kører over
        /// broen i weekenden så er der tilbud
        /// </summary>
        /// <param name="brobiss">hvis man har brobiss skal man skrive true i parameterlisen</param>
        /// <returns>retunere prisen</returns>
        public override double Price(bool brobizz = false)
        {
            Car car = new Car();
            double price =  car.Price(brobizz); // base prisen 

            // her bruger vi Date for at validere hvilken dag de kører over
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price -= price * Weekendtilbud; // pris i alt
            }

           

            return price; // retunereing 
        }

        /// <summary>
        /// kørertøj med tilbud
        /// </summary>
        /// <returns>navn på kørertøj</returns>
        public override string VehicleName()
        {
            return "Car (weekend tilbud)";
        }


    }
}
