using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    public class F16 : Aircraft
    {
        public F16()
        {
            this.type = "F16";
            this.maxAmmo = 8;
            this.baseDamage = 30;
            this.ammoStore = 0;
        }
    }
}
