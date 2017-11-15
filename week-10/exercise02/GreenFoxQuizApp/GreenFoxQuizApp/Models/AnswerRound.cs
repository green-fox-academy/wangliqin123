using GreenFoxQuizApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Models
{
    internal class AnswerRound : INeed
    {
        public int Id { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }
}
