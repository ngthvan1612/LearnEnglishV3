using LearnEnglish.App.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using LearnEnglish.Infrastructure.Repositories;
using LearnEnglish.Domain.Aggregate.TopicTrees;
using System.Diagnostics;

namespace LearnEnglish.App.GUI.ChuDe
{
    public partial class frmQuanLyChuDe : Form
    {
        private readonly ITopicTreeRepository topicTreeRepository;

        private List<TopicTree> path = new List<TopicTree>();

        public frmQuanLyChuDe()
        {
            InitializeComponent();

            this.topicTreeRepository = new TopicTreeRepository();

            this.ShowInTaskbar = false;
            this.pnListFolders.AutoScroll = true;
            this.DoubleBuffered = true;

            this.renderPath();
            this.renderListFolders();
        }

        private void renderListFolders()
        {
            Task.WaitAll(renderListFoldersAsync());
        }

        private Task renderListFoldersAsync()
        {
            this.pnPath.Enabled = false;
            this.statusLabel.Text = "Đang tải";
            this.progressStatus.MarqueeAnimationSpeed = 10;
            this.progressStatus.Style = ProgressBarStyle.Marquee;
            this.pnListFolders.Controls.Clear();
            int? partentId = null;
            if (this.path.Count > 0)
                partentId = this.path[this.path.Count - 1].Id;

            Stack<Control> controls = new Stack<Control>();

            var listChildren = this.topicTreeRepository.getListChildrenByParentId(partentId);

            foreach (var child in listChildren)
            {
                ucChuDeItem ctl;
                if (child.isFolder())
                    ctl = new ucChuDeItem(ChuDeItemType.Folder);
                else
                    ctl = new ucChuDeItem(ChuDeItemType.List);
                ctl.Content = child.Name;
                ctl.Dock = DockStyle.Top;
                ctl.OnItemClicked += (sender) =>
                {
                    if (child.isFolder())
                    {
                        this.path.Add(child);
                        this.renderListFolders();
                        this.renderPath();
                    }
                    else
                    {
                        var frm = new frmDanhSachTuVung(child);
                        frm.Text = $"Danh sách '{child.Name}'";
                        frm.ShowDialog();
                    }
                };
                ctl.OnItemEditClicked += (sender) =>
                {
                    var frm = new frmSuaChuDe(child);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        this.topicTreeRepository.updateTopicName(child);
                        this.renderListFolders();
                        this.renderPath();
                    }
                };
                ctl.OnItemDeleteClicked += (sender) =>
                {
                    var answer = MessageBox.Show("Bạn có chắc muốn xóa mục này không?",
                        "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (answer == DialogResult.Yes)
                    {
                        this.topicTreeRepository.deleteTopic(child);
                        this.renderListFolders();
                        this.renderPath();
                    }
                };
                controls.Push(ctl);
            }

            while (controls.Count > 0)
            {
                var ctl = controls.Pop();
                this.pnListFolders.Controls.Add(ctl);
            }
            this.pnPath.Enabled = true;
            this.statusLabel.Text = "OK";
            this.progressStatus.Style = ProgressBarStyle.Blocks;

            return Task.CompletedTask;
        }

        private void renderPath()
        {
            this.pnPath.Controls.Clear();
            Stack<Control> controls = new Stack<Control>();

            Label spe = new Label();
            spe.AutoSize = true;
            spe.Font = new Font("Arial", 12.5f);
            spe.Text = "/";
            spe.Dock = DockStyle.Left;

            LinkLabel lbHome = new LinkLabel();
            lbHome.AutoSize = true;
            lbHome.Font = spe.Font;
            lbHome.Text = "Home";
            lbHome.LinkClicked += (sender, e) =>
            {
                this.path.Clear();
                this.renderListFolders();
                this.renderPath();
            };
            lbHome.Dock = DockStyle.Left;

            controls.Push(spe);
            controls.Push(lbHome);
            controls.Push(spe);

            foreach (var topicTree in this.path)
            {
                LinkLabel lb = new LinkLabel();
                lb.AutoSize = true;
                lb.Font = spe.Font;
                lb.Text = topicTree.Name;
                lb.LinkClicked += (sender, e) =>
                {
                    while (this.path.Count > 0 && this.path.Last().Id != topicTree.Id)
                    {
                        this.path.RemoveAt(this.path.Count - 1);
                        this.renderListFolders();
                        this.renderPath();
                    }
                };

                Label spa = new Label();
                spa.AutoSize = true;
                spa.Font = new Font("Arial", 12.5f);
                spa.Text = "/";

                lb.Dock = spa.Dock = DockStyle.Left;

                controls.Push(spa);
                controls.Push(lb); 
            }

            while (controls.Count > 0)
            {
                var ctl = controls.Pop();
                this.pnPath.Controls.Add(ctl);
            }
        }

        private void btnAddNewFolder_Click(object sender, EventArgs e)
        {
            var frm = new frmThemChuDe();
            frm.Text = "Thêm thư mục mới";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TopicTree newTopicTree;

                if (this.path.Count > 0)
                    newTopicTree = TopicTree.createFolder(frm.TopicName, this.path.Last().getPathForChild());
                else
                    newTopicTree = TopicTree.createFolder(frm.TopicName, "/");

                this.topicTreeRepository.addFolder(newTopicTree);

                this.renderListFolders();
            }
        }

        private void btnAddNewList_Click(object sender, EventArgs e)
        {
            var frm = new frmThemChuDe();
            frm.Text = "Thêm danh sách mới";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TopicTree newTopicTree;

                if (this.path.Count > 0)
                    newTopicTree = TopicTree.createList(frm.TopicName, this.path.Last().getPathForChild());
                else
                    newTopicTree = TopicTree.createList(frm.TopicName, "/");

                this.topicTreeRepository.addList(newTopicTree);

                this.renderListFolders();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                this.btnAddNewFolder_Click(null, null);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.L))
            {
                this.btnAddNewList_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
