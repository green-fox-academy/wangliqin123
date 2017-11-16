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
            return BookContext.Books.Where(x => x.Country.Equals("UK")).ToList();
        }

        public void AddAuthor(string author, string city, string country)
        {
            var book = new Book()
            {
                Author = author,
                City = city,
                Country = country
            };
            BookContext.Books.Add(book);
            BookContext.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            Book deletedAuthor = BookContext.Books.FirstOrDefault(x => x.Id == id);
            BookContext.Books.Remove(deletedAuthor);
            BookContext.SaveChanges();
        }
    }
}
