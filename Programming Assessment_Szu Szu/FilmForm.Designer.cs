namespace Programming_Assessment_Szu_Szu
{
    partial class FilmForm
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
            lblFilm = new Label();
            pbToAddFilmPage = new PictureBox();
            lblToAddFilmPage = new Label();
            lblShowFilmList = new Label();
            pbShowFilmList = new PictureBox();
            pbMenuBtn = new PictureBox();
            panel1 = new Panel();
            panelAdd = new Panel();
            lblAddPgInfo = new Label();
            panelDisplay = new Panel();
            lblDisplayInfo = new Label();
            panelSearch = new Panel();
            lblSearchInfo = new Label();
            pbSearchFilms = new PictureBox();
            lblSearchFilms = new Label();
            ((System.ComponentModel.ISupportInitialize)pbToAddFilmPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShowFilmList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuBtn).BeginInit();
            panel1.SuspendLayout();
            panelAdd.SuspendLayout();
            panelDisplay.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchFilms).BeginInit();
            SuspendLayout();
            // 
            // lblFilm
            // 
            lblFilm.AutoSize = true;
            lblFilm.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilm.Location = new Point(446, 86);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(120, 62);
            lblFilm.TabIndex = 1;
            lblFilm.Text = "Film";
            // 
            // pbToAddFilmPage
            // 
            pbToAddFilmPage.Anchor = AnchorStyles.None;
            pbToAddFilmPage.BackgroundImage = Properties.Resources.add;
            pbToAddFilmPage.BackgroundImageLayout = ImageLayout.Zoom;
            pbToAddFilmPage.Cursor = Cursors.Hand;
            pbToAddFilmPage.Location = new Point(46, 12);
            pbToAddFilmPage.Name = "pbToAddFilmPage";
            pbToAddFilmPage.Size = new Size(171, 154);
            pbToAddFilmPage.TabIndex = 2;
            pbToAddFilmPage.TabStop = false;
            pbToAddFilmPage.Click += pbToAddFilmPage_Click;
            pbToAddFilmPage.MouseEnter += pbToAddFilmPage_MouseEnter;
            pbToAddFilmPage.MouseLeave += pbToAddFilmPage_MouseLeave;
            // 
            // lblToAddFilmPage
            // 
            lblToAddFilmPage.AutoSize = true;
            lblToAddFilmPage.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToAddFilmPage.Location = new Point(77, 169);
            lblToAddFilmPage.Name = "lblToAddFilmPage";
            lblToAddFilmPage.Size = new Size(110, 32);
            lblToAddFilmPage.TabIndex = 3;
            lblToAddFilmPage.Text = "Add Film";
            lblToAddFilmPage.MouseClick += lblAddPgInfo_MouseClick;
            lblToAddFilmPage.MouseEnter += lblAddPgInfo_MouseEnter;
            lblToAddFilmPage.MouseLeave += lblAddPgInfo_MouseLeave;
            // 
            // lblShowFilmList
            // 
            lblShowFilmList.AutoSize = true;
            lblShowFilmList.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowFilmList.Location = new Point(47, 169);
            lblShowFilmList.Name = "lblShowFilmList";
            lblShowFilmList.Size = new Size(154, 32);
            lblShowFilmList.TabIndex = 5;
            lblShowFilmList.Text = "Display Films";
            lblShowFilmList.MouseClick += lblDisplayInfo_MouseClick;
            lblShowFilmList.MouseEnter += lblDisplayInfo_MouseEnter;
            lblShowFilmList.MouseLeave += lblDisplayInfo_MouseLeave;
            // 
            // pbShowFilmList
            // 
            pbShowFilmList.Anchor = AnchorStyles.None;
            pbShowFilmList.BackgroundImage = Properties.Resources.FilmList;
            pbShowFilmList.BackgroundImageLayout = ImageLayout.Zoom;
            pbShowFilmList.Cursor = Cursors.Hand;
            pbShowFilmList.Location = new Point(58, 27);
            pbShowFilmList.Name = "pbShowFilmList";
            pbShowFilmList.Size = new Size(134, 130);
            pbShowFilmList.TabIndex = 4;
            pbShowFilmList.TabStop = false;
            pbShowFilmList.Click += pbShowFilmList_Click;
            pbShowFilmList.MouseEnter += pbShowFilmList_MouseEnter;
            pbShowFilmList.MouseLeave += pbShowFilmList_MouseLeave;
            // 
            // pbMenuBtn
            // 
            pbMenuBtn.BackColor = Color.FromArgb(34, 34, 34);
            pbMenuBtn.BackgroundImage = Properties.Resources.home_icon;
            pbMenuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbMenuBtn.Location = new Point(989, 0);
            pbMenuBtn.Name = "pbMenuBtn";
            pbMenuBtn.Size = new Size(40, 40);
            pbMenuBtn.TabIndex = 6;
            pbMenuBtn.TabStop = false;
            pbMenuBtn.Click += pbMenuBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pbMenuBtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 37);
            panel1.TabIndex = 37;
            // 
            // panelAdd
            // 
            panelAdd.BorderStyle = BorderStyle.FixedSingle;
            panelAdd.Controls.Add(lblAddPgInfo);
            panelAdd.Controls.Add(pbToAddFilmPage);
            panelAdd.Controls.Add(lblToAddFilmPage);
            panelAdd.Location = new Point(75, 179);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(250, 366);
            panelAdd.TabIndex = 38;
            panelAdd.Click += panelAdd_Click;
            panelAdd.MouseEnter += panelAddActor_MouseEnter;
            panelAdd.MouseLeave += panelAdd_MouseLeave;
            // 
            // lblAddPgInfo
            // 
            lblAddPgInfo.Location = new Point(20, 211);
            lblAddPgInfo.Name = "lblAddPgInfo";
            lblAddPgInfo.Size = new Size(213, 136);
            lblAddPgInfo.TabIndex = 10;
            lblAddPgInfo.Text = "This page allows you to: \r\n>  Add new films, fill their   \r\n    details, and \r\n     -    link to exisitng actors \r\n     -    link to new actor(s) by               manually adding ";
            lblAddPgInfo.MouseClick += lblAddPgInfo_MouseClick;
            lblAddPgInfo.MouseEnter += lblAddPgInfo_MouseEnter;
            lblAddPgInfo.MouseLeave += lblAddPgInfo_MouseLeave;
            // 
            // panelDisplay
            // 
            panelDisplay.BorderStyle = BorderStyle.FixedSingle;
            panelDisplay.Controls.Add(lblDisplayInfo);
            panelDisplay.Controls.Add(pbShowFilmList);
            panelDisplay.Controls.Add(lblShowFilmList);
            panelDisplay.Location = new Point(381, 179);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(250, 366);
            panelDisplay.TabIndex = 39;
            panelDisplay.MouseClick += panelDisplay_MouseClick;
            panelDisplay.MouseEnter += panelDisplay_MouseEnter;
            panelDisplay.MouseLeave += panelDisplay_MouseLeave;
            // 
            // lblDisplayInfo
            // 
            lblDisplayInfo.Location = new Point(36, 211);
            lblDisplayInfo.Name = "lblDisplayInfo";
            lblDisplayInfo.Size = new Size(213, 137);
            lblDisplayInfo.TabIndex = 11;
            lblDisplayInfo.Text = "This page allows you to: \r\n>  View Film List\r\n>  Edit Film Details \r\n     * This does not include               the film's cast(s)\r\n>  Delete Film(s)";
            lblDisplayInfo.MouseClick += lblDisplayInfo_MouseClick;
            lblDisplayInfo.MouseEnter += lblDisplayInfo_MouseEnter;
            lblDisplayInfo.MouseLeave += lblDisplayInfo_MouseLeave;
            // 
            // panelSearch
            // 
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(lblSearchInfo);
            panelSearch.Controls.Add(pbSearchFilms);
            panelSearch.Controls.Add(lblSearchFilms);
            panelSearch.Location = new Point(687, 179);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(250, 366);
            panelSearch.TabIndex = 40;
            panelSearch.MouseClick += panelSearch_MouseClick;
            panelSearch.MouseEnter += panelSearch_MouseEnter;
            panelSearch.MouseLeave += panelSearch_MouseLeave;
            // 
            // lblSearchInfo
            // 
            lblSearchInfo.Location = new Point(22, 211);
            lblSearchInfo.Name = "lblSearchInfo";
            lblSearchInfo.Size = new Size(213, 114);
            lblSearchInfo.TabIndex = 11;
            lblSearchInfo.Text = "This page allows you to: \r\n>  Search Actors or Films by        switching tabs\r\n>  View your searched result        with its details";
            lblSearchInfo.MouseClick += lblSearchInfo_MouseClick;
            lblSearchInfo.MouseEnter += lblSearchInfo_MouseEnter;
            lblSearchInfo.MouseLeave += lblSearchInfo_MouseLeave;
            // 
            // pbSearchFilms
            // 
            pbSearchFilms.Anchor = AnchorStyles.None;
            pbSearchFilms.BackgroundImage = Properties.Resources.search_film;
            pbSearchFilms.BackgroundImageLayout = ImageLayout.Zoom;
            pbSearchFilms.Cursor = Cursors.Hand;
            pbSearchFilms.Location = new Point(60, 43);
            pbSearchFilms.Name = "pbSearchFilms";
            pbSearchFilms.Size = new Size(125, 114);
            pbSearchFilms.TabIndex = 4;
            pbSearchFilms.TabStop = false;
            pbSearchFilms.MouseClick += pbSearchFilms_MouseClick;
            pbSearchFilms.MouseEnter += pbSearchFilms_MouseEnter;
            pbSearchFilms.MouseLeave += pbSearchFilms_MouseLeave;
            // 
            // lblSearchFilms
            // 
            lblSearchFilms.AutoSize = true;
            lblSearchFilms.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchFilms.Location = new Point(47, 169);
            lblSearchFilms.Name = "lblSearchFilms";
            lblSearchFilms.Size = new Size(149, 32);
            lblSearchFilms.TabIndex = 5;
            lblSearchFilms.Text = "Search Films";
            lblSearchFilms.MouseClick += lblSearchInfo_MouseClick;
            lblSearchFilms.MouseEnter += lblSearchInfo_MouseEnter;
            lblSearchFilms.MouseLeave += lblSearchInfo_MouseLeave;
            // 
            // FilmForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1026, 580);
            Controls.Add(panelSearch);
            Controls.Add(panelDisplay);
            Controls.Add(panelAdd);
            Controls.Add(panel1);
            Controls.Add(lblFilm);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "FilmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)pbToAddFilmPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShowFilmList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuBtn).EndInit();
            panel1.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchFilms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFilm;
        private PictureBox pbToAddFilmPage;
        private Label lblToAddFilmPage;
        private Label lblShowFilmList;
        private PictureBox pbShowFilmList;
        private PictureBox pbMenuBtn;
        private Panel panel1;
        private Panel panelAdd;
        private Label lblAddPgInfo;
        private Panel panelDisplay;
        private Label lblDisplayInfo;
        private Panel panelSearch;
        private PictureBox pbSearchFilms;
        private Label lblSearchFilms;
        private Label lblSearchInfo;
    }
}