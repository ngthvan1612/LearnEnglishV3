using LearnEnglish.App.Services;
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

namespace LearnEnglish.App.GUI.Hoc
{
    public partial class frmChonTopic : Form
    {
        private BindingList<TopicTree> dataSource;
        
        public List<int> SelectedTopicIds { get; set; }
        public int NumMeaning { get; set; }
        public int NumListening { get; set; }

        private readonly ITopicTreeRepository topicTreeRepository = new TopicTreeRepository();

        public frmChonTopic()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            this.dataSource = new BindingList<TopicTree>();
            this.loadListTopics();
        }

        private void loadListTopics()
        {
            this.tvListTopics.CheckBoxes = true;
            TreeNode root = new TreeNode("Danh sách mục");
            root.Tag = null;
            this.loadTopicsIntoTree(root);
            this.tvListTopics.Nodes.Add(root);
            this.tvListTopics.AfterCheck += TvListTopics_AfterCheck;
        }

        private void TvListTopics_AfterCheck(object? sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.Checked && e.Node.Nodes.Count == 0)
                {
                    e.Node.ForeColor = Color.Red;
                }
                else
                {
                    e.Node.ForeColor = Color.Black;
                }
            }
        }

        private void loadTopicsIntoTree(TreeNode root)
        {
            int? parentId = null;
            if (root.Tag is TopicTree)
                parentId = (root.Tag as TopicTree).Id;
            var children = this.topicTreeRepository.getListFolderAndListByParentId(parentId);
            foreach (var child in children)
            {
                var node = new TreeNode(child.Name);
                node.Tag = child;
                root.Nodes.Add(node);
                this.loadTopicsIntoTree(node);
            }
        }

        private void tvListTopics_AfterCheck(object sender, TreeViewEventArgs e)
        {
            this.tvListTopics.AfterCheck -= this.tvListTopics_AfterCheck;

            Action<TreeNode> toggleAllChild = null;
            toggleAllChild = (root) =>
            {
                root.Checked = e.Node.Checked;
                foreach (TreeNode child in root.Nodes)
                {
                    toggleAllChild(child);
                }
            };

            if (e.Node != null)
            {
                toggleAllChild(e.Node);

                if (!e.Node.Checked)
                {
                    TreeNode u = e.Node.Parent;
                    while (u != null)
                    {
                        u.Checked = false;
                        u = u.Parent;
                    }
                }
            }

            this.tvListTopics.AfterCheck += this.tvListTopics_AfterCheck;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Action<TreeNode> listAllCheckedList = null;
            List<TopicTree> listChecked = new List<TopicTree>();

            listAllCheckedList = (root) =>
            {
                if (root.Nodes.Count == 0 && root.Checked)
                {
                    listChecked.Add(root.Tag as TopicTree);
                }
                foreach (TreeNode child in root.Nodes)
                {
                    listAllCheckedList(child);
                }
            };

            foreach (TreeNode child in this.tvListTopics.Nodes)
                listAllCheckedList(child);

            int numberVocabsSelected = listChecked.Select(u => this.topicTreeRepository.numberOfVocabByTopicId(u.Id)).Sum();

            if (numberVocabsSelected < 4)
            {
                MessageBox.Show($"Cần ít nhất 4 từ vựng để học\nHiện tại đã chọn {numberVocabsSelected} từ",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.numListening.Value + this.numMeaning.Value <= 0)
            {
                MessageBox.Show($"Tổng số lần học nghe + đọc phải lớn hơn 0",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmHoc frm = new frmHoc(
                listChecked.Select(u => u.Id).ToList(),
                (int)this.numMeaning.Value,
                (int)this.numListening.Value
            );

            frm.ShowDialog();
        }
    }
}
