using Microsoft.AspNetCore.Mvc;
using CounterApp.Models;

namespace CounterApp.Controllers
{
    public class HomeController : Controller
    {
        Counter counter;

        public HomeController(Counter counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost]
        [Route("index")]
        public IActionResult Increase()
        {
            counter.Raise();
            return RedirectToAction("Index");
        }
    }
}