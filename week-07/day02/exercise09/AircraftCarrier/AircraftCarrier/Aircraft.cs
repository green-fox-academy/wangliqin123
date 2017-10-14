using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    public class Aircraft
    {
        protected string type;
        protected int maxAmmo;
        protected int baseDamage;
        protected int ammoStore;
        protected int damage;

        public new string GetType()
        {
            return type;
        }

        public int Fight()
        {
            ammoStore -= ammoStore;
            return damage = baseDamage * ammoStore;
        }

        public int Refill(int number)
        {

        }
    }  
}
