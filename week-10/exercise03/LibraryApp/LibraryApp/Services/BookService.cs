using LibraryApp.Models;
using LibraryApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class BookService
    {
        BookRepository BookRepository;

        public BookService(BookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }

        public List<Book> ReturnBookList()
        {
            return BookRepository.GetAuthorList();
        }
    }
}
