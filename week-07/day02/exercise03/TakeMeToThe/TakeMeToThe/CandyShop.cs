using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        internal static readonly object CANDY;
        internal static readonly object LOLLIPOP;
        protected double incomeMoney;
        protected int sugarAmount;
        protected int sugarPrice;
        Sweets sweets = new Sweets();

        public CandyShop(int sugarAmount)
        {
            this.sugarPrice = 100;
            this.sugarAmount = sugarAmount;
        }

        internal void CreateSweets(object CANDY)
        {
            throw new NotImplementedException();
        }

        internal void PrintInfo()
        {
            throw new NotImplementedException();
        }

        internal void Sell(object cANDY, int v)
        {
            throw new NotImplementedException();
        }

        public void Raise(int percentage)
        {
            sweets.price = sweets.price * percentage;
        }

        public void BuySugar(int boughtSugarAmount)
        {
            incomeMoney -= sugarPrice / 1000 * boughtSugarAmount;
            sugarAmount += boughtSugarAmount;            
        }
    }
}
