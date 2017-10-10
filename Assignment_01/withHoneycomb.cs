using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class withHoneycomb : ShipDecorator
    {
        public static double honeyArmour;

        public withHoneycomb(IShip ship) : base(ship)
        {
            honeyArmour = (0.8 * withSteel.steelWeight) + (0.8 * withNano.nanoWeight);
        }

        public override double getWeight()
        {
            return base.getWeight() + honeyArmour;
        }

        public override string getShipDescription()
        {
            return base.getShipDescription() + " + Honeycomb";
        }
    }
}
