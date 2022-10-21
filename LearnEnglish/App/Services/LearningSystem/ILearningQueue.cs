using LearnEnglish.Domain.Aggregate.Vocabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.App.Services.LearningSystem
{
    public interface ILearningQueue
    {
        void Prepare(IEnumerable<Vocab> questions);
        int AnsweredQuestion();
        int TotalQuestion();
        QuestionAbstract MoveToNextQuestion();
        QuestionAbstract CurrentQuestion();
        void OnBeforeAnswer();
        bool CheckAnswer(string answer);
        void OnCorrentAnswer();
        void OnWrongAnswer();
    }
}
