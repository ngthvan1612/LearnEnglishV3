using LearnEnglish.App.GUI.Support;
using LearnEnglish.App.Services;
using LearnEnglish.App.Services.LearningSystem;
using LearnEnglish.Domain.Aggregate.Vocabs;
using LearnEnglish.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;
using Transitions;

namespace LearnEnglish.App.GUI.Hoc
{
    public partial class frmHoc : Form
    {
        private readonly IVocabRepository vocabRepository = new VocabRepository();
        private readonly ILearningQueue learningQueue;
        private readonly List<int> topicIds;

        public frmHoc(List<int> listTopicIds, int numMean, int numLis)
        {
            InitializeComponent();

            this.ShowInTaskbar = false;

            this.learningQueue = new SimpleRepeatLearningQueue(numLis, numMean);
            this.topicIds = listTopicIds;
            this.prepareVocabs();

            this.resetCurrentQuestion();
        }

        private void prepareVocabs()
        {
            var vocabs = this.topicIds.SelectMany(u => this.vocabRepository.listVocabsByParentId(u)).ToList();
            frmLoading frm = new frmLoading(() => { this.learningQueue.Prepare(vocabs); });
            frm.Text = "Đang trộn câu hỏi";
            frm.ShowDialog();
        }

        private void updateProgress()
        {
            this.lbStatus.Text = $"{this.learningQueue.AnsweredQuestion() + 1}/{this.learningQueue.TotalQuestion()}";
        }

        private void resetCurrentQuestion()
        {
            var question = this.learningQueue.CurrentQuestion();
            this.lbQuestionContent.Text = question.QuestionHtml; ;
            this.updateProgress();
            this.learningQueue.OnBeforeAnswer();
            this.tbAnswer.Text = "";
        }

        private void onFinish()
        {
            MessageBox.Show("Học xong", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private int wrongCounter = 0;

        private void storeResult(int vocabId, string result)
        {
            this.vocabRepository.addResult(new Vocab() { Id = vocabId }, result);
        }

        private void checkCurrentQuestion()
        {
            var question = this.learningQueue.CurrentQuestion();
            if (question.CheckAnswer(this.tbAnswer.Text))
            {
                this.storeResult(question.GetId(), "OK");

                this.learningQueue.OnCorrentAnswer();

                if (this.learningQueue.AnsweredQuestion() + 1 == this.learningQueue.TotalQuestion())
                {
                    this.onFinish();
                    return;
                }

                this.learningQueue.MoveToNextQuestion();
                this.resetCurrentQuestion();
                this.updateProgress();
                this.wrongCounter = 0;

                this.tbAnswer.Text = "";
            }
            else
            {
                this.storeResult(question.GetId(), "FAIL");

                string userAnswer = this.tbAnswer.Text;
                this.learningQueue.OnWrongAnswer();
                this.resetCurrentQuestion();
                this.wrongCounter++;
                if (this.wrongCounter >= 3)
                {
                    new frmSoKhop(this.learningQueue.CurrentQuestion().Answer, userAnswer.Trim()).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai!", "Thông báo", MessageBoxButtons.OK);
                }
                this.tbAnswer.Text = "";
            }
        }

        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 10 || e.KeyChar == 13)
            {
                e.Handled = true;
                this.checkCurrentQuestion();
            }
        }
    }
}
