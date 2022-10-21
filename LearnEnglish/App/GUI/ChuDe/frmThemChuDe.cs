using LearnEnglish.App.Services;
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
    public partial class frmThemChuDe : Form
    {
        public string TopicName { get; set; }

        public frmThemChuDe()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.TopicName = this.tbName.Text.Trim();
            if (this.TopicName.Length == 0)
            {
                MessageBox.Show("Tên mục không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
