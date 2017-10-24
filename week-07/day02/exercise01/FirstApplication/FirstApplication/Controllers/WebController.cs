using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplication.Models;

namespace FirstApplication.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static int counter = 0;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                Id = ++counter,
                Content = name,

            };

            return View(greeting);
        }
    }
}