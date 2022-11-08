using LearnEnglish.Domain.Aggregate.TopicTrees;
using LearnEnglish.Infrastructure.Repositories;
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
    public partial class frmSelectTopicTree : Form
    {
        private readonly ITopicTreeRepository topicTreeRepository = new TopicTreeRepository();
        private TopicTree selectedTopic;
        public int? SelectedParentId
        {
            get
            {
                if (this.selectedTopic != null)
                    return this.selectedTopic.Id;
                return null;
            }
        }

        public frmSelectTopicTree()
        {
            InitializeComponent();
            this.loadTopicTrees();
        }

        private void loadTopicTrees()
        {
            TreeNode root = new TreeNode("Danh mục");
            Action<TreeNode, int?> addToTree = null;
            addToTree = (u, parentId) =>
            {
                var children = this.topicTreeRepository.getListFolderByParentId(parentId);
                foreach (var child in children)
                {
                    TreeNode v = new TreeNode(child.Name);
                    v.Tag = child;
                    u.Nodes.Add(v);
                    addToTree(v, child.Id);
                }
            };
            addToTree(root, null);
            this.topicTreeView.Nodes.Add(root);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.topicTreeView.SelectedNode != null)
            {
                this.selectedTopic = this.topicTreeView.SelectedNode.Tag as TopicTree;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
