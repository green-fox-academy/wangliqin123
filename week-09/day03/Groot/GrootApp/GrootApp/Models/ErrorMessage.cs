using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrootApp.Models
{
    public class ErrorMessage :IGuardian
    {
        public string Error { get; set; } = "I am Groot!";
    }
}
