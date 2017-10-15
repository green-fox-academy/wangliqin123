using System;
using System.Collections.Generic;

namespace TakeMeToThe
{
    public class CandyShop
    {
        private double incomeMoney;
        public int sugarAmount;
        public int sugarPrice;
        public int candies;
        public int lollipops;
        public List<Sweets> inventory = new List<Sweets>();

        public CandyShop(int sugarAmount)
        {
            this.sugarPrice = 100;
            this.sugarAmount = sugarAmount;    
        }

        public void CreateSweets(string type)
        {
            if (type == "Lollipop")
            {
                Lollipop lollipop = new Lollipop();
                inventory.Add(lollipop);
                sugarAmount -= lollipop.sugarCommodity;
                lollipops++;
            }
            if (type == "Candy")
            {
                Candy candy = new Candy();
                inventory.Add(candy);
                sugarAmount -= candy.sugarCommodity;
                candies++;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}$, Sugar: {3}gr",
                              candies, lollipops, incomeMoney, sugarAmount);
        }

        public void Sell(string type, int value)
        {
            if (type == "Lollipop")
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i].GetType().Name == "Lollipop")
                    {
                        inventory.Remove(inventory[i]);
                        incomeMoney += inventory[i].price;
                        lollipops -= value;
                    }
                }
            }
            else if (type == "Candy")
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    if (inventory[i].GetType().Name == "Candy")
                    {
                        inventory.Remove(inventory[i]);
                        incomeMoney += inventory[i].price;
                        candies -= value;
                    }
                }             
            }
        }

        public void Raise(double percentage)
        {
            foreach (Sweets sweet in inventory)
            {
                sweet.price = sweet.price * (1 + (percentage / 100));
            }
        }

        public void BuySugar(int sugarToBuyAmount)
        {
            sugarAmount += sugarToBuyAmount;
            incomeMoney -= sugarToBuyAmount * 0.1;               
        }
    }
}