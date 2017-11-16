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

            var answerModelList = new List<AnswerModel>();

            for (int i = 0; i < ListWeNeed.Count; i++)
            {
                var answerMod = new AnswerModel();
                answerMod.Id = ListWeNeed[i].Id;
                answerMod.Answer = ListWeNeed[i].Answer;

                answerModelList.Add(answerMod);
            }

            var answerRod = new AnswerRound()
            {
                Id = 1,
                Answers = answerModelList
            };

            return answerRod;
        }

        internal QuestionRound FiveQuestionsToJson()
        {
            ListWeNeed = QuizRepository.GetListForService();

            var questionModelList = new List<QuestionModel>();

            for (int i = 0; i < ListWeNeed.Count; i++)
            {
                var questionMo = new QuestionModel();
                questionMo.Id = ListWeNeed[i].Id;
                questionMo.Question = ListWeNeed[i].Question;

                questionModelList.Add(questionMo);
            }

            var questionRod = new QuestionRound()
            {
                Id = 1,
                Questions = questionModelList
            };

            return questionRod;
        }
    }
}
