using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; } = "Simba";
        public double Balance { get; set; } = 2000;
        public string AnimalType { get; set; } = "Lion";
    }

    //public enum AnimalType
    //{
    //    Lion
    //}
}