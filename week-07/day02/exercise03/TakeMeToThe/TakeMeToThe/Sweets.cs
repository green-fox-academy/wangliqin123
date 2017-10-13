using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class Sweets
    {
        protected int price;
        protected int sugarCommodity;
        protected string type;

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int SugarCommodity
        {
            get
            {
                return sugarCommodity;
            }
            set
            {
                sugarCommodity = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public void RaisePrice(int percentage)
        {
            price = price * percentage;
        }
    }
}