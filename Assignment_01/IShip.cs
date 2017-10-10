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

namespace Assignment_01
{
    /// <summary>
    /// Interface used to define the ship
    /// </summary>
    public interface IShip
    {
        /// <summary>
        /// The basic method of all inherited ship types, used to get a description of the object.
        /// </summary>
        /// <returns></returns>
        string getShipDescription();

        /// <summary>
        /// The basic method of all inherited ship types, used to get a weight value of the object.
        /// </summary>
        /// <returns></returns>
        double getWeight();
    }
}
