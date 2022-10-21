using LearnEnglish.App.GUI.ChuDe;
using LearnEnglish.App.GUI.Hoc;
using LearnEnglish.App.GUI.Support;
using LearnEnglish.App.Services;

namespace LearnEnglish.App.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuDsChuDe_Click(object sender, EventArgs e)
        {
            new frmQuanLyChuDe().ShowDialog();
        }

        private void menuTuVung_Click(object sender, EventArgs e)
        {
            
        }

        private void menuLearning_Click(object sender, EventArgs e)
        {
            var frm = new frmChonTopic();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var frmS = new frmHoc(frm.SelectedTopicIds, frm.NumMeaning, frm.NumListening);
                try
                {
                    frmS.ShowDialog();
                }
                catch { }
            }
        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            
        }

        private void menuImport_Click(object sender, EventArgs e)
        {
            
        }
    }
}