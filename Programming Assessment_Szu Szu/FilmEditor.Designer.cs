namespace Programming_Assessment_Szu_Szu
{
    partial class FilmEditor
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
            lblInfo = new Label();
            nudRating = new NumericUpDown();
            btnDone = new Button();
            lblRating = new Label();
            lblGenre = new Label();
            lblFilmTitle = new Label();
            txtGenre = new TextBox();
            txtFilmTitle = new TextBox();
            lblTitle = new Label();
            lblYear = new Label();
            lblCast = new Label();
            txtCast = new TextBox();
            nudYear = new NumericUpDown();
            lblWarning = new Label();
            undoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.Snow;
            lblInfo.Location = new Point(175, 539);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(249, 23);
            lblInfo.TabIndex = 18;
            lblInfo.Text = "Note: Cast(s) cannot be edited ";
            // 
            // nudRating
            // 
            nudRating.Location = new Point(202, 369);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(239, 29);
            nudRating.TabIndex = 17;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(34, 34, 34);
            btnDone.Cursor = Cursors.Hand;
            btnDone.ForeColor = Color.Snow;
            btnDone.Location = new Point(234, 445);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(128, 45);
            btnDone.TabIndex = 16;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.ForeColor = Color.Snow;
            lblRating.Location = new Point(120, 369);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(58, 21);
            lblRating.TabIndex = 15;
            lblRating.Text = "Rating:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.ForeColor = Color.Snow;
            lblGenre.Location = new Point(106, 210);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(72, 21);
            lblGenre.TabIndex = 14;
            lblGenre.Text = "Genre(s):";
            // 
            // lblFilmTitle
            // 
            lblFilmTitle.AutoSize = true;
            lblFilmTitle.ForeColor = Color.Snow;
            lblFilmTitle.Location = new Point(132, 158);
            lblFilmTitle.Name = "lblFilmTitle";
            lblFilmTitle.Size = new Size(46, 21);
            lblFilmTitle.TabIndex = 13;
            lblFilmTitle.Text = "Title: ";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(202, 210);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(239, 29);
            txtGenre.TabIndex = 12;
            // 
            // txtFilmTitle
            // 
            txtFilmTitle.Location = new Point(202, 158);
            txtFilmTitle.Name = "txtFilmTitle";
            txtFilmTitle.Size = new Size(239, 29);
            txtFilmTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(247, 66);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 46);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Edit";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.ForeColor = Color.Snow;
            lblYear.Location = new Point(78, 313);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(100, 21);
            lblYear.TabIndex = 22;
            lblYear.Text = "Release Year:";
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.ForeColor = Color.Snow;
            lblCast.Location = new Point(114, 261);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(64, 21);
            lblCast.TabIndex = 21;
            lblCast.Text = "Cast(s): ";
            // 
            // txtCast
            // 
            txtCast.Enabled = false;
            txtCast.Location = new Point(202, 261);
            txtCast.Name = "txtCast";
            txtCast.ReadOnly = true;
            txtCast.Size = new Size(239, 29);
            txtCast.TabIndex = 19;
            // 
            // nudYear
            // 
            nudYear.Location = new Point(202, 314);
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(239, 29);
            nudYear.TabIndex = 23;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(211, 508);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 23);
            lblWarning.TabIndex = 24;
            // 
            // undoBtn
            // 
            undoBtn.BackColor = Color.FromArgb(34, 34, 34);
            undoBtn.BackgroundImage = Properties.Resources._return;
            undoBtn.BackgroundImageLayout = ImageLayout.Zoom;
            undoBtn.FlatAppearance.BorderSize = 0;
            undoBtn.Location = new Point(12, 12);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(45, 45);
            undoBtn.TabIndex = 25;
            undoBtn.UseVisualStyleBackColor = false;
            undoBtn.Click += undoBtn_Click;
            // 
            // FilmEditor
            // 
            AcceptButton = btnDone;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(559, 584);
            Controls.Add(undoBtn);
            Controls.Add(lblWarning);
            Controls.Add(nudYear);
            Controls.Add(lblYear);
            Controls.Add(lblCast);
            Controls.Add(txtCast);
            Controls.Add(lblInfo);
            Controls.Add(nudRating);
            Controls.Add(btnDone);
            Controls.Add(lblRating);
            Controls.Add(lblGenre);
            Controls.Add(lblFilmTitle);
            Controls.Add(txtGenre);
            Controls.Add(txtFilmTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(577, 631);
            Name = "FilmEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Film";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private NumericUpDown nudRating;
        private Button btnDone;
        private Label lblRating;
        private Label lblGenre;
        private Label lblFilmTitle;
        private TextBox txtGenre;
        private TextBox txtFilmTitle;
        private Label lblTitle;
        private Label lblYear;
        private Label lblCast;
        private TextBox txtCast;
        private NumericUpDown nudYear;
        private Label lblWarning;
        private Button undoBtn;
    }
}