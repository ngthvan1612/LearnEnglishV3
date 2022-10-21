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

namespace LearnEnglish.App.GUI.ChuDe
{
    public partial class frmSuaChuDe : Form
    {
        private TopicTree topicTree;

        public frmSuaChuDe(TopicTree topicTree)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.topicTree = topicTree;
            this.textBox1.Text = topicTree.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newTopicName = this.textBox1.Text.Trim();
            if (newTopicName.Length == 0)
            {
                MessageBox.Show("Tên chủ đề không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.topicTree.Name = newTopicName;
            this.DialogResult = DialogResult.OK;
        }
    }
}
