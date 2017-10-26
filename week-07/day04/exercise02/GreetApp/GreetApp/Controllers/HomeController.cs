using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreetApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Greeting()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/")]
        public IActionResult GreetSomeone()
        {

        }
    }
}
