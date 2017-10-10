using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public class withNano : ShipDecorator
    {
        public static double nanoWeight;

        public withNano(IShip ship) : base(ship)
        {
            nanoWeight = 1;
        }

        public override double getWeight()
        {
            return base.getWeight() + nanoWeight;
        }

        public override string getShipDescription()
        {
            return base.getShipDescription() + " + Nano";
        }
    }
}
