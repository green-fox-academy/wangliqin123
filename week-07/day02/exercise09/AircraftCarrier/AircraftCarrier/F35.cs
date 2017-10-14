using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            this.type = "F35";
            this.maxAmmo = 12;
            this.baseDamage = 50;
            this.ammoStore = 0;
        }
    }
}
