using GreenFoxQuizApp.Models;
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
        List<Quiz> ListWeNeed;

        public QuizService(QuizRepository quizRepository, List<Quiz> listWeNeed)
        {
            QuizRepository = quizRepository;
        }

        internal void MakeStaticList()
        {
            QuizRepository.GetFiveRandomRow();
        }

        internal AnswerRound FiveAnswerForJson()
        {
            ListWeNeed = QuizRepository.GetListForService();

            var popsik = new List<AnswerModel>();

            for (int i = 0; i < ListWeNeed.Count; i++)
            {
                var popsi = new AnswerModel();
                popsi.Id = ListWeNeed[i].Id;
                popsi.Answer = ListWeNeed[i].Answer;

                popsik.Add(popsi);
            }

            var nagypopsik = new AnswerRound()
            {
                Id = 1,
                Answers = popsik
            };

            return nagypopsik;
        }

        internal QuestionRound FiveQuestionsToJson()
        {
            ListWeNeed = QuizRepository.GetListForService();

            var kukik = new List<QuestionModel>();

            for (int i = 0; i < ListWeNeed.Count; i++)
            {
                var kuki = new QuestionModel();
                kuki.Id = ListWeNeed[i].Id;
                kuki.Question = ListWeNeed[i].Question;

                kukik.Add(kuki);
            }

            var nagykukik = new QuestionRound()
            {
                Id = 1,
                Questions = kukik
            };

            return nagykukik;
        }
    }
}
