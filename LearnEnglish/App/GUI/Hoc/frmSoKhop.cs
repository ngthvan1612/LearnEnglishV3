using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.App.GUI.Hoc
{
    public partial class frmSoKhop : Form
    {
        public frmSoKhop(string judgeAnswer, string userAnswer)
        {
            InitializeComponent();

            int n = judgeAnswer.Length, m = userAnswer.Length;
            int[,] dp = new int[n + 1, m + 1];

            judgeAnswer = " " + judgeAnswer;
            userAnswer = " " + userAnswer;

            string fixJudgeAnswer = judgeAnswer.ToLower();
            string fixUserAnswer = userAnswer.ToLower();

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    if (fixJudgeAnswer[i] == fixUserAnswer[j])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                }
            }

            int u = n, v = m;
            bool[] markJudge = new bool[n];
            bool[] markUser = new bool[m];
            while (u > 0 && v > 0)
            {
                if (fixJudgeAnswer[u] == fixUserAnswer[v])
                {
                    markJudge[u - 1] = markUser[v - 1] = true;
                    u--;
                    v--;
                }
                else
                {
                    if (dp[u - 1, v] > dp[u, v - 1])
                        u--;
                    else
                        v--;
                }
            }

            judgeAnswer = judgeAnswer.Substring(1);
            userAnswer = userAnswer.Substring(1);

            string innerHtmlJudge = "";

            for (int i = 0; i < n;)
            {
                int j = i;
                while (j < n && markJudge[i] == markJudge[j])
                {
                    ++j;
                }
                if (markJudge[i])
                {
                    innerHtmlJudge += $"<span style='color:black;'>{judgeAnswer.Substring(i, j - i)}</span>";
                }
                else
                {
                    innerHtmlJudge += $"<span style='color:black;'>{judgeAnswer.Substring(i, j - i)}</span>";
                }
                i = j;
            }

            this.lbJudgeAnswer.Text = @$"
<div style='font-size:20px;font-family:Arial'>
    {innerHtmlJudge}
</div>
";
            this.lbUserAnswer.Text = @$"
<div style='font-size:20px;font-family:Arial'>
    <span>{userAnswer}</span>
</div>
";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
