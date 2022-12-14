using LearnEnglish.Domain.Aggregate.Vocabs;
using LearnEnglish.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Repositories
{
    public class VocabRepository : BaseRepository, IVocabRepository
    {
        public VocabRepository()
        {

        }

        public void addResult(Vocab vocab, string result)
        {
            using (var dbs = this.CreateContextFactory())
            {
                dbs.LearningVocabStatuses.Add(LearningVocabStatus.createInstance(vocab.Id, result));
                dbs.SaveChanges();
            }
        }

        public Vocab addVocab(Vocab vocab)
        {
            using (var dbs = this.CreateContextFactory())
            {
                dbs.Vocabs.Add(vocab);
                dbs.SaveChanges();
                return vocab;
            }
        }

        public void deleteVocab(Vocab vocab)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbVocab = dbs.Vocabs.FirstOrDefault(u => u.Id == vocab.Id);
                dbVocab.deleteVocab();
                dbs.SaveChanges();
            }
        }

        public List<Vocab> listVocabsByParentId(int topicTreeId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var query = dbs.Vocabs
                    .Where(u => u.DeletedAt == null)
                    .Where(u => u.TopicTreeId == topicTreeId);

                return query.ToList();
            }
        }

        public List<VocabView> listVocabViewsByParentId(int topicTreeId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var query = dbs.Vocabs
                    .Where(u => u.DeletedAt == null)
                    .Where(u => u.TopicTreeId == topicTreeId);

                return query.ToList()
                    .Select((u, order) => new VocabView(u) { Order = order + 1 })
                    .ToList();
            }
        }

        public Vocab updateAudio(Vocab vocab)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbVocab = dbs.Vocabs.FirstOrDefault(u => u.Id == vocab.Id);
                dbVocab.updateAudio(vocab.Audio);
                dbs.SaveChanges();
                return dbVocab;
            }
        }

        public Vocab updateEngAndVie(Vocab vocab)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbVocab = dbs.Vocabs.FirstOrDefault(u => u.Id == vocab.Id);
                dbVocab.updateEngAndVie(vocab.Eng, vocab.Vie);
                dbs.SaveChanges();
                return dbVocab;
            }
        }

        public Vocab updateParent(Vocab vocab)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbVocab = dbs.Vocabs.FirstOrDefault(u => u.Id == vocab.Id);
                dbVocab.changeParent(vocab.TopicTreeId);
                dbs.SaveChanges();
                return dbVocab;
            }
        }
    }
}
