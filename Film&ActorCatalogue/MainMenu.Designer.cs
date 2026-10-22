namespace Programming_Assessment_Szu_Szu
{
    partial class MainMenu
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
            lblInfo = new Label();
            btnToFilmPage = new Button();
            btnToActorPage = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblInfo.ForeColor = Color.Snow;
            lblInfo.Location = new Point(357, 146);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(340, 46);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Choose Your Option";
            // 
            // btnToFilmPage
            // 
            btnToFilmPage.BackColor = Color.FromArgb(34, 34, 34);
            btnToFilmPage.Cursor = Cursors.Hand;
            btnToFilmPage.Font = new Font("Segoe UI Semilight", 15F, FontStyle.Bold);
            btnToFilmPage.ForeColor = Color.Snow;
            btnToFilmPage.Location = new Point(380, 217);
            btnToFilmPage.Name = "btnToFilmPage";
            btnToFilmPage.Size = new Size(287, 94);
            btnToFilmPage.TabIndex = 1;
            btnToFilmPage.Text = "Film";
            btnToFilmPage.UseVisualStyleBackColor = false;
            btnToFilmPage.Click += btnFilm_Click;
            // 
            // btnToActorPage
            // 
            btnToActorPage.BackColor = Color.FromArgb(34, 34, 34);
            btnToActorPage.Cursor = Cursors.Hand;
            btnToActorPage.Font = new Font("Segoe UI Semilight", 15F, FontStyle.Bold);
            btnToActorPage.ForeColor = Color.Snow;
            btnToActorPage.Location = new Point(380, 327);
            btnToActorPage.Name = "btnToActorPage";
            btnToActorPage.Size = new Size(287, 94);
            btnToActorPage.TabIndex = 2;
            btnToActorPage.Text = "Actor";
            btnToActorPage.UseVisualStyleBackColor = false;
            btnToActorPage.Click += btnActor_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1044, 627);
            Controls.Add(btnToActorPage);
            Controls.Add(btnToFilmPage);
            Controls.Add(lblInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnToFilmPage;
        private Button btnToActorPage;
    }
}
