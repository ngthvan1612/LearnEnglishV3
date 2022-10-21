namespace LearnEnglish.App.GUI.ChuDe
{
    partial class frmQuanLyChuDe
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
            this.pnListFolders = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewList = new System.Windows.Forms.PictureBox();
            this.btnAddNewFolder = new System.Windows.Forms.PictureBox();
            this.pnPath = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewFolder)).BeginInit();
            this.pnPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnListFolders
            // 
            this.pnListFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnListFolders.Location = new System.Drawing.Point(12, 47);
            this.pnListFolders.Name = "pnListFolders";
            this.pnListFolders.Size = new System.Drawing.Size(1008, 521);
            this.pnListFolders.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAddNewList);
            this.panel1.Controls.Add(this.btnAddNewFolder);
            this.panel1.Location = new System.Drawing.Point(12, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNewList
            // 
            this.btnAddNewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewList.Image = global::LearnEnglish.Properties.Resources.add_list;
            this.btnAddNewList.InitialImage = global::LearnEnglish.Properties.Resources.icons8_folder_48;
            this.btnAddNewList.Location = new System.Drawing.Point(914, 0);
            this.btnAddNewList.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNewList.Name = "btnAddNewList";
            this.btnAddNewList.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNewList.Size = new System.Drawing.Size(47, 43);
            this.btnAddNewList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNewList.TabIndex = 2;
            this.btnAddNewList.TabStop = false;
            this.btnAddNewList.Click += new System.EventHandler(this.btnAddNewList_Click);
            // 
            // btnAddNewFolder
            // 
            this.btnAddNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewFolder.Image = global::LearnEnglish.Properties.Resources.new_folder;
            this.btnAddNewFolder.InitialImage = global::LearnEnglish.Properties.Resources.icons8_folder_48;
            this.btnAddNewFolder.Location = new System.Drawing.Point(961, 0);
            this.btnAddNewFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewFolder.Name = "btnAddNewFolder";
            this.btnAddNewFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNewFolder.Size = new System.Drawing.Size(47, 43);
            this.btnAddNewFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNewFolder.TabIndex = 1;
            this.btnAddNewFolder.TabStop = false;
            this.btnAddNewFolder.Click += new System.EventHandler(this.btnAddNewFolder_Click);
            // 
            // pnPath
            // 
            this.pnPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPath.Controls.Add(this.pictureBox1);
            this.pnPath.Location = new System.Drawing.Point(12, 11);
            this.pnPath.Name = "pnPath";
            this.pnPath.Size = new System.Drawing.Size(1008, 30);
            this.pnPath.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LearnEnglish.Properties.Resources.new_folder;
            this.pictureBox1.InitialImage = global::LearnEnglish.Properties.Resources.icons8_folder_48;
            this.pictureBox1.Location = new System.Drawing.Point(1538, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1032, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressStatus
            // 
            this.progressStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.Size = new System.Drawing.Size(100, 17);
            this.progressStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(32, 19);
            this.statusLabel.Text = "OK";
            // 
            // frmQuanLyChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 644);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnPath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnListFolders);
            this.Name = "frmQuanLyChuDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chủ đề";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewFolder)).EndInit();
            this.pnPath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnListFolders;
        private Panel panel1;
        private PictureBox btnAddNewFolder;
        private Panel pnPath;
        private PictureBox pictureBox1;
        private PictureBox btnAddNewList;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar progressStatus;
        private ToolStripStatusLabel statusLabel;
    }
}