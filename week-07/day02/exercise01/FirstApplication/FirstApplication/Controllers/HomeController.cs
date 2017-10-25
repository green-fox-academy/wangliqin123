using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{  
    public class HomeController : Controller
    {     
        public IActionResult Index()
        {        
            return View();
        }
        [Route("hello")]
        public ContentResult Hello()
        {          
            return Content("Hello Europe!");
        }
    }
}