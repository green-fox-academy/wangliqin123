using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GrootApp.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route("/groot")]
        public IActionResult Index(string message)
        {
            if (message == null)
            {
                return Json(new { error = "I am Groot!" });
            }
            else
            {
                return Json(new { received = "somemessage", translated = "I am Groot!" });
            }
        }
    }
}