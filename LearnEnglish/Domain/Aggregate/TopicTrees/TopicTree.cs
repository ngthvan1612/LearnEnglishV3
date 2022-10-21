using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.TopicTrees
{
    public partial class TopicTree
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NodeType { get; set; }

        public string Path { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public TopicTree()
        {

        }
    }
}
