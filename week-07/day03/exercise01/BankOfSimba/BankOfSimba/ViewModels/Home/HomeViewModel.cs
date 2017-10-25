using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {

        public List<BankAccount> accounts { get; set; } = new List<BankAccount>();

        public BankAccount bankAccount1 { get; set; }  = new BankAccount("Simba", 2000, "Lion", true);
        public BankAccount bankAccount2 { get; set; } = new BankAccount("Zumba", 5000, "Lion", false);
        public BankAccount bankAccount3 { get; set; } = new BankAccount("Pimpa", 34000, "Lion", false);
        public BankAccount bankAccount4 { get; set; } = new BankAccount("Limba", 1000, "Lion", false);
        public BankAccount bankAccount5 { get; set; } = new BankAccount("Zordon", 11000, "Lion", false);

    }  
}
