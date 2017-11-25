using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieApp.Models
{
    public class Food
    {
        [Key]
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Calorie { get; set; }
    }
}
