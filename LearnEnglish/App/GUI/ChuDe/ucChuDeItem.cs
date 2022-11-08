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
    public enum ChuDeItemType
    {
        Folder, List
    }

    public partial class ucChuDeItem : UserControl
    {
        public delegate void ItemClickedEventHandler(object sender);
        public event ItemClickedEventHandler OnItemClicked;

        public delegate void ItemEditEventHandler(object sender);
        public event ItemEditEventHandler OnItemEditClicked;

        public delegate void ItemDeleteEventHandler(object sender);
        public event ItemDeleteEventHandler OnItemDeleteClicked;

        public delegate void ItemDragEventHandler(object sender);
        public event ItemDragEventHandler OnItemDrag;

        public delegate void ItemMoveEventHandler(object sender);
        public event ItemMoveEventHandler OnItemMoveClicked;

        public ucChuDeItem(ChuDeItemType type)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (type == ChuDeItemType.Folder)
            {
                this.pictureBox1.Image = Properties.Resources.icons8_folder_48;
            }
            else
            {
                this.pictureBox1.Image = Properties.Resources.list_icon;
            }
        }

        public string Content
        {
            get
            {
                return this.lbContent.Text;
            }
            set
            {
                this.lbContent.Text = value;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.OnItemEditClicked?.Invoke(this);
        }

        private void ucChuDeItem_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.OnItemDeleteClicked?.Invoke(this);
        }

        private void lbContent_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbContent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonFace;
        }

        private void ucChuDeItem_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ucChuDeItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

        private void lbContent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.OnItemClicked?.Invoke(this);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            this.OnItemMoveClicked?.Invoke(this);
        }
    }
}
