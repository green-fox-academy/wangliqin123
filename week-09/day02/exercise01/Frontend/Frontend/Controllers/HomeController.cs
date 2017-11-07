﻿using System;
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
    }
}