using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Services;

namespace LibraryApp.Controllers
{
    public class ApiController : Controller
    {
        BookService BookService;

        public ApiController(BookService bookService)
        {
            BookService = bookService;
        }

        [HttpGet]
        [Route("/api/book")]
        public IActionResult BookListJson()
        {
            return Json(BookService.ReturnBookList());
        }
        
        [HttpPost]
        [Route("/api/book")]
        public IActionResult Add(string author, string city, string country)
        {
            BookService.AddNewAuthor(author, city, country);
            return Json(new { Response = "It's ok" });
        }
    }
}
