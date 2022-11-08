using LearnEnglish.App.GUI.Support;
using LearnEnglish.Infrastructure.Audio.Fetching;
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
    public partial class frmSuaTuVung : Form
    {
        private readonly IFetchAudio engine = new RealCloudNet();

        public frmSuaTuVung(string eng, string vie)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.tbEng.Text = eng;
            this.tbVie.Text = vie;
        }

        private void frmSuaTuVung_Load(object sender, EventArgs e)
        {

        }

        public string English => this.tbEng.Text.Trim();
        public string Vietnam => this.tbVie.Text.Trim();
        public byte[] Audio { get; set; } = null;

        private void button1_Click(object sender, EventArgs e)
        {
            string eng = English;
            string vie = Vietnam;

            if (string.IsNullOrEmpty(eng))
            {
                MessageBox.Show("Từ tiếng anh không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(vie))
            {
                MessageBox.Show("Từ tiếng việt không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.rbUpdateOnline.Checked)
            {
                bool ok = false;
                Action fetchAudio = () =>
                {
                    try
                    {
                        engine.Prepare(this.English.Replace("=", ". "));
                        byte[] audio = engine.DownloadWAV();
                        ok = true;
                        this.Audio = audio;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Tải file về gặp lỗi\n" + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                new frmLoading(fetchAudio) { Text = "Đang tải âm thanh về" }.ShowDialog();
                if (!ok) return;
            }
            else if (this.rbUpdateFromFile.Checked)
            {
                if (!File.Exists(this.tbFilename.Text))
                {
                    MessageBox.Show("File không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    this.Audio = File.ReadAllBytes(this.tbFilename.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không đọc được file", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "WAV file (*.wav)|*.wav";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.tbFilename.Text = dlg.FileName;
                }
            }
        }
    }
}
