using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<BankAccount> accounts { get; set; } = new List<BankAccount>();

        public BankAccount bankAccount1 { get; set; }  = new BankAccount("Simba", 2000, AnimalType.Lion, true, true);
        public BankAccount bankAccount2 { get; set; } = new BankAccount("Zumba", 5000, AnimalType.Monkey, false, true);
        public BankAccount bankAccount3 { get; set; } = new BankAccount("Pimpa", 34000, AnimalType.Snake, false, true);
        public BankAccount bankAccount4 { get; set; } = new BankAccount("Limba", 1000, AnimalType.Giraffe, false, true);
        public BankAccount bankAccount5 { get; set; } = new BankAccount("Zordon", 11000, AnimalType.Lion, false, false);
    }  
}