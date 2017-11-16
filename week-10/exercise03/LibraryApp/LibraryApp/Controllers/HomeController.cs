using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Services;

namespace LibraryApp.Controllers
{
    [Route("/book")]
    public class HomeController : Controller
    {
        BookService BookService;

        public HomeController(BookService bookService)
        {
            BookService = bookService;
        }

        [HttpGet]        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string author, string city, string country)
        {
            BookService.AddNewAuthor(author, city, country);
            return LocalRedirect("/book");          
        }

        [HttpPost]
        [Route("/book/{id}")]
        public IActionResult Delete(int id)
        {
            BookService.RemoveAuthor(id);
            return LocalRedirect("/book");
        }

        [HttpGet]
        [Route("/api/book")]
        public IActionResult BookListJson()
        {
            return Json(BookService.ReturnBookList());
        }
    }
}