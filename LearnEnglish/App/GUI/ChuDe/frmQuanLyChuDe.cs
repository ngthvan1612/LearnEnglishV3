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
using LearnEnglish.App.GUI.Support;

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
        }

        private void renderListFolders()
        {
            renderListFoldersAsync();
        }

        private void toggleDoubleBufferedPanel(Panel pn, bool value)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
               | BindingFlags.Instance | BindingFlags.NonPublic, null,
               pn, new object[] { value }) ;
        }

        private Task renderListFoldersAsync()
        {
            this.toggleDoubleBufferedPanel(this.pnListFolders, true);

            this.pnPath.Enabled = false;
            this.pnListFolders.Controls.Clear();
            this.pnListFolders.AutoScroll = true;

            int? partentId = null;
            if (this.path.Count > 0)
                partentId = this.path[this.path.Count - 1].Id;

            Stack<Control> controls = new Stack<Control>();

            var listChildren = this.topicTreeRepository.getListFolderAndListByParentId(partentId);

            this.pnListFolders.VerticalScroll.Value = 0;

            foreach (var child in listChildren)
            {
                ucChuDeItem ctl;
                if (child.isFolder())
                    ctl = new ucChuDeItem(ChuDeItemType.Folder);
                else
                    ctl = new ucChuDeItem(ChuDeItemType.List);
                ctl.KeyDown += this.frmQuanLyChuDe_KeyDown;
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
                        new frmLoading(() =>
                        {
                            this.topicTreeRepository.deleteTopic(child);
                        })
                        { Text = "Đang xóa dữ liệu..." }.ShowDialog();
                        this.renderListFolders();
                        this.renderPath();
                    }
                };
                ctl.OnItemMoveClicked += (sender) =>
                {
                    var frmListDestination = new frmSelectTopicTree()
                    {
                        Text = "Chọn nơi mới"
                    };
                    if (frmListDestination.ShowDialog() == DialogResult.OK)
                    {
                        this.topicTreeRepository.changeTopicParentByParentId(child, frmListDestination.SelectedParentId);
                        this.renderListFolders();

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

            this.toggleDoubleBufferedPanel(this.pnListFolders, false);

            if (this.pnListFolders.Controls.Count > 0)
            {
                Application.DoEvents();
                this.pnListFolders.ScrollControlIntoView(this.pnListFolders.Controls[0]);
                this.pnListFolders.PerformLayout();
                this.pnListFolders.ScrollControlIntoView(this.pnListFolders.Controls[this.pnListFolders.Controls.Count - 1]);
                this.PerformLayout();
            }

            foreach (Control ctl in this.pnListFolders.Controls)
            {
                this.addKeyDownEventRecursive(ctl);
            }

            return Task.CompletedTask;
        }

        private void addKeyDownEventRecursive(Control ctl)
        {
            ctl.KeyDown += this.frmQuanLyChuDe_KeyDown;
            foreach (Control child in ctl.Controls)
            {
                this.addKeyDownEventRecursive(child);
            }
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
                    }
                    this.renderPath();
                    this.renderListFolders();
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

            foreach (Control ctl in this.pnPath.Controls)
            {
                this.addKeyDownEventRecursive(ctl);
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

        private void frmQuanLyChuDe_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.KeyCode.ToString());
            if (e.Control && e.KeyCode == Keys.N)
            {
                this.btnAddNewFolder_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.M)
            {
                this.btnAddNewList_Click(null, null);
            }
        }

        private void frmQuanLyChuDe_Load(object sender, EventArgs e)
        {
            this.renderPath();
            this.renderListFolders();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Learn English Export File (*.lee)|*.lee";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int? parentId = null;
                    if (this.path.Count > 0)
                        parentId = this.path.Last().Id;
                    this.topicTreeRepository.exportTopic(dialog.FileName, parentId);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Learn English Export File (*.lee)|*.lee";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int? parentId = null;
                    if (this.path.Count > 0)
                        parentId = this.path.Last().Id;
                    frmLoading frm = new frmLoading(() =>
                    {
                        try
                        {
                            this.topicTreeRepository.importTopic(dialog.FileName, parentId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi import:\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                    frm.Text = "Đang import...";
                    frm.ShowDialog();
                    this.renderListFolders();
                }
            }
        }
    }
}
