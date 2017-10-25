using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {
        public BankAccount BankAccount { get; set; } = new BankAccount();
    }
}
