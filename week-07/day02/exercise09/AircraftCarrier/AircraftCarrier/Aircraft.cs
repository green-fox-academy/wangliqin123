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
            int damage = baseDamage * ammoStore;
            ammoStore = 0;
            return damage;
        }

        public int Refill(int fillAmmo)
        {
            if (ammoStore + fillAmmo > maxAmmo)
            {
                ammoStore = maxAmmo;
                return fillAmmo - maxAmmo;
            }
            ammoStore += fillAmmo;
            return 0;
        }

        public void GetStatus(string type)
        {
            if (type == "F35")
            {
                Console.WriteLine("Type F35, Ammo: {0}, Base Damage: {1}, All Damage: {2}", ammoStore, baseDamage, Fight());
            }
            else if (type == "F16")
            {
                Console.WriteLine("Type F16, Ammo: {0}, Base Damage: {1}, All Damage: {2}", ammoStore, baseDamage, Fight());
            }
        }
    }  
}
