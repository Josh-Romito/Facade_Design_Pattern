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
    /// Decorator class, inherited from the abstract ShipDecorator.
    /// </summary>
    class withSteel : ShipDecorator
    {
        //public static field to hold armour value - made static so we can access the value from honeyArmour in order to set armour based off previous armour values
        public static double steelWeight;

        /// <summary>
        /// Contructor, calling base and passing in the ship object. Sets Default armour value.
        /// </summary>
        /// <param name="ship"></param>
        public withSteel(IShip ship) : base(ship)
        {
            steelWeight = 75;
        }

        /// <summary>
        /// Custom override method for getWeight()
        /// </summary>
        /// <returns></returns>
        public override double getWeight()
        {
            return base.getWeight() + steelWeight;
        }

        /// <summary>
        /// Custom override method for getShipDescription()
        /// </summary>
        /// <returns></returns>
        public override string getShipDescription()
        {
            return base.getShipDescription() + " + Steel";
        }
    }
}
