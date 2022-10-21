namespace LearnEnglish.App.GUI.Hoc
{
    partial class frmHoc
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lb01 = new System.Windows.Forms.Label();
            this.lbQuestionContent = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStatus.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lbStatus.Location = new System.Drawing.Point(0, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(929, 44);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Câu hỏi ?/?";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbAnswer);
            this.panel1.Controls.Add(this.lb01);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 48);
            this.panel1.TabIndex = 5;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbAnswer.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAnswer.Location = new System.Drawing.Point(120, 4);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(797, 39);
            this.tbAnswer.TabIndex = 5;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnswer_KeyPress);
            // 
            // lb01
            // 
            this.lb01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb01.AutoSize = true;
            this.lb01.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb01.Location = new System.Drawing.Point(12, 7);
            this.lb01.Name = "lb01";
            this.lb01.Size = new System.Drawing.Size(102, 33);
            this.lb01.TabIndex = 4;
            this.lb01.Text = "Trả lời";
            // 
            // lbQuestionContent
            // 
            this.lbQuestionContent.AutoSize = false;
            this.lbQuestionContent.BackColor = System.Drawing.SystemColors.Control;
            this.lbQuestionContent.BaseStylesheet = "";
            this.lbQuestionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuestionContent.Location = new System.Drawing.Point(0, 44);
            this.lbQuestionContent.Name = "lbQuestionContent";
            this.lbQuestionContent.Size = new System.Drawing.Size(929, 427);
            this.lbQuestionContent.TabIndex = 6;
            this.lbQuestionContent.Text = "<div><span style=\"foznt-family:Arial;font-size:3em;color:#ff0000;margin: 0 auto;\"" +
    ">World<br/>Hello</span></div>";
            // 
            // frmHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 519);
            this.Controls.Add(this.lbQuestionContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbStatus);
            this.MaximizeBox = false;
            this.Name = "frmHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbStatus;
        private Panel panel1;
        private TextBox tbAnswer;
        private Label lb01;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel lbQuestionContent;
    }
}