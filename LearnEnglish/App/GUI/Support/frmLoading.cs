using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.App.GUI.Support
{
    public partial class frmLoading : Form
    {
        private Action backgroundTask;
        private bool canExit = false;

        public frmLoading(Action backgroundTask)
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
            this.backgroundTask = backgroundTask;
            Task pTask = new Task(this.backgroundTask);
            pTask.ContinueWith((fTask) =>
            {
                this.canExit = true;
                try
                {
                    this.BeginInvoke(new MethodInvoker(Close));
                }
                catch { }
            });
            pTask.Start();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            if (this.canExit)
            {
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }
    }
}
