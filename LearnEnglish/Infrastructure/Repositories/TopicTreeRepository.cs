using LearnEnglish.Domain.Aggregate.TopicTrees;
using LearnEnglish.Domain.Repositories;
using LearnEnglish.Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Repositories
{
    public class TopicTreeRepository : BaseRepository, ITopicTreeRepository
    {
        public TopicTreeRepository()
        {

        }

        public List<TopicTree> getListChildrenByParentId(int? parentId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                if (parentId == null)
                {
                    var list = dbs.TopicTrees
                        .Where(u => u.DeletedAt == null)
                        .Where(u => u.Path == "/")
                        .ToList();

                    var compareEngine = new NaturalStringComparer();
                    list.Sort((a, b) =>
                    {
                        return compareEngine.Compare(a.Name, b.Name);
                    });

                    return list;
                }
                else
                {
                    var dbParent = dbs.TopicTrees.FirstOrDefault(u => u.Id == parentId);
                    string childPath = $"{dbParent.Path}{dbParent.Id}/";

                    var list = dbs.TopicTrees
                        .Where(u => u.DeletedAt == null)
                        .Where(u => u.Path == childPath)
                        .ToList();

                    var compareEngine = new NaturalStringComparer();
                    list.Sort((a, b) =>
                    {
                        return compareEngine.Compare(a.Name, b.Name);
                    });

                    return list;
                }
            }
        }

        public TopicTree addFolder(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                dbs.TopicTrees.Add(topicTree);
                dbs.SaveChanges();
                return topicTree;
            }
        }

        public TopicTree addList(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                dbs.TopicTrees.Add(topicTree);
                dbs.SaveChanges();
                return topicTree;
            }
        }

        public TopicTree updateTopicName(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbTopicTree = dbs.TopicTrees.FirstOrDefault(u => u.Id == topicTree.Id);
                dbTopicTree.updateTopicName(topicTree.Name);
                dbs.SaveChanges();
                return dbTopicTree;
            }
        }

        public TopicTree deleteTopic(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbTopicTree = dbs.TopicTrees.FirstOrDefault(u => u.Id == topicTree.Id);
                dbTopicTree.deleteTopic();
                dbs.SaveChanges();
                return dbTopicTree;
            }
        }

        public TopicTree getTopicTreeById(int id)
        {
            using (var dbs = this.CreateContextFactory())
            {
                return dbs.TopicTrees.FirstOrDefault(u => u.Id == id);
            }
        }
    }
}
