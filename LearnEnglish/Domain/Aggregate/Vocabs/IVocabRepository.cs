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
        List<VocabView> listVocabViewsByParentId(int topicTreeId);
        List<Vocab> listVocabsByParentId(int topicTreeId);
        Vocab addVocab(Vocab vocab);
        Vocab updateEngAndVie(Vocab vocab);
        Vocab updateAudio(Vocab vocab);
        Vocab updateParent(Vocab vocab);
        void addResult(Vocab vocab, string result);
        void deleteVocab(Vocab vocab);
    }
}
