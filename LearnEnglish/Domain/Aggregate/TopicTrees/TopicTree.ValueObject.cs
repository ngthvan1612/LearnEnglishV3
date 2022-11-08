using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.TopicTrees
{
    public class TopicTreeView
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("STT")]
        public string Order { get; set; }

        [DisplayName("Danh sách")]
        public string Path { get; set; }

        public TopicTreeView()
        {

        }
    }
}
