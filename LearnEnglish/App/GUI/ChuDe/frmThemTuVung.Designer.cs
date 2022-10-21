namespace LearnEnglish.App.GUI.ChuDe
{
    partial class frmThemTuVung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbVie = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.rbUpdateFromFile = new System.Windows.Forms.RadioButton();
            this.rbUpdateOnline = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiếng anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiếng việt";
            // 
            // tbEng
            // 
            this.tbEng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEng.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEng.Location = new System.Drawing.Point(111, 22);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(600, 30);
            this.tbEng.TabIndex = 2;
            // 
            // tbVie
            // 
            this.tbVie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbVie.Location = new System.Drawing.Point(111, 73);
            this.tbVie.Name = "tbVie";
            this.tbVie.Size = new System.Drawing.Size(600, 30);
            this.tbVie.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnChooseFile);
            this.groupBox1.Controls.Add(this.tbFilename);
            this.groupBox1.Controls.Add(this.rbUpdateFromFile);
            this.groupBox1.Controls.Add(this.rbUpdateOnline);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Âm thanh";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFile.Location = new System.Drawing.Point(643, 85);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(47, 29);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilename.Location = new System.Drawing.Point(119, 83);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(518, 30);
            this.tbFilename.TabIndex = 2;
            // 
            // rbUpdateFromFile
            // 
            this.rbUpdateFromFile.AutoSize = true;
            this.rbUpdateFromFile.Location = new System.Drawing.Point(6, 84);
            this.rbUpdateFromFile.Name = "rbUpdateFromFile";
            this.rbUpdateFromFile.Size = new System.Drawing.Size(107, 27);
            this.rbUpdateFromFile.TabIndex = 1;
            this.rbUpdateFromFile.TabStop = true;
            this.rbUpdateFromFile.Text = "Chọn file";
            this.rbUpdateFromFile.UseVisualStyleBackColor = true;
            // 
            // rbUpdateOnline
            // 
            this.rbUpdateOnline.AutoSize = true;
            this.rbUpdateOnline.Checked = true;
            this.rbUpdateOnline.Location = new System.Drawing.Point(6, 40);
            this.rbUpdateOnline.Name = "rbUpdateOnline";
            this.rbUpdateOnline.Size = new System.Drawing.Size(276, 27);
            this.rbUpdateOnline.TabIndex = 0;
            this.rbUpdateOnline.TabStop = true;
            this.rbUpdateOnline.Text = "Cập nhật online từ tiếng anh";
            this.rbUpdateOnline.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(311, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCreateVocabClicked);
            // 
            // frmThemTuVung
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbVie);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemTuVung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm từ vựng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbEng;
        private TextBox tbVie;
        private GroupBox groupBox1;
        private RadioButton rbUpdateFromFile;
        private RadioButton rbUpdateOnline;
        private Button button1;
        private Button btnChooseFile;
        private TextBox tbFilename;
    }
}