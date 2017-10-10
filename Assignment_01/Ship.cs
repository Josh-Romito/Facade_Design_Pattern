/**************************
 * Josh Romito
 * CP_330 - Assignment 01
 * October 10, 2017
 * ***********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_01
{
    /// <summary>
    /// Base Ship Class - defines the base values for the default ship.
    /// </summary>
    class Ship : IShip
    {
        /// <summary>
        /// Base ship description.
        /// </summary>
        /// <returns></returns>
        public string getShipDescription()
        {
            return "Ship";
        }

        /// <summary>
        /// Baase ship weight.
        /// </summary>
        /// <returns></returns>
        public double getWeight()
        {
            return 10;
        }
    }
}
