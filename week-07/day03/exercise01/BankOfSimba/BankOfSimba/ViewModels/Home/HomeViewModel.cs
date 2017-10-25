using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<BankAccount> accounts = new List<BankAccount>
        {
            new BankAccount("Simba", 20000, AnimalType.Lion, true, true),
            new BankAccount("Zumba", 5000, AnimalType.Monkey, false, true),
            new BankAccount("Pimpa", 6000, AnimalType.Snake, false, true),
            new BankAccount("Limba", 4000, AnimalType.Giraffe, false, true),
            new BankAccount("Zordon", 10000, AnimalType.Lion, false, false)
        };
    }  
}