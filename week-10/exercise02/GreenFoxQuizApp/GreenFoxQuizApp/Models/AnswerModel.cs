using GreenFoxQuizApp.Models;

namespace GreenFoxQuizApp.Services
{
    internal class AnswerModel : INeed
    {
        public int Id { get; set; }
        public string Answer { get; set; }
    }
}