using GreenFoxQuizApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Repositories
{
    public class QuizRepository
    {
        GreenFoxQuizAppContext GreenFoxQuizAppContext;

        public QuizRepository(GreenFoxQuizAppContext greenFoxQuizAppContext)
        {
            GreenFoxQuizAppContext = greenFoxQuizAppContext;
        }
    }
}
