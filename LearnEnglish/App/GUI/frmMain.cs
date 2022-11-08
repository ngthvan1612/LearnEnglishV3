using LearnEnglish.App.GUI.CaiDat;
using LearnEnglish.App.GUI.ChuDe;
using LearnEnglish.App.GUI.Hoc;
using LearnEnglish.App.GUI.Support;
using LearnEnglish.App.Hooking;
using LearnEnglish.App.Services;
using LearnEnglish.Infrastructure.Setting;

namespace LearnEnglish.App.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuanLyTuVung_Click(object sender, EventArgs e)
        {
            new frmQuanLyChuDe().ShowDialog();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            new frmCaiDat().ShowDialog();
        }

        private void btnHoc_Click(object sender, EventArgs e)
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLoading frm = new frmLoading(() =>
            {
                ESetting.Setting.saveSetting();
            })
            { Text = "Đang lưu cài đặt ", TopMost = true };
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa có, bạn chờ trong version sau nhé!");
        }
    }
}