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
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("greet")]
        public IActionResult Greets(string name)
        {
            greet.Name = name;
            return RedirectToAction("IndexWithHi");
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult IndexWithHi()
        {
            return View(greet);
        }
    }
}