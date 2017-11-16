using LibraryApp.Entities;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Repositories
{
    public class BookRepository
    {
        BookContext BookContext;

        public BookRepository(BookContext bookContext)
        {
            BookContext = bookContext;
        }

        public List<Book> GetAuthorList()
        {
            return BookContext.Books.Where(x => x.Country.Equals("Uk")).ToList();
        }
    }
}
