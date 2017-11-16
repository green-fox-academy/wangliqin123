using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Services;
using LibraryApp.Models;

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

        [Route("/book")]
        [HttpGet]        
        public IActionResult Index()
        {           
            return View(BookService.GetAllAuthor());
        }

        [Route("/book")]
        [HttpPost]
        public IActionResult Add(string author, string city, string country)
        {
            BookService.AddNewAuthor(author, city, country);
            return LocalRedirect("/book");          
        }

        [HttpPost]
        [Route("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            BookService.RemoveAuthor(id);
            return LocalRedirect("/book");
        }

        [Route("/{id}/update")]
        [HttpGet]
        public IActionResult Update([FromQuery]string Id)
        {
            int id = int.Parse(Id);
            var book = BookService.GetId(id);
            return View(book);
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            BookService.EditAuthor(book);
            return RedirectToAction("index");
        }
    }
}