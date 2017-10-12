using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        protected readonly object CANDY;
        internal static readonly object LOLLIPOP;
        protected double incomeMoney;
        protected int sugarAmount;
        protected int sugarPrice;
        Sweets sweets = new Sweets();
        Candy candy = new Candy();

        List<object> candies = new List<object>();

        public CandyShop(int sugarAmount)
        {
            this.sugarPrice = 100;
            this.sugarAmount = sugarAmount;

        }

        public void CreateSweets(object CANDY)
        {
            incomeMoney = incomeMoney - candy.price;
            sugarAmount = sugarAmount - candy.sugarCommodity;
            candies.Add();
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
