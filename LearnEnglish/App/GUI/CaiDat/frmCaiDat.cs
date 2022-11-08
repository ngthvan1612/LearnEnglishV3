using LearnEnglish.Infrastructure.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.App.GUI.CaiDat
{
    public partial class frmCaiDat : Form
    {
        public frmCaiDat()
        {
            InitializeComponent();
        }

        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            this.tbSqlite3Conn.Text = ESetting.Setting.SqliteConnectionString;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ESetting.Setting.SqliteConnectionString = this.tbSqlite3Conn.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
