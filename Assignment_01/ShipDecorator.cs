using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    public abstract class ShipDecorator : IShip 
    {
        private IShip armouredShip;

        public ShipDecorator(IShip ship )
        {
            armouredShip = ship;
        }

        public virtual string getShipDescription()
        {
            return armouredShip.getShipDescription();
        }

        public virtual double getWeight()
        {
            return armouredShip.getWeight();
        }

    }
}
