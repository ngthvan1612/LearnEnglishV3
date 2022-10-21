using LearnEnglish.Domain.Aggregate.Vocabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.LearningStatuses
{
    public partial class LearningVocabStatus
    {
        public int Id { get; set; }
        public int VocabId { get; set; }
        public Vocab Vocab { get; set; }
        public DateTime Created { get; set; }
        public string Result { get; set; }

        public LearningVocabStatus()
        { }

        public LearningVocabStatus(int vocabId, string result)
            : this()
        {
            VocabId = vocabId;
            Created = DateTime.Now;
            Result = result;
        }
    }
}
