using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.Vocabs
{
    public partial class LearningVocabStatus
    {
        public static LearningVocabStatus createInstance(int vocabId, string result)
        {
            LearningVocabStatus u = new LearningVocabStatus();
            u.VocabId = vocabId;
            u.Result = result;
            u.Created = DateTime.Now;
            return u;
        }
    }
}
