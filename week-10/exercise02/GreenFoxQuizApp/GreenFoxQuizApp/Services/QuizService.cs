using GreenFoxQuizApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Services
{
    public class QuizService
    {
        QuizRepository QuizRepository;

        public QuizService(QuizRepository quizRepository)
        {
            QuizRepository = quizRepository;
        }

        
    }
}
