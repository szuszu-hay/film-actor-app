namespace Programming_Assessment_Szu_Szu
{
    partial class AddFilmForm
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
            lblAddFilm = new Label();
            btnAdd = new Button();
            lbxDisplayActors = new ListBox();
            lblWarning = new Label();
            pbMenuBtn = new PictureBox();
            pbPreviousPage = new PictureBox();
            lblGuide = new Label();
            lblTitle = new Label();
            nudAddFilmRating = new NumericUpDown();
            lblAddGenre = new Label();
            txtAddGenre = new TextBox();
            lblAddCast = new Label();
            txtAddCast = new TextBox();
            lblReleaseYear = new Label();
            lblAddFilmRating = new Label();
            nudAddYear = new NumericUpDown();
            txtAddTitle = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnClear = new Button();
            lblInfo = new Label();
            pbFilm1 = new PictureBox();
            pbFilm2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbMenuBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPreviousPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFilmRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAddYear).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFilm1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFilm2).BeginInit();
            SuspendLayout();
            // 
            // lblAddFilm
            // 
            lblAddFilm.AutoSize = true;
            lblAddFilm.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddFilm.ForeColor = Color.Snow;
            lblAddFilm.Location = new Point(449, 95);
            lblAddFilm.Name = "lblAddFilm";
            lblAddFilm.Size = new Size(164, 46);
            lblAddFilm.TabIndex = 1;
            lblAddFilm.Text = "Add Film";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(34, 34, 34);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(537, 482);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(59, 54);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxDisplayActors
            // 
            lbxDisplayActors.BackColor = Color.FromArgb(34, 34, 34);
            lbxDisplayActors.ForeColor = Color.Snow;
            lbxDisplayActors.FormattingEnabled = true;
            lbxDisplayActors.Location = new Point(752, 170);
            lbxDisplayActors.Name = "lbxDisplayActors";
            lbxDisplayActors.Size = new Size(214, 256);
            lbxDisplayActors.TabIndex = 14;
            lbxDisplayActors.SelectedIndexChanged += lbxDisplayActors_SelectedIndexChanged;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(307, 499);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 21);
            lblWarning.TabIndex = 15;
            // 
            // pbMenuBtn
            // 
            pbMenuBtn.BackColor = Color.FromArgb(34, 34, 34);
            pbMenuBtn.BackgroundImage = Properties.Resources.home_icon;
            pbMenuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbMenuBtn.Location = new Point(989, 1);
            pbMenuBtn.Name = "pbMenuBtn";
            pbMenuBtn.Size = new Size(40, 40);
            pbMenuBtn.TabIndex = 16;
            pbMenuBtn.TabStop = false;
            pbMenuBtn.Click += pbMenuBtn_Click;
            // 
            // pbPreviousPage
            // 
            pbPreviousPage.BackColor = Color.FromArgb(34, 34, 34);
            pbPreviousPage.BackgroundImage = Properties.Resources.back_arrow_previous1;
            pbPreviousPage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPreviousPage.Location = new Point(0, 1);
            pbPreviousPage.Name = "pbPreviousPage";
            pbPreviousPage.Size = new Size(40, 40);
            pbPreviousPage.TabIndex = 17;
            pbPreviousPage.TabStop = false;
            pbPreviousPage.Click += pbPreviousPage_Click;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("Segoe UI", 9.6F, FontStyle.Italic);
            lblGuide.ForeColor = SystemColors.ActiveCaption;
            lblGuide.Location = new Point(215, 550);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(0, 21);
            lblGuide.TabIndex = 18;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(326, 185);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title:";
            // 
            // nudAddFilmRating
            // 
            nudAddFilmRating.BackColor = Color.FromArgb(34, 34, 34);
            nudAddFilmRating.ForeColor = Color.Snow;
            nudAddFilmRating.Location = new Point(400, 418);
            nudAddFilmRating.Name = "nudAddFilmRating";
            nudAddFilmRating.Size = new Size(261, 29);
            nudAddFilmRating.TabIndex = 11;
            // 
            // lblAddGenre
            // 
            lblAddGenre.AutoSize = true;
            lblAddGenre.ForeColor = Color.Snow;
            lblAddGenre.Location = new Point(296, 237);
            lblAddGenre.Name = "lblAddGenre";
            lblAddGenre.Size = new Size(72, 21);
            lblAddGenre.TabIndex = 4;
            lblAddGenre.Text = "Genre(s):";
            // 
            // txtAddGenre
            // 
            txtAddGenre.BackColor = Color.FromArgb(34, 34, 34);
            txtAddGenre.ForeColor = Color.Snow;
            txtAddGenre.Location = new Point(400, 234);
            txtAddGenre.Name = "txtAddGenre";
            txtAddGenre.Size = new Size(261, 29);
            txtAddGenre.TabIndex = 5;
            // 
            // lblAddCast
            // 
            lblAddCast.AutoSize = true;
            lblAddCast.ForeColor = Color.Snow;
            lblAddCast.Location = new Point(308, 317);
            lblAddCast.Name = "lblAddCast";
            lblAddCast.Size = new Size(60, 21);
            lblAddCast.TabIndex = 6;
            lblAddCast.Text = "Cast(s):";
            // 
            // txtAddCast
            // 
            txtAddCast.BackColor = Color.FromArgb(34, 34, 34);
            txtAddCast.ForeColor = Color.Snow;
            txtAddCast.Location = new Point(400, 314);
            txtAddCast.Name = "txtAddCast";
            txtAddCast.Size = new Size(261, 29);
            txtAddCast.TabIndex = 7;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.ForeColor = Color.Snow;
            lblReleaseYear.Location = new Point(271, 368);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(100, 21);
            lblReleaseYear.TabIndex = 8;
            lblReleaseYear.Text = "Release Year:";
            // 
            // lblAddFilmRating
            // 
            lblAddFilmRating.AutoSize = true;
            lblAddFilmRating.ForeColor = Color.Snow;
            lblAddFilmRating.Location = new Point(313, 425);
            lblAddFilmRating.Name = "lblAddFilmRating";
            lblAddFilmRating.Size = new Size(58, 21);
            lblAddFilmRating.TabIndex = 9;
            lblAddFilmRating.Text = "Rating:";
            // 
            // nudAddYear
            // 
            nudAddYear.BackColor = Color.FromArgb(34, 34, 34);
            nudAddYear.ForeColor = Color.Snow;
            nudAddYear.Location = new Point(400, 366);
            nudAddYear.Name = "nudAddYear";
            nudAddYear.Size = new Size(261, 29);
            nudAddYear.TabIndex = 10;
            // 
            // txtAddTitle
            // 
            txtAddTitle.BackColor = Color.FromArgb(34, 34, 34);
            txtAddTitle.ForeColor = Color.Snow;
            txtAddTitle.Location = new Point(400, 182);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(261, 29);
            txtAddTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label1.ForeColor = Color.Pink;
            label1.Location = new Point(400, 283);
            label1.Name = "label1";
            label1.Size = new Size(242, 19);
            label1.TabIndex = 19;
            label1.Text = "* Hint: Add or Select Cast(s) From List";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pbMenuBtn);
            panel1.Controls.Add(pbPreviousPage);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 40);
            panel1.TabIndex = 21;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(34, 34, 34);
            btnClear.BackgroundImage = Properties.Resources.ClearIcon;
            btnClear.BackgroundImageLayout = ImageLayout.Zoom;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(602, 482);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 54);
            btnClear.TabIndex = 43;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.LightGray;
            lblInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.FromArgb(34, 34, 34);
            lblInfo.Location = new Point(755, 135);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(167, 20);
            lblInfo.TabIndex = 44;
            lblInfo.Text = "Actors Available on List";
            // 
            // pbFilm1
            // 
            pbFilm1.BackgroundImage = Properties.Resources.films;
            pbFilm1.BackgroundImageLayout = ImageLayout.Zoom;
            pbFilm1.Location = new Point(752, 420);
            pbFilm1.Name = "pbFilm1";
            pbFilm1.Size = new Size(223, 152);
            pbFilm1.TabIndex = 45;
            pbFilm1.TabStop = false;
            // 
            // pbFilm2
            // 
            pbFilm2.BackgroundImage = Properties.Resources.joker;
            pbFilm2.BackgroundImageLayout = ImageLayout.Zoom;
            pbFilm2.Location = new Point(-2, 377);
            pbFilm2.Name = "pbFilm2";
            pbFilm2.Size = new Size(295, 204);
            pbFilm2.TabIndex = 47;
            pbFilm2.TabStop = false;
            // 
            // AddFilmForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1026, 580);
            Controls.Add(lblGuide);
            Controls.Add(lblWarning);
            Controls.Add(lblInfo);
            Controls.Add(btnClear);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lbxDisplayActors);
            Controls.Add(btnAdd);
            Controls.Add(nudAddFilmRating);
            Controls.Add(nudAddYear);
            Controls.Add(lblAddFilmRating);
            Controls.Add(lblReleaseYear);
            Controls.Add(txtAddCast);
            Controls.Add(lblAddCast);
            Controls.Add(txtAddGenre);
            Controls.Add(lblAddGenre);
            Controls.Add(txtAddTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblAddFilm);
            Controls.Add(pbFilm1);
            Controls.Add(pbFilm2);
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "AddFilmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Film";
            ((System.ComponentModel.ISupportInitialize)pbMenuBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPreviousPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddFilmRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAddYear).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFilm1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFilm2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddFilm;
        private Button btnAdd;
        private ListBox lbxDisplayActors;
        private Label lblWarning;
        private PictureBox pbMenuBtn;
        private PictureBox pbPreviousPage;
        private Label lblGuide;
        private Label lblTitle;
        private NumericUpDown nudAddFilmRating;
        private Label lblAddGenre;
        private TextBox txtAddGenre;
        private Label lblAddCast;
        private TextBox txtAddCast;
        private Label lblReleaseYear;
        private Label lblAddFilmRating;
        private NumericUpDown nudAddYear;
        private TextBox txtAddTitle;
        private Label label1;
        private Panel panel1;
        private Button btnClear;
        private Label lblInfo;
        private PictureBox pbFilm1;
        private PictureBox pbFilm2;
    }
}