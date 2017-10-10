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
    /// Abstract decorator class - inherited from IShip interface.
    /// </summary>
    public abstract class ShipDecorator : IShip 
    {
        // private field of IShip
        private IShip armouredShip;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="ship"></param>
        public ShipDecorator(IShip ship )
        {
            armouredShip = ship;
        }

        /// <summary>
        /// Virtual method - used to define getShipDescription()
        /// </summary>
        /// <returns></returns>
        public virtual string getShipDescription()
        {
            return armouredShip.getShipDescription();
        }

        /// <summary>
        /// Virtual method - used to define getWeight()
        /// </summary>
        /// <returns></returns>
        public virtual double getWeight()
        {
            return armouredShip.getWeight();
        }
    }
}
