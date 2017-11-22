using Microsoft.AspNetCore.Mvc;
using SpringBootApp.Services;

namespace SpringBootApp.Controllers
{
    
    public class HomeController : Controller
    {
        SpringBootAppService SpringBootAppService;

        public HomeController(SpringBootAppService springBootAppService)
        {
            SpringBootAppService = springBootAppService;
        }

        [HttpGet]
        [Route("/search")]
        public IActionResult Index(string inputPlate, int police, int diplomat)
        {
            if (police == 1)
            {
                return View(SpringBootAppService.GetPoliceCarsForUser());
            }
            else if (diplomat == 1)
            {
                return View(SpringBootAppService.GetDiplomatCarsForUser());
            }
            else
            {
                return View(SpringBootAppService.GetLicencePlateListForUser(inputPlate));
            }
        }

        [HttpGet]
        [Route("/search/{brand}")]
        public IActionResult Brand(string brand)
        {
            return View("Index", SpringBootAppService.GetBrandListForUser(brand));
        }
    }
}