using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.TopicTrees
{
    public interface ITopicTreeRepository
    {
        List<TopicTree> getListChildrenByParentId(int? parentId);
        TopicTree addFolder(TopicTree topicTree);
        TopicTree addList(TopicTree topicTree);
        TopicTree updateTopicName(TopicTree topicTree);
        TopicTree deleteTopic(TopicTree topicTree);
        TopicTree getTopicTreeById(int id);
    }
}
