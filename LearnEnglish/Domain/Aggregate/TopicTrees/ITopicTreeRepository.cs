using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.TopicTrees
{
    public interface ITopicTreeRepository
    {
        List<TopicTree> getListFolderAndListByParentId(int? parentId);
        List<TopicTree> getListFolderByParentId(int? parentId);
        TopicTree addFolder(TopicTree topicTree);
        int numberOfVocabByTopicId(int topicId);
        TopicTree addList(TopicTree topicTree);
        TopicTree updateTopicName(TopicTree topicTree);
        TopicTree deleteTopic(TopicTree topicTree);
        TopicTree getTopicTreeById(int id);
        TopicTree changeTopicParentByParentId(TopicTree topicTree, int? newParentId);
        void exportTopic(string fileName, int? id);
        void importTopic(string fileName, int? parentId);
    }
}
