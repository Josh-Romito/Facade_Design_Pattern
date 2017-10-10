using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class withSteel : ShipDecorator
    {
        public static double steelWeight;
    
        public withSteel(IShip ship) : base(ship)
        {
            steelWeight = 75;
        }


        public override double getWeight()
        {
            return base.getWeight() + steelWeight;
        }


        public override string getShipDescription()
        {
            return base.getShipDescription() + " + Steel";
        }
    }
}
