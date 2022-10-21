namespace LearnEnglish.App.GUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDsChuDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTuVung = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.hocjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLearning = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.nhậpXuấtToolStripMenuItem,
            this.hocjToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDsChuDe,
            this.menuTuVung});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // menuDsChuDe
            // 
            this.menuDsChuDe.Name = "menuDsChuDe";
            this.menuDsChuDe.Size = new System.Drawing.Size(208, 26);
            this.menuDsChuDe.Text = "Danh sách chủ đề";
            this.menuDsChuDe.Click += new System.EventHandler(this.menuDsChuDe_Click);
            // 
            // menuTuVung
            // 
            this.menuTuVung.Name = "menuTuVung";
            this.menuTuVung.Size = new System.Drawing.Size(208, 26);
            this.menuTuVung.Text = "Từ vựng";
            this.menuTuVung.Click += new System.EventHandler(this.menuTuVung_Click);
            // 
            // nhậpXuấtToolStripMenuItem
            // 
            this.nhậpXuấtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImport,
            this.menuExport});
            this.nhậpXuấtToolStripMenuItem.Name = "nhậpXuấtToolStripMenuItem";
            this.nhậpXuấtToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.nhậpXuấtToolStripMenuItem.Text = "Nhập / xuất";
            // 
            // menuImport
            // 
            this.menuImport.Name = "menuImport";
            this.menuImport.Size = new System.Drawing.Size(128, 26);
            this.menuImport.Text = "Nhập";
            this.menuImport.Click += new System.EventHandler(this.menuImport_Click);
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(128, 26);
            this.menuExport.Text = "Xuất";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // hocjToolStripMenuItem
            // 
            this.hocjToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLearning});
            this.hocjToolStripMenuItem.Name = "hocjToolStripMenuItem";
            this.hocjToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.hocjToolStripMenuItem.Text = "Học";
            // 
            // menuLearning
            // 
            this.menuLearning.Name = "menuLearning";
            this.menuLearning.Size = new System.Drawing.Size(171, 26);
            this.menuLearning.Text = "Bắt đầu học";
            this.menuLearning.Click += new System.EventHandler(this.menuLearning_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LearnEnglish.Properties.Resources.luyen_thi_toeic_philippines_du_hoc_glolink_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm học từ vựng tiếng anh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem menuDsChuDe;
        private ToolStripMenuItem menuTuVung;
        private PictureBox pictureBox1;
        private ToolStripMenuItem nhậpXuấtToolStripMenuItem;
        private ToolStripMenuItem menuImport;
        private ToolStripMenuItem menuExport;
        private ToolStripMenuItem hocjToolStripMenuItem;
        private ToolStripMenuItem menuLearning;
    }
}