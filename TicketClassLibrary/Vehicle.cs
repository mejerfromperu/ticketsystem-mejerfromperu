using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// public abstract class vehicle hvor vi har 2 abstrakte metoder, er lavet for at bruge inheritance til de andre 2 klasser. 
    /// </summary>
    public abstract class Vehicle
    {
        private string _licensePlate;
        private DateTime _date;

        /// <summary>
        /// prop for at få i licensplate
        /// </summary>
        public virtual string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value == null || value.Length < 7)
                {
                    throw new ArgumentException("licenseplate most be more than 7 char long");
                }
                _licensePlate = value;
            }
        }
                

        /// <summary>
        /// prop for at få fat i datetime
        /// </summary>
        public virtual DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }



        /// <summary>
        /// public abstract metode som retunere en pris som så selv skal implementeres i sub klassen
        /// vi har tilføjet en bol i parameterlisten som gør det mulgit at tilføje tilbud
        /// </summary>
        /// <returns>retunere en double med prisen</returns>
        public abstract double Price(bool brobiss = false);

        /// <summary>
        /// public abstract metode som reuntere kørertøjets navn, men skal så selv implementere metoden i subklassen
        /// </summary>
        /// <returns>retunere en string med køretøj navn</returns>
        public abstract string VehicleName();


    }
}
