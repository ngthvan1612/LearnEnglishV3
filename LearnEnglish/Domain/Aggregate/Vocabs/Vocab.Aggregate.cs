using LearnEnglish.Domain.Aggregate.TopicTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.Vocabs
{
    public partial class Vocab
    {
        public void updateEngAndVie(string eng, string vie)
        {
            if (string.IsNullOrEmpty(eng) || string.IsNullOrEmpty(vie))
                throw new ArgumentNullException();
            this.Eng = eng;
            this.Vie = vie;
        }

        public static Vocab createVocab(string eng, string vie, byte[] audio, int topicTreeId)
        {
            Vocab vocab = new Vocab();
            vocab.Eng = eng;
            vocab.Vie = vie;
            vocab.Audio = audio;
            vocab.TopicTreeId = topicTreeId;
            return vocab;
        }

        public void updateAudio(byte[] newAudio)
        {
            if (newAudio is null)
                throw new ArgumentNullException();
            this.Audio = newAudio;
        }

        public void changeParent(TopicTree topicTree)
        {
            this.TopicTreeId = topicTree.Id;
        }

        public void deleteVocab()
        {
            this.DeletedAt = DateTime.Now;
        }
    }
}
