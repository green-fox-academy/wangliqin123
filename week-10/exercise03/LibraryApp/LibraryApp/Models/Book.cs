using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
