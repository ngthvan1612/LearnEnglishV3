using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.TopicTrees
{
    public partial class TopicTree
    {
        public static TopicTree createFolder(string folderName, string parentPath)
        {
            TopicTree topicTree = new TopicTree();
            topicTree.Name = folderName;
            topicTree.Path = parentPath;
            topicTree.DeletedAt = null;
            topicTree.CreatedAt = DateTime.Now;
            topicTree.NodeType = "FOLDER";
            return topicTree;
        }

        public static TopicTree createList(string listName, string parentPath)
        {
            TopicTree topicTree = new TopicTree();
            topicTree.Name = listName;
            topicTree.Path = parentPath;
            topicTree.DeletedAt = null;
            topicTree.CreatedAt = DateTime.Now;
            topicTree.NodeType = "LIST";
            return topicTree;
        }

        public string getPathForChild()
        {
            return $"{this.Path}{this.Id}/";
        }

        public void updateTopicName(string newTopicName)
        {
            this.Name = newTopicName;
        }

        public void updateTopicPath(string newPath)
        {
            this.Path = newPath;
        }

        public void deleteTopic()
        {
            this.DeletedAt = DateTime.Now;
        }

        public bool isFolder()
        {
            return this.NodeType == "FOLDER";
        }

        public bool isList()
        {
            return this.NodeType == "LIST";
        }
    }
}
