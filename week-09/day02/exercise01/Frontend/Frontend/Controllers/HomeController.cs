using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [Route("/doubling")]
        [HttpGet]
        public IActionResult Index(int? input)
        {         
            if (input == null)
            {
                return Json(new {error = "Please provide an input!"});
            }
            else 
            {
                return Json(new { received = input, result = input*2});
            }
        }

        [Route("/greeter")]
        [HttpGet]
        public IActionResult Index(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [Route("/appenda/{appendable}")]
        [HttpGet]
        public IActionResult Appenda(string appendable)
        {
            return Json(new {appended = $"{appendable}a" });
        }

        [Route("/dountil/{what}")]
        [HttpPost]
        public IActionResult Index(string what, [FromBody] DoUntil until)
        {

            if (until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else if (what == "sum")
            {
                int sum = 0;

                for (int i = 0; i <= until.Until; i++)
                {
                    sum += i;
                }
                return Json(new {result = sum});
            }
            else if(what == "factor")
            {
                int fact = 1;
                fact = until.Until;
                for (int i = until.Until - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                return Json(new {result = fact});
            }
            else
            {
                return Json(new {  result = 4 });
            }
        }

        public class DoUntil
        {
            public int Until { get; set; }
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult Array([FromBody] MyArray numbers)
        {
            if ()
            {

            }
        }

        public class MyArray
        {
            public int[] numbers { get; set; }
        }

    }
}