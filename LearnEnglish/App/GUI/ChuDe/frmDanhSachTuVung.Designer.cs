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
            this.ctxMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnSua = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnNghe = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnThem = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbPlayAudioWheneverClicked = new System.Windows.Forms.CheckBox();
            this.dgvVocabs = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocabs)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuCopy,
            this.ctxMenuPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ctxMenuCopy
            // 
            this.ctxMenuCopy.Name = "ctxMenuCopy";
            this.ctxMenuCopy.Size = new System.Drawing.Size(139, 24);
            this.ctxMenuCopy.Text = "Sao chép";
            this.ctxMenuCopy.Click += new System.EventHandler(this.ctxMenuCopy_Click);
            // 
            // ctxMenuPaste
            // 
            this.ctxMenuPaste.Name = "ctxMenuPaste";
            this.ctxMenuPaste.Size = new System.Drawing.Size(139, 24);
            this.ctxMenuPaste.Text = "Dán";
            this.ctxMenuPaste.Click += new System.EventHandler(this.ctxMenuPaste_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnNghe);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 135);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Gray;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(157, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 53);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(12, 65);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 53);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNghe
            // 
            this.btnNghe.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNghe.FlatAppearance.BorderSize = 0;
            this.btnNghe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghe.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNghe.ForeColor = System.Drawing.Color.White;
            this.btnNghe.Location = new System.Drawing.Point(157, 6);
            this.btnNghe.Name = "btnNghe";
            this.btnNghe.Size = new System.Drawing.Size(139, 53);
            this.btnNghe.TabIndex = 18;
            this.btnNghe.Text = "Nghe";
            this.btnNghe.UseVisualStyleBackColor = false;
            this.btnNghe.Click += new System.EventHandler(this.btnNghe_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(12, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 53);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.cbPlayAudioWheneverClicked);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(302, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 117);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(273, 26);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Chọn cùng lúc nhiều từ vựng";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbPlayAudioWheneverClicked
            // 
            this.cbPlayAudioWheneverClicked.AutoSize = true;
            this.cbPlayAudioWheneverClicked.Location = new System.Drawing.Point(25, 39);
            this.cbPlayAudioWheneverClicked.Name = "cbPlayAudioWheneverClicked";
            this.cbPlayAudioWheneverClicked.Size = new System.Drawing.Size(320, 26);
            this.cbPlayAudioWheneverClicked.TabIndex = 0;
            this.cbPlayAudioWheneverClicked.Text = "Click vào từ -> phát âm thanh ngay";
            this.cbPlayAudioWheneverClicked.UseVisualStyleBackColor = true;
            this.cbPlayAudioWheneverClicked.CheckedChanged += new System.EventHandler(this.cbPlayAudioWheneverClicked_CheckedChanged);
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
            this.dgvVocabs.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dgvVocabs.Size = new System.Drawing.Size(1012, 556);
            this.dgvVocabs.TabIndex = 8;
            this.dgvVocabs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVocabs_CellContentClick);
            this.dgvVocabs.Click += new System.EventHandler(this.dgvVocabs_Click);
            // 
            // frmDanhSachTuVung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 691);
            this.Controls.Add(this.dgvVocabs);
            this.Controls.Add(this.panel2);
            this.Name = "frmDanhSachTuVung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách từ vựng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachTuVung_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVocabs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private DataGridView dgvVocabs;
        private ToolStripMenuItem ctxMenuCopy;
        private ToolStripMenuItem ctxMenuPaste;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox cbPlayAudioWheneverClicked;
        private Components.RoundedButton btnThem;
        private Components.RoundedButton btnXoa;
        private Components.RoundedButton btnSua;
        private Components.RoundedButton btnNghe;
    }
}