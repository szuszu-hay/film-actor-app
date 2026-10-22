namespace Programming_Assessment_Szu_Szu
{
    partial class ActorForm
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
            pbMenuBtn = new PictureBox();
            lblShowFilmList = new Label();
            pbShowActorList = new PictureBox();
            lblToAddFilmPage = new Label();
            pbToAddActorPage = new PictureBox();
            lblActor = new Label();
            lblSearchActor = new Label();
            pbSearchActor = new PictureBox();
            panel1 = new Panel();
            panelAddActor = new Panel();
            lblAddPgInfo = new Label();
            panelDisplay = new Panel();
            lblDisplayInfo = new Label();
            panelSearch = new Panel();
            lblSearchInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMenuBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShowActorList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbToAddActorPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchActor).BeginInit();
            panel1.SuspendLayout();
            panelAddActor.SuspendLayout();
            panelDisplay.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pbMenuBtn
            // 
            pbMenuBtn.BackColor = Color.FromArgb(34, 34, 34);
            pbMenuBtn.BackgroundImage = Properties.Resources.home_icon;
            pbMenuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbMenuBtn.Location = new Point(986, 0);
            pbMenuBtn.Name = "pbMenuBtn";
            pbMenuBtn.Size = new Size(40, 40);
            pbMenuBtn.TabIndex = 12;
            pbMenuBtn.TabStop = false;
            pbMenuBtn.Click += pbMenuBtn_Click;
            // 
            // lblShowFilmList
            // 
            lblShowFilmList.AutoSize = true;
            lblShowFilmList.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowFilmList.Location = new Point(41, 166);
            lblShowFilmList.Name = "lblShowFilmList";
            lblShowFilmList.Size = new Size(168, 32);
            lblShowFilmList.TabIndex = 11;
            lblShowFilmList.Text = "Display Actors";
            lblShowFilmList.MouseClick += lblDisplayInfo_MouseClick;
            lblShowFilmList.MouseEnter += lblDisplayInfo_MouseEnter;
            lblShowFilmList.MouseLeave += lblDisplayInfo_MouseLeave;
            // 
            // pbShowActorList
            // 
            pbShowActorList.Anchor = AnchorStyles.None;
            pbShowActorList.BackgroundImage = Properties.Resources.stars;
            pbShowActorList.BackgroundImageLayout = ImageLayout.Zoom;
            pbShowActorList.Cursor = Cursors.Hand;
            pbShowActorList.Location = new Point(41, 26);
            pbShowActorList.Name = "pbShowActorList";
            pbShowActorList.Size = new Size(168, 127);
            pbShowActorList.TabIndex = 10;
            pbShowActorList.TabStop = false;
            pbShowActorList.Click += pbShowActorList_Click;
            pbShowActorList.MouseEnter += pbShowActorList_MouseEnter;
            pbShowActorList.MouseLeave += pbShowActorList_MouseLeave;
            // 
            // lblToAddFilmPage
            // 
            lblToAddFilmPage.AutoSize = true;
            lblToAddFilmPage.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToAddFilmPage.Location = new Point(61, 166);
            lblToAddFilmPage.Name = "lblToAddFilmPage";
            lblToAddFilmPage.Size = new Size(124, 32);
            lblToAddFilmPage.TabIndex = 9;
            lblToAddFilmPage.Text = "Add Actor";
            lblToAddFilmPage.MouseClick += lblAddPgInfo_MouseClick;
            lblToAddFilmPage.MouseEnter += lblAddPgInfo_MouseEnter;
            lblToAddFilmPage.MouseLeave += lblAddPgInfo_MouseLeave;
            // 
            // pbToAddActorPage
            // 
            pbToAddActorPage.Anchor = AnchorStyles.None;
            pbToAddActorPage.BackgroundImage = Properties.Resources.actor_icon;
            pbToAddActorPage.BackgroundImageLayout = ImageLayout.Zoom;
            pbToAddActorPage.Cursor = Cursors.Hand;
            pbToAddActorPage.Location = new Point(54, 39);
            pbToAddActorPage.Name = "pbToAddActorPage";
            pbToAddActorPage.Size = new Size(136, 114);
            pbToAddActorPage.TabIndex = 8;
            pbToAddActorPage.TabStop = false;
            pbToAddActorPage.Click += pbToAddActorPage_Click;
            pbToAddActorPage.MouseEnter += pbToAddActorPage_MouseEnter;
            pbToAddActorPage.MouseLeave += pbToAddActorPage_MouseLeave;
            // 
            // lblActor
            // 
            lblActor.AutoSize = true;
            lblActor.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActor.Location = new Point(434, 86);
            lblActor.Name = "lblActor";
            lblActor.Size = new Size(149, 62);
            lblActor.TabIndex = 7;
            lblActor.Text = "Actor";
            // 
            // lblSearchActor
            // 
            lblSearchActor.AutoSize = true;
            lblSearchActor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchActor.Location = new Point(37, 166);
            lblSearchActor.Name = "lblSearchActor";
            lblSearchActor.Size = new Size(163, 32);
            lblSearchActor.TabIndex = 14;
            lblSearchActor.Text = "Search Actors";
            lblSearchActor.MouseClick += lblSearchInfo_MouseClick;
            lblSearchActor.MouseEnter += lblSearchInfo_MouseEnter;
            lblSearchActor.MouseLeave += lblSearchInfo_MouseLeave;
            // 
            // pbSearchActor
            // 
            pbSearchActor.Anchor = AnchorStyles.None;
            pbSearchActor.BackgroundImage = Properties.Resources.search_actor;
            pbSearchActor.BackgroundImageLayout = ImageLayout.Zoom;
            pbSearchActor.Cursor = Cursors.Hand;
            pbSearchActor.Location = new Point(37, 26);
            pbSearchActor.Name = "pbSearchActor";
            pbSearchActor.Size = new Size(163, 119);
            pbSearchActor.TabIndex = 13;
            pbSearchActor.TabStop = false;
            pbSearchActor.Click += pbSearchActor_Click;
            pbSearchActor.MouseEnter += pbSearchActor_MouseEnter;
            pbSearchActor.MouseLeave += pbSearchActor_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pbMenuBtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 37);
            panel1.TabIndex = 36;
            // 
            // panelAddActor
            // 
            panelAddActor.BorderStyle = BorderStyle.FixedSingle;
            panelAddActor.Controls.Add(lblAddPgInfo);
            panelAddActor.Controls.Add(pbToAddActorPage);
            panelAddActor.Controls.Add(lblToAddFilmPage);
            panelAddActor.Location = new Point(75, 179);
            panelAddActor.Name = "panelAddActor";
            panelAddActor.Size = new Size(250, 366);
            panelAddActor.TabIndex = 37;
            panelAddActor.MouseClick += panelAddActor_MouseClick;
            panelAddActor.MouseEnter += panelAddActor_MouseEnter;
            panelAddActor.MouseLeave += panelAddActor_MouseLeave;
            // 
            // lblAddPgInfo
            // 
            lblAddPgInfo.Location = new Point(32, 210);
            lblAddPgInfo.Name = "lblAddPgInfo";
            lblAddPgInfo.Size = new Size(213, 114);
            lblAddPgInfo.TabIndex = 10;
            lblAddPgInfo.Text = "This page allows you to: \r\n>  Add new actors, rate, and \r\n     -    link to exisitng films \r\n     -    link to new film(s) by               manually adding ";
            lblAddPgInfo.MouseClick += lblAddPgInfo_MouseClick;
            lblAddPgInfo.MouseEnter += lblAddPgInfo_MouseEnter;
            lblAddPgInfo.MouseLeave += lblAddPgInfo_MouseLeave;
            // 
            // panelDisplay
            // 
            panelDisplay.BorderStyle = BorderStyle.FixedSingle;
            panelDisplay.Controls.Add(lblDisplayInfo);
            panelDisplay.Controls.Add(pbShowActorList);
            panelDisplay.Controls.Add(lblShowFilmList);
            panelDisplay.Location = new Point(380, 179);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(250, 366);
            panelDisplay.TabIndex = 38;
            panelDisplay.MouseClick += panelDisplay_MouseClick;
            panelDisplay.MouseEnter += panelDisplay_MouseEnter;
            panelDisplay.MouseLeave += panelDisplay_MouseLeave;
            // 
            // lblDisplayInfo
            // 
            lblDisplayInfo.Location = new Point(36, 210);
            lblDisplayInfo.Name = "lblDisplayInfo";
            lblDisplayInfo.Size = new Size(213, 137);
            lblDisplayInfo.TabIndex = 10;
            lblDisplayInfo.Text = "This page allows you to: \r\n>  View Actor List\r\n>  Edit Actor Details \r\n     * This does not include               film(s) he/she stars\r\n>  Delete Actor(s)";
            lblDisplayInfo.MouseClick += lblDisplayInfo_MouseClick;
            lblDisplayInfo.MouseEnter += lblDisplayInfo_MouseEnter;
            lblDisplayInfo.MouseLeave += lblDisplayInfo_MouseLeave;
            // 
            // panelSearch
            // 
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(lblSearchInfo);
            panelSearch.Controls.Add(pbSearchActor);
            panelSearch.Controls.Add(lblSearchActor);
            panelSearch.Location = new Point(685, 179);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(250, 366);
            panelSearch.TabIndex = 39;
            panelSearch.MouseClick += panelSearch_MouseClick;
            panelSearch.MouseEnter += panelSearch_MouseEnter;
            panelSearch.MouseLeave += panelSearch_MouseLeave;
            // 
            // lblSearchInfo
            // 
            lblSearchInfo.Location = new Point(20, 210);
            lblSearchInfo.Name = "lblSearchInfo";
            lblSearchInfo.Size = new Size(213, 114);
            lblSearchInfo.TabIndex = 10;
            lblSearchInfo.Text = "This page allows you to: \r\n>  Search Actors or Films by        switching tabs\r\n>  View your searched result        with its details";
            lblSearchInfo.MouseClick += lblSearchInfo_MouseClick;
            lblSearchInfo.MouseEnter += lblSearchInfo_MouseEnter;
            lblSearchInfo.MouseLeave += lblSearchInfo_MouseLeave;
            // 
            // ActorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1026, 580);
            Controls.Add(panelSearch);
            Controls.Add(panelDisplay);
            Controls.Add(panelAddActor);
            Controls.Add(panel1);
            Controls.Add(lblActor);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "ActorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actor Page";
            ((System.ComponentModel.ISupportInitialize)pbMenuBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShowActorList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbToAddActorPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchActor).EndInit();
            panel1.ResumeLayout(false);
            panelAddActor.ResumeLayout(false);
            panelAddActor.PerformLayout();
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMenuBtn;
        private Label lblShowFilmList;
        private PictureBox pbShowActorList;
        private Label lblToAddFilmPage;
        private PictureBox pbToAddActorPage;
        private Label lblActor;
        private Label lblSearchActor;
        private PictureBox pbSearchActor;
        private Panel panel1;
        private Panel panelAddActor;
        private Label lblAddPgInfo;
        private Panel panelDisplay;
        private Label lblDisplayInfo;
        private Panel panelSearch;
        private Label lblSearchInfo;
    }
}