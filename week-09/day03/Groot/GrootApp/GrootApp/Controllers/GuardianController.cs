using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrootApp.Services;

namespace GrootApp.Controllers
{

    public class GuardianController : Controller
    {
        GuardianService GuardianService;

        public GuardianController(GuardianService guardianService)
        {
            GuardianService = guardianService;
        }

        [HttpGet]
        [Route("/groot/{message}")]
        [Route("/groot")]
        public IActionResult Index(string message)
        {
            return Json(GuardianService.CheckGroot(message));
        }
    }
}