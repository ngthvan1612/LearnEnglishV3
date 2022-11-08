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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKe = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnCaiDat = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnHoc = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnQuanLyTuVung = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnCaiDat);
            this.panel1.Controls.Add(this.btnHoc);
            this.panel1.Controls.Add(this.btnQuanLyTuVung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 71);
            this.panel1.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThongKe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(675, 10);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(140, 50);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaiDat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCaiDat.FlatAppearance.BorderSize = 0;
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Location = new System.Drawing.Point(529, 10);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(140, 50);
            this.btnCaiDat.TabIndex = 2;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = false;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnHoc
            // 
            this.btnHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHoc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnHoc.FlatAppearance.BorderSize = 0;
            this.btnHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHoc.ForeColor = System.Drawing.Color.White;
            this.btnHoc.Location = new System.Drawing.Point(383, 10);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(140, 50);
            this.btnHoc.TabIndex = 1;
            this.btnHoc.Text = "Học";
            this.btnHoc.UseVisualStyleBackColor = false;
            this.btnHoc.Click += new System.EventHandler(this.btnHoc_Click);
            // 
            // btnQuanLyTuVung
            // 
            this.btnQuanLyTuVung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuanLyTuVung.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuanLyTuVung.FlatAppearance.BorderSize = 0;
            this.btnQuanLyTuVung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTuVung.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyTuVung.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTuVung.Location = new System.Drawing.Point(237, 10);
            this.btnQuanLyTuVung.Name = "btnQuanLyTuVung";
            this.btnQuanLyTuVung.Size = new System.Drawing.Size(140, 50);
            this.btnQuanLyTuVung.TabIndex = 0;
            this.btnQuanLyTuVung.Text = "Từ vựng";
            this.btnQuanLyTuVung.UseVisualStyleBackColor = false;
            this.btnQuanLyTuVung.Click += new System.EventHandler(this.btnQuanLyTuVung_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LearnEnglish.Properties.Resources.luyen_thi_toeic_philippines_du_hoc_glolink_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm học từ vựng tiếng anh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Components.RoundedButton btnQuanLyTuVung;
        private Components.RoundedButton btnCaiDat;
        private Components.RoundedButton btnHoc;
        private Components.RoundedButton btnThongKe;
    }
}