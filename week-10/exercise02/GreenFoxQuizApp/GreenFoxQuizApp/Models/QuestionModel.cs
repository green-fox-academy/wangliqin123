using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Models
{
    public class QuestionModel : INeed
    {
        public int Id { get; set; }
        public string Question { get; set; }
    }
}
