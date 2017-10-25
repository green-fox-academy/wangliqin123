using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string MoneyType { get; set; } = "Zebra";
        public bool IsKing { get; set; }

        public BankAccount(string name, double balance, string animaltype, bool isKing)
        {
            Name = name;
            Balance = balance;
            AnimalType = animaltype;
            IsKing = isKing;
        }
    }
    

    public enum AnimalType
    {
        Lion
    }
}