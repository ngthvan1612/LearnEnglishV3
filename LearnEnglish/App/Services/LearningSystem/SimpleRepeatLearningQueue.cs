using LearnEnglish.Domain.Aggregate.Vocabs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.App.Services.LearningSystem
{
    public class SimpleRepeatLearningQueue : ILearningQueue
    {
        private int _listeningCount, _meaningCount;
        private List<QuestionAbstract> questions;
        private int numberOfAnsweredQuestion;

        public SimpleRepeatLearningQueue(int listeningCount, int meaningCount)
        {
            this._listeningCount = listeningCount;
            this._meaningCount = meaningCount;
        }

        public void OnCorrentAnswer()
        {
            var question = this.CurrentQuestion();
            //vocabRepository.AddStatus(question.GetId(), "CORRECT");
            question.PlayAudioSync();
        }

        public void OnWrongAnswer()
        {
            var question = this.CurrentQuestion();
            //vocabRepository.AddStatus(question.GetId(), "WRONG");
        }

        public int AnsweredQuestion()
        {
            return this.numberOfAnsweredQuestion;
        }

        public void OnBeforeAnswer()
        {
            var question = this.CurrentQuestion();
            if (question is ListeningQuestion)
            {
                question.PlayAudio();
            }
        }

        public bool CheckAnswer(string answer)
        {
            return this.CurrentQuestion().CheckAnswer(answer);
        }

        public QuestionAbstract CurrentQuestion()
        {
            return this.questions[this.numberOfAnsweredQuestion];
        }

        public QuestionAbstract MoveToNextQuestion()
        {
            this.numberOfAnsweredQuestion++;
            return this.questions[this.numberOfAnsweredQuestion];
        }

        private static void ShuffleList<T>(List<T> list)
            where T : QuestionAbstract
        {
            
            Func<int, bool> checkNearest = (i) =>
            {
                if (i > 0 && list[i].IsEqual(list[i - 1]))
                    return false;
                if (i + 1 < list.Count && list[i].IsEqual(list[i + 1]))
                    return false;
                return true;
            };

            Action<int, int> swap = (i, j) =>
            {
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            };

            int n = list.Count;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int step = 0; step < (1 << 4); ++step)
            {
                for (int i = 0; i < n; ++i)
                {
                    int j = random.Next() % n;
                    swap(i, j);
                }
            }
        }

        public void Prepare(IEnumerable<Vocab> questions)
        {
            this.questions = new List<QuestionAbstract>();
            for (int i = 0; i < this._listeningCount; ++i)
            {
                var batch = questions.Select(u => new ListeningQuestion(u)).ToList();
                ShuffleList(batch);
                this.questions.AddRange(batch);
            }
            for (int i = 0; i < this._meaningCount; ++i)
            {
                var batch = questions.Select(u => new MeaningQuestion(u)).ToList();
                ShuffleList(batch);
                this.questions.AddRange(batch);
            }
            for (int step = 0; step < 127; ++step)
            {
                ShuffleList(this.questions);
                bool ok = true;
                for (int i = 0; i < this.questions.Count - 1; ++i)
                {
                    ok &= !this.questions[i].IsEqual(this.questions[i + 1]);
                }
                if (ok) break;
            }
        }

        private static void ShuffleListGA<T>(List<T> source) where T : QuestionAbstract
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Func<List<T>, int, List<T>> shuffle = (a, step) =>
            {
                for (int i = 0; i < step; ++i)
                {
                    int u = random.Next() % a.Count, v = random.Next() % a.Count;
                    T temp = a[u];
                    a[u] = a[v];
                    a[v] = temp;
                }
                return a;
            };
            List<List<T>> population = new List<List<T>>();
            for (int i = 0; i < 100; ++i)
            {
                var gnome = new List<T>(source.Select(u => u).ToList());
                ShuffleList(gnome);
                population.Add(gnome);
            }
            Func<List<T>, double> fitness = (gnome) =>
            {
                double res = 0.0;
                bool[] mark = new bool[gnome.Count];
                for (int i = 0; i < gnome.Count; ++i)
                {
                    if (mark[i])
                    {
                        continue;
                    }
                    List<int> positions = new List<int>();
                    for (int j = 0; j < gnome.Count; ++j)
                    {
                        if (gnome[i].IsEqual(gnome[j]))
                        {
                            positions.Add(j);
                            mark[j] = true;
                        }
                    }
                    double temp = 0;
                    for (int j = 0; j < positions.Count - 1; ++j)
                    {
                        temp += 1.0 / Math.Pow(positions[j + 1] - positions[j] + 1 + 1.0 / positions[j] + (1.0 + Math.Log(j + 2)) / positions[j + 1], 2.0);
                    }
                    if (temp > 0)
                    {
                        res += -1.0 / Math.Log(temp);
                    }
                }
                return res;
            };
            for (int state = 0; state < 1000; ++state)
            {
                Debug.WriteLine("BEST FITNESS: {0}", fitness(population[0]));
                population.Sort((a, b) =>
                {
                    double fa = fitness(a), fb = fitness(b);
                    if (fa < fb) return -1;
                    else if (fa > fb) return +1;
                    return 0;
                });
                List<List<T>> newPopulation = new List<List<T>>();
                int keep = 20;
                for (int i = 0; i < keep; ++i)
                {
                    newPopulation.Add(population[i]);
                }
                for (int i = 0; i < population.Count - keep; ++i)
                {
                    var gnome = population[random.Next() % keep].Select(u => u).ToList();
                    shuffle(gnome, 10);
                    newPopulation.Add(gnome);
                }
                population = newPopulation;
            }
            for (int i = 0; i < source.Count; ++i)
            {
                source[i] = population[0][i];
            }
        }

        public int TotalQuestion()
        {
            return this.questions.Count;
        }
    }
}
