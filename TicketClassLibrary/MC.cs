﻿using System;
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
        /// <param name="licensPlate"></param>
        /// <param name="date"></param>
        public MC(string licensPlate, DateTime date)
        {
            LicensePlate = licensPlate;
            Date = date;
        }

        

        /// <summary>
        /// public metode som retunere en double 
        /// </summary>
        /// <returns>retunere prisen </returns>
        public override double Price()
        {
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

        
    }
}
