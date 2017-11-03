using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Repositories;

namespace RedditApp.Controllers
{
    public class HomeController : Controller
    {
        RedditRepository RedditRepository;

        public HomeController(RedditRepository redditRepository)
        {
            RedditRepository = redditRepository;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(RedditRepository.GetList());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string post)
        {
            RedditRepository.AddPost(post);
            return RedirectToAction("Index");
        }
    }
}
