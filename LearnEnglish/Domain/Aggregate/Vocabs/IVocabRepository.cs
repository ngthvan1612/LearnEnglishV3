using LearnEnglish.Domain.Aggregate.TopicTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.Vocabs
{
    public interface IVocabRepository
    {
        List<VocabView> listVocabsByTopicId(int topicTreeId);
        Vocab addVocab(Vocab vocab);
        Vocab updateEngAndVie(Vocab vocab);
        Vocab updateAudio(Vocab vocab);
        void deleteVocab(Vocab vocab);
    }
}
