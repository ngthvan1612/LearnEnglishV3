using LearnEnglish.App.GUI.Hoc.LearningSystem;
using LearnEnglish.Domain.Aggregate.Vocabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.App.Services.LearningSystem
{
    public abstract class QuestionAbstract : IQuestion
    {
        public string QuestionHtml => this._question;
        public string Answer => this._answer;

        private string _question;
        private string _answer;
        private byte[] _audio;
        private int _id;

        protected Vocab equalValue;

        public QuestionAbstract(Vocab vocab, string question, string answer, byte[] audio, int id)
        {
            this.equalValue = vocab;
            this._question = question;
            this._answer = answer;
            this._audio = audio;
            this._id = id;
        }

        /// <summary>
        /// Lấy Id của vocab trong database
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this._id;
        }

        public void PlayAudio()
        {
            new SoundPlayer(new MemoryStream(this._audio)).Play();
        }

        public void PlayAudioSync()
        {
            new SoundPlayer(new MemoryStream(this._audio)).PlaySync();
        }

        public bool IsEqual(QuestionAbstract question)
        {
            return this.equalValue == question.equalValue;
        }

        public virtual bool CheckAnswer(string userAnswer)
        {
            var judgeAnswerArr = this.Answer.Split("=").Select(u => u.Trim().ToLower()).Where(u => u.Length > 0);
            var userAnswerArr = userAnswer.Split("=").Select(u => u.Trim().ToLower()).Where(u => u.Length > 0);
            if (judgeAnswerArr.Count() != userAnswerArr.Count())
                return false;
            foreach (var u in judgeAnswerArr)
            {
                if (!userAnswerArr.Contains(u))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
