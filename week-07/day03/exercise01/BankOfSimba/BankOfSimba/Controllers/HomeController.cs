using Microsoft.AspNetCore.Mvc;
using BankOfSimba.ViewModels.Home;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public HomeViewModel homeViewModel = new HomeViewModel();

        [Route("AccountList")]
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public ActionResult MyAction(string submit)
        {
            if (submit != null)
            {
                for (int i = 0; i < homeViewModel.accounts.Count; i++)
                {
                    if (homeViewModel.accounts[i].IsKing != false)
                    {
                        homeViewModel.accounts[i].Balance += 100;
                    }
                    else
                    {
                        homeViewModel.accounts[i].Balance += 10;
                    }
                }
            }
            return View();
        }
    }
}