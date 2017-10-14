using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        private double incomeMoney;
        private int sugarAmount;
        private int sugarPrice;
        private int candy;
        private int lollipop;

        private List<Sweets> sweets = new List<Sweets>();

        public CandyShop(int sugarAmount)
        {
            this.sugarPrice = 100;
            this.sugarAmount = sugarAmount;
        }

        public void CreateSweets(string type)
        {
            if (type == "Lollipop")
            {
                Sweets Lollipop = new Lollipop();
                lollipop++;
                sugarAmount -= Lollipop.SugarCommodity;
            }
            if (type == "Candy")
            {
                Sweets Candy = new Lollipop();
                candy++;
                sugarAmount -= Candy.SugarCommodity;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}$, Sugar: {3}gr",
                             lollipop, candy, incomeMoney, sugarAmount);
        }

        public void Sell(string type, int value)
        {
            if (type == "Lollipop")
            {
                for (int i = 0; i < sweets.Count; i++)
                {
                    if (sweets[i].GetTypeOfSweet() == "Lollipop")
                    {
                        lollipop -= value;
                        incomeMoney += sweets[i].Price;
                        sweets.RemoveAt(i);
                    }
                }
            }
            else if (type == "Candy")
            {
                for (int i = 0; i < sweets.Count; i++)
                {
                    if (sweets[i].GetTypeOfSweet() == "Candy")
                    {
                        candy -= value;
                        incomeMoney += sweets[i].Price;
                        sweets.RemoveAt(i);
                    }
                }             
            }
        }

        public void BuySugar(int boughtSugarAmount)
        {
            incomeMoney -= sugarPrice / 1000 * boughtSugarAmount;
            sugarAmount += boughtSugarAmount;            
        }

        public void Raise(int percentage)
        {
            foreach (Sweets sweet in sweets)
            {
                sweet.RaisePrice(percentage);
            }
        }
    }
}