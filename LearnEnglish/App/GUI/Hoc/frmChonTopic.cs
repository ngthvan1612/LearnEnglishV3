using LearnEnglish.App.Services;
using LearnEnglish.Domain.Aggregate.TopicTrees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.App.GUI.Hoc
{
    public partial class frmChonTopic : Form
    {
        private BindingList<TopicTree> dataSource;
        
        public List<int> SelectedTopicIds { get; set; }
        public int NumMeaning { get; set; }
        public int NumListening { get; set; }

        public frmChonTopic()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            this.dataSource = new BindingList<TopicTree>();
            this.dgvSelectTopic.DataSource = this.dataSource;
        }
    }
}
