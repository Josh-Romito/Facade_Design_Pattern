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
    class withHoneycomb : ShipDecorator
    {
        //field to store armour value
        private double honeyArmour;

        /// <summary>
        /// Contructor, calling base and passing in the ship object. Sets Default armour value.
        /// </summary>
        /// <param name="ship"></param>
        public withHoneycomb(IShip ship) : base(ship)
        {
            honeyArmour = (0.8 * withSteel.steelWeight) + (0.8 * withNano.nanoWeight);
        }

        /// <summary>
        /// Custom override method for getWeight()
        /// </summary>
        /// <returns></returns>
        public override double getWeight()
        {
            return base.getWeight() + honeyArmour;
        }

        /// <summary>
        /// Custom override method for getShipDescription()
        /// </summary>
        /// <returns></returns>
        public override string getShipDescription()
        {
            return base.getShipDescription() + " + Honeycomb";
        }
    }
}
