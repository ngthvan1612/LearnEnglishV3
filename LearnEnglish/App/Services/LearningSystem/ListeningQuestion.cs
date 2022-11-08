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
    public class ListeningQuestion : QuestionAbstract
    {

        public ListeningQuestion(Vocab vocab)
            : base(vocab, buildQuestionDesign("Ghi lại những gì bạn nghe thấy"), vocab.Eng, vocab.Audio, vocab.Id)
        {
            
        }

        private static string buildQuestionDesign(string question)
        {
            string questionHtmlEncode = HttpUtility.HtmlEncode(question);
            return 
                $"<div style='text-align:center;vertial-align:center;line-height:100%;font-size:25px;'>" +
                $"  <span style='color:red;'>" +
                $"    {questionHtmlEncode}" +
                $"  </span>" +
                $"</div>";
        }
    }
}
