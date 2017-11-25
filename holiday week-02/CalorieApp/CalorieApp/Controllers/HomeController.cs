using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieApp.Repositories;

namespace CalorieApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        CalorieAppRepository CalorieAppRepository;

        public HomeController(CalorieAppRepository calorieAppRepository)
        {
            CalorieAppRepository = calorieAppRepository;
        }

        [HttpGet]
        [Route("/drax")]
        public IActionResult Index()
        {
            return View(CalorieAppRepository.GetFoodList());
        }

        [HttpPost]
        [Route("/drax")]
        public IActionResult AddFood(string name, int amount, int calorie)
        {
            CalorieAppRepository.AddFood(name, amount, calorie);
            return View("Index", CalorieAppRepository.GetFoodList());
        }

        [HttpDelete]
        [Route("/drax")]
        public IActionResult DeleteFood(string name)
        {
            CalorieAppRepository.RemoveFood(name);
            return View("Index", CalorieAppRepository.GetFoodList());
        }
    }
}
