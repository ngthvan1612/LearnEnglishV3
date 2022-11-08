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

using LearnEnglish.Infrastructure.Clipboard;
using LearnEnglish.App.GUI.Support;

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
            this.dgvVocabs.DataSource = this.vocabRepository.listVocabViewsByParentId(this.topicTreeParent.Id);
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
            if (this.dgvVocabs.SelectedRows.Count > 0)
            {
                var answer = MessageBox.Show($"Bạn có chắc chắc muốn xóa từ này?\nTổng cộng {this.dgvVocabs.SelectedRows.Count} từ sẽ bị xóa",
                    "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (answer == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dgvVocabs.SelectedRows)
                    {
                        VocabView vocab = row.DataBoundItem as VocabView;

                        this.vocabRepository.deleteVocab(new Vocab() { Id = vocab.Id });
                    }
                    this.reloadListVocabs();
                }
            }
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

        private void ctxMenuCopy_Click(object sender, EventArgs e)
        {
            if (this.dgvVocabs.SelectedRows.Count > 0)
            {
                List<Vocab> selections = new List<Vocab>();
                for (int i = 0; i < this.dgvVocabs.SelectedRows.Count; ++i)
                {
                    var data = this.dgvVocabs.SelectedRows[i].DataBoundItem as VocabView;
                    selections.Add(new Vocab()
                    {
                        Eng = data.English,
                        Vie = data.Vietnam,
                        Audio = data.Audio
                    }); 
                }
                ClipboardDatabase.Data = selections;
            }
            else
            {
                ClipboardDatabase.Data = null;
            }
        }

        private void ctxMenuPaste_Click(object sender, EventArgs e)
        {
            if (ClipboardDatabase.Data is List<Vocab>)
            {
                var selections = ClipboardDatabase.Data as List<Vocab>;
                Action createVocabs = () =>
                {
                    foreach (var vocab in selections)
                    {
                        this.vocabRepository.addVocab(Vocab.createVocab(vocab.Eng, vocab.Vie, vocab.Audio, this.topicTreeParent.Id));
                    }
                };
                frmLoading frm = new frmLoading(createVocabs);
                frm.Text = $"Đang dán {selections.Count} từ vựng";
                frm.ShowDialog();
                this.reloadListVocabs();
                Application.DoEvents();
                MessageBox.Show($"Dán hoàn tất {selections.Count} từ vựng", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.ctxMenuCopy.Enabled = this.dgvVocabs.SelectedRows.Count > 0;
            this.ctxMenuPaste.Enabled = (ClipboardDatabase.Data is List<Vocab>) && (ClipboardDatabase.Data as List<Vocab>).Count > 0;
        }

        private void cbPlayAudioWheneverClicked_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvVocabs.MultiSelect = (sender as CheckBox).Checked;
        }

        private void dgvVocabs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvVocabs.SelectedRows.Count > 0 && this.cbPlayAudioWheneverClicked.Checked)
            {
                var vocab = this.dgvVocabs.SelectedRows[0].DataBoundItem as VocabView;
                SoundPlayer player = new SoundPlayer(new MemoryStream(vocab.Audio));
                player.Play();
            }
        }

        private void dgvVocabs_Click(object sender, EventArgs e)
        {
            this.dgvVocabs_CellContentClick(null, null);
        }

        private void frmDanhSachTuVung_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dgvVocabs.Dispose();
        }
    }
}
