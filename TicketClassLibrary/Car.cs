﻿using System;
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
        public Car(string licensPlate, DateTime date)
        {
            _licensPlate = licensPlate;
            _date = date;

        }

        private string _licensPlate;
        private DateTime _date;

        
        /// <summary>
        /// prop for at få i licensplate
        /// </summary>
        public string LicensPlate
        {
            get { return _licensPlate; }
            set { _licensPlate = value; }
        }

        /// <summary>
        /// prop for at få fat i datetime
        /// </summary>
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
