using LearnEnglish.App.Services;
using LearnEnglish.App.Services.LearningSystem;
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

namespace LearnEnglish.App.GUI.Hoc
{
    public partial class frmHoc : Form
    {
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
            //var vocabs = this.topicIds.SelectMany(u => this.vocabRepository.ListVocabs(u)).ToList();
            //this.learningQueue.Prepare(vocabs);
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

        private void checkCurrentQuestion()
        {
            var question = this.learningQueue.CurrentQuestion();
            if (question.CheckAnswer(this.tbAnswer.Text))
            {
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
                this.learningQueue.OnWrongAnswer();
                this.resetCurrentQuestion();
                this.wrongCounter++;
                if (this.wrongCounter >= 3)
                {
                    MessageBox.Show("Đáp án là:\n" + this.learningQueue.CurrentQuestion().Answer);
                }
                else
                {
                    MessageBox.Show("Sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
