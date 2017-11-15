﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreenFoxQuizApp.Services;

namespace GreenFoxQuizApp.Controllers
{
    public class QuizController : Controller
    {
        QuizService QuizService;

        public QuizController(QuizService quizService)
        {
            QuizService = quizService;
        }

        [Route("/questions")]
        [HttpGet]
        public IActionResult Index()
        {
            QuizService.MakeStaticList();
            return Json(QuizService.FiveQuestionsToJson());
        }

        [Route("/answers")]
        [HttpGet]
        public IActionResult Post()
        {
            return Json(QuizService.FiveAnswerForJson());
        }
    }
}
