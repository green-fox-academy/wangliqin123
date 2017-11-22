using Microsoft.AspNetCore.Mvc;
using SpringBootApp.Services;

namespace SpringBootApp.Controllers
{
    public class RestController : Controller
    {
        SpringBootAppService SpringBootAppService;

        public RestController(SpringBootAppService springBootAppService)
        {
            SpringBootAppService = springBootAppService;
        }

        [HttpGet]
        [Route("api/search/{brand}")]
        public IActionResult BrandListJson(string brand)
        {
            var sameBrandOfCars = SpringBootAppService.GetBrandListForUser(brand);

            return Json(new { result = "ok", data = sameBrandOfCars });
        }
    }
}