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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.pnPath = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnListFolders = new System.Windows.Forms.Panel();
            this.btnExport = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnAddList = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnAddFolder = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.btnExit = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.panel1.SuspendLayout();
            this.pnPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddFolder);
            this.panel1.Controls.Add(this.btnAddList);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 64);
            this.panel1.TabIndex = 2;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(157, 8);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(132, 46);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Nhập";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnPath
            // 
            this.pnPath.Controls.Add(this.pictureBox1);
            this.pnPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPath.Location = new System.Drawing.Point(0, 0);
            this.pnPath.Name = "pnPath";
            this.pnPath.Size = new System.Drawing.Size(1040, 30);
            this.pnPath.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LearnEnglish.Properties.Resources.new_folder;
            this.pictureBox1.InitialImage = global::LearnEnglish.Properties.Resources.icons8_folder_48;
            this.pictureBox1.Location = new System.Drawing.Point(1585, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnListFolders
            // 
            this.pnListFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnListFolders.Location = new System.Drawing.Point(0, 30);
            this.pnListFolders.Name = "pnListFolders";
            this.pnListFolders.Size = new System.Drawing.Size(1040, 550);
            this.pnListFolders.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(295, 8);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(132, 46);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddList.FlatAppearance.BorderSize = 0;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Location = new System.Drawing.Point(433, 9);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(173, 46);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Thêm danh sách";
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddNewList_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFolder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddFolder.FlatAppearance.BorderSize = 0;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFolder.ForeColor = System.Drawing.Color.White;
            this.btnAddFolder.Location = new System.Drawing.Point(612, 8);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(132, 46);
            this.btnAddFolder.TabIndex = 3;
            this.btnAddFolder.Text = "Thêm mục";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddNewFolder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(750, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // frmQuanLyChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1040, 644);
            this.Controls.Add(this.pnListFolders);
            this.Controls.Add(this.pnPath);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLyChuDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chủ đề";
            this.Load += new System.EventHandler(this.frmQuanLyChuDe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQuanLyChuDe_KeyDown);
            this.panel1.ResumeLayout(false);
            this.pnPath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel pnPath;
        private PictureBox pictureBox1;
        private Components.RoundedButton btnImport;
        private Panel pnListFolders;
        private Components.RoundedButton btnExit;
        private Components.RoundedButton btnAddFolder;
        private Components.RoundedButton btnAddList;
        private Components.RoundedButton btnExport;
    }
}