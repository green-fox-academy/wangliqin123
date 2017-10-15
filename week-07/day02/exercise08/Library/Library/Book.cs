using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string author;
        public string title;
        public int releaseYear;

        public Book()
        {
            this.author = "Douglas Adams";
            this.title = "The Hitchhiker's Guide to the Galaxy";
            this.releaseYear = 1979;
        }
    }
}
