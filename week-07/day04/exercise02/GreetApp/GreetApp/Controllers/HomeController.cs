using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetApp.Models;

namespace GreetApp.Controllers
{
    public class HomeController : Controller
    {
        Greet greet;

        public HomeController(Greet greet)
        {
            this.greet = greet;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Greets()
        {
            return RedirectToAction("greet");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult GreetSomeone()
        {
            greet.Greeting();
            return View(greet);
        }
    }
}
