using LearnEnglish.Domain.Aggregate.TopicTrees;
using LearnEnglish.Domain.Aggregate.Vocabs;
using LearnEnglish.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.App.GUI.ChuDe
{
    public partial class frmDanhSachTuVung : Form
    {
        private readonly IVocabRepository vocabRepository;
        private TopicTree topicTreeParent;

        public frmDanhSachTuVung(TopicTree topicTreeParent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.vocabRepository = new VocabRepository();
            this.topicTreeParent = topicTreeParent;
            this.reloadListVocabs();
        }

        private void redesignDgvVocabs()
        {
            this.dgvVocabs.Columns[nameof(VocabView.Order)].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvVocabs.Columns[nameof(VocabView.English)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVocabs.Columns[nameof(VocabView.Vietnam)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void reloadListVocabs()
        {
            this.dgvVocabs.DataSource = null;
            this.dgvVocabs.DataSource = this.vocabRepository.listVocabsByTopicId(this.topicTreeParent.Id);
            this.redesignDgvVocabs();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmThemTuVung();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.vocabRepository.addVocab(Vocab.createVocab(frm.English, frm.Vietnam, frm.Audio, this.topicTreeParent.Id));
                this.reloadListVocabs();
                this.dgvVocabs.Rows[this.dgvVocabs.Rows.Count - 1].Selected = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.dgvVocabs.SelectedRows.Count == 1)
            {
                VocabView vocab = this.dgvVocabs.SelectedRows[0].DataBoundItem as VocabView;
                var frm = new frmSuaTuVung(vocab.English, vocab.Vietnam);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var curIndex = this.dgvVocabs.SelectedRows[0].Index;
                    this.vocabRepository.updateEngAndVie(new Vocab() { Id = vocab.Id, Eng = frm.English, Vie = frm.Vietnam });
                    if (frm.Audio != null)
                        this.vocabRepository.updateAudio(new Vocab() { Id = vocab.Id, Audio = frm.Audio });
                    this.reloadListVocabs();

                    foreach (DataGridViewRow row in this.dgvVocabs.Rows)
                        row.Selected = false;
                    this.dgvVocabs.Rows[curIndex].Selected = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnNghe_Click(object sender, EventArgs e)
        {
            if (this.dgvVocabs.SelectedRows.Count == 1)
            {
                try
                {
                    VocabView vocab = this.dgvVocabs.SelectedRows[0].DataBoundItem as VocabView;
                    SoundPlayer player = new SoundPlayer(new MemoryStream(vocab.Audio));
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phát âm thanh lỗi\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                this.btnThem_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
