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
        /// <summary>
        /// prop for at få i licensplate
        /// </summary>
        public virtual string LicensePlate { get; set; }

        /// <summary>
        /// prop for at få fat i datetime
        /// </summary>
        public virtual DateTime Date { get; set; }



        /// <summary>
        /// public abstract metode som retunere en pris som så selv skal implementeres i sub klassen
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// public abstract metode som reuntere kørertøjets navn, men skal så selv implementere metoden i subklassen
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleName();
    }
}
