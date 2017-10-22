using System;

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
            candyShop.Sell("Candy", 1);
            candyShop.PrintInfo();
            candyShop.Raise(5);
            candyShop.Sell("Lollipop", 1);
            candyShop.PrintInfo();
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            Console.ReadLine();
        }
    }
}