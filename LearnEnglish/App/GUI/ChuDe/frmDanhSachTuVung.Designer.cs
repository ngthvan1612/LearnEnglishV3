namespace LearnEnglish.App.GUI.ChuDe
{
    partial class frmDanhSachTuVung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEditVocab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoveAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNghe = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvVocabs = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocabs)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditVocab,
            this.menuRemoveAudio});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 52);
            // 
            // menuEditVocab
            // 
            this.menuEditVocab.Name = "menuEditVocab";
            this.menuEditVocab.Size = new System.Drawing.Size(170, 24);
            this.menuEditVocab.Text = "Chỉnh sửa";
            // 
            // menuRemoveAudio
            // 
            this.menuRemoveAudio.Name = "menuRemoveAudio";
            this.menuRemoveAudio.Size = new System.Drawing.Size(170, 24);
            this.menuRemoveAudio.Text = "Xóa âm thanh";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNghe);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 56);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnNghe
            // 
            this.btnNghe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNghe.Location = new System.Drawing.Point(595, 12);
            this.btnNghe.Name = "btnNghe";
            this.btnNghe.Size = new System.Drawing.Size(94, 32);
            this.btnNghe.TabIndex = 11;
            this.btnNghe.Text = "Nghe";
            this.btnNghe.UseVisualStyleBackColor = true;
            this.btnNghe.Click += new System.EventHandler(this.btnNghe_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(493, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(390, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 32);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(287, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvVocabs
            // 
            this.dgvVocabs.AllowUserToAddRows = false;
            this.dgvVocabs.AllowUserToDeleteRows = false;
            this.dgvVocabs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVocabs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVocabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVocabs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVocabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVocabs.Location = new System.Drawing.Point(0, 0);
            this.dgvVocabs.MultiSelect = false;
            this.dgvVocabs.Name = "dgvVocabs";
            this.dgvVocabs.ReadOnly = true;
            this.dgvVocabs.RowHeadersVisible = false;
            this.dgvVocabs.RowHeadersWidth = 51;
            this.dgvVocabs.RowTemplate.Height = 29;
            this.dgvVocabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVocabs.Size = new System.Drawing.Size(979, 592);
            this.dgvVocabs.TabIndex = 8;
            // 
            // frmDanhSachTuVung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 648);
            this.Controls.Add(this.dgvVocabs);
            this.Controls.Add(this.panel2);
            this.Name = "frmDanhSachTuVung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách từ vựng";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocabs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuEditVocab;
        private ToolStripMenuItem menuRemoveAudio;
        private Panel panel2;
        private Button btnNghe;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvVocabs;
    }
}