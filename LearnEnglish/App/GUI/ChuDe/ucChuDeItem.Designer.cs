namespace LearnEnglish.App.GUI.ChuDe
{
    partial class ucChuDeItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbContent = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::LearnEnglish.Properties.Resources.icons8_folder_48;
            this.pictureBox1.InitialImage = global::LearnEnglish.Properties.Resources.icons8_folder_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ucChuDeItem_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.lbContent_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.lbContent_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucChuDeItem_MouseMove);
            // 
            // lbContent
            // 
            this.lbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContent.Location = new System.Drawing.Point(49, 3);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(314, 25);
            this.lbContent.TabIndex = 0;
            this.lbContent.TabStop = true;
            this.lbContent.Text = "Đề thi ETS 2019 - Test 1";
            this.lbContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbContent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbContent_LinkClicked);
            this.lbContent.MouseEnter += new System.EventHandler(this.ucChuDeItem_MouseEnter);
            this.lbContent.MouseLeave += new System.EventHandler(this.lbContent_MouseLeave);
            this.lbContent.MouseHover += new System.EventHandler(this.lbContent_MouseHover);
            this.lbContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucChuDeItem_MouseMove);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(550, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.ucChuDeItem_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.lbContent_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.lbContent_MouseHover);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucChuDeItem_MouseMove);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(481, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(63, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.ucChuDeItem_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.lbContent_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.lbContent_MouseHover);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucChuDeItem_MouseMove);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMove.Location = new System.Drawing.Point(369, 3);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(106, 25);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Di chuyển";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // ucChuDeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucChuDeItem";
            this.Size = new System.Drawing.Size(616, 31);
            this.Load += new System.EventHandler(this.ucChuDeItem_Load);
            this.MouseEnter += new System.EventHandler(this.ucChuDeItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lbContent_MouseLeave);
            this.MouseHover += new System.EventHandler(this.lbContent_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucChuDeItem_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel lbContent;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnMove;
    }
}
