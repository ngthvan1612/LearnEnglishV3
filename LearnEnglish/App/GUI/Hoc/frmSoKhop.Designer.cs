namespace LearnEnglish.App.GUI.Hoc
{
    partial class frmSoKhop
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
            this.lbUserAnswer = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.lbJudgeAnswer = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.btnOK = new LearnEnglish.App.GUI.Components.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu trả lời của bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đáp án";
            // 
            // lbUserAnswer
            // 
            this.lbUserAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserAnswer.AutoSize = false;
            this.lbUserAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.lbUserAnswer.BaseStylesheet = null;
            this.lbUserAnswer.Location = new System.Drawing.Point(195, 22);
            this.lbUserAnswer.Name = "lbUserAnswer";
            this.lbUserAnswer.Size = new System.Drawing.Size(414, 65);
            this.lbUserAnswer.TabIndex = 3;
            this.lbUserAnswer.Text = "htmlLabel1";
            // 
            // lbJudgeAnswer
            // 
            this.lbJudgeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJudgeAnswer.AutoSize = false;
            this.lbJudgeAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.lbJudgeAnswer.BaseStylesheet = null;
            this.lbJudgeAnswer.Location = new System.Drawing.Point(195, 93);
            this.lbJudgeAnswer.Name = "lbJudgeAnswer";
            this.lbJudgeAnswer.Size = new System.Drawing.Size(414, 70);
            this.lbJudgeAnswer.TabIndex = 4;
            this.lbJudgeAnswer.Text = "htmlLabel2";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(243, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(142, 45);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSoKhop
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 218);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbJudgeAnswer);
            this.Controls.Add(this.lbUserAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmSoKhop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả sai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel lbUserAnswer;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel lbJudgeAnswer;
        private Components.RoundedButton btnOK;
    }
}