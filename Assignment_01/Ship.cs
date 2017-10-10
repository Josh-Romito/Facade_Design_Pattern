using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_01
{
    class Ship : IShip
    {
        public string getShipDescription()
        {
            return "Ship";
        }

        public double getWeight()
        {
            return 10;
        }
    }
}
