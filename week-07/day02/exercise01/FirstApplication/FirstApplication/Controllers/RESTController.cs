using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            name = "Lorand";
            return new JsonResult(new { id = 1, content = name });
        }
    }
}