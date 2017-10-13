using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class TakeMeTo
    {
        public static void Main(string[] args)
        {
            CandyShop candyShop = new CandyShop(300);
            candyShop.CreateSweets("Lollipop");
            candyShop.CreateSweets("Lollipop");
            candyShop.CreateSweets("Candy");
            candyShop.CreateSweets("Candy");
            candyShop.PrintInfo();
            // Should print out:
            // Invetory: 2 candies, 2 lollipops, Income: 0$, Sugar: 270gr
            candyShop.Sell("Candy", 1);
            candyShop.PrintInfo();
            //// Should print out:
            //// "Invetory: 1 candies, 2 lollipops, Income: 20$, Sugar: 270gr"
            candyShop.Raise(5);
            candyShop.Sell("Lollipop", 1);
            candyShop.PrintInfo();
            //// Should print out:
            //// "Invetory: 1 candies, 1 lollipops, Income: 30.5$, Sugar: 270gr"
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 5$, Sugar: 570gr"
            Console.ReadLine();
        }
    }
}