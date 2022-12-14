using LearnEnglish.App.GUI.Hoc.LearningSystem;
using LearnEnglish.Domain.Aggregate.Vocabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LearnEnglish.App.Services.LearningSystem
{
    public class MeaningQuestion : QuestionAbstract
    {
        public byte[] Audio;

        public MeaningQuestion(Vocab vocab)
            : base(vocab, buildQuestionDesign(vocab.Vie), vocab.Eng, vocab.Audio, vocab.Id)
        {
            
        }

        private static string buildQuestionDesign(string question)
        {
            string questionHtmlEncode = HttpUtility.HtmlEncode(question);
            return
                $"<div style='text-align:center;vertial-align:center;line-height:90px;font-size:25px;font-weight:bold'>" +
                $"  <span style='color:darkgreen;'>" +
                $"    {questionHtmlEncode}" +
                $"  </span>" +
                $"</div>";
        }
    }
}
