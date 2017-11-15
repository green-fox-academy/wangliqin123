using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Models
{
    public class QuestionRound : INeed
    {
        public int Id { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
}
