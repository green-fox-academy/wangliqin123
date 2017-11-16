using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Services;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        BookService BookService;

        public HomeController(BookService bookService)
        {
            BookService = bookService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/api/book")]
        public IActionResult BookListJson()
        {
            return Json(BookService.ReturnBookList());
        }
    }
}
