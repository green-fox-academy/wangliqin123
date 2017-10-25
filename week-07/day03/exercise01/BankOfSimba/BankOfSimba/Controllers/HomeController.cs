using Microsoft.AspNetCore.Mvc;
using BankOfSimba.ViewModels.Home;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("Account")]
        public IActionResult Index()
        { 
            return View(new HomeViewModel());
        }
    }
}