using GreenFoxQuizApp.Entities;
using GreenFoxQuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Repositories
{
    public class QuizRepository
    {
        GreenFoxQuizAppContext GreenFoxQuizAppContext;
        List<Quiz> ListForTransfer;

        public QuizRepository(GreenFoxQuizAppContext greenFoxQuizAppContext)
        {
            GreenFoxQuizAppContext = greenFoxQuizAppContext;
        }

        public List<Quiz> GetListForService()
        {
            return ListForTransfer;
        }

        public void GetFiveRandomRow()
        {
            var random = new Random();
            ListForTransfer = GreenFoxQuizAppContext.Quizes.OrderBy(x => random.Next()).Take(5).ToList();
        }
    }
}
