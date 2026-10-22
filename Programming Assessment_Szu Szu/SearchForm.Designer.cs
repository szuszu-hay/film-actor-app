namespace Programming_Assessment_Szu_Szu
{
    partial class SearchForm
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
            lblSearch = new Label();
            lblSearchInfo = new Label();
            tabActorPage = new TabPage();
            pbSearchActor = new PictureBox();
            flpActorResults = new FlowLayoutPanel();
            txtSearchActorBar = new TextBox();
            tabFilmPage = new TabPage();
            flpFilmResult = new FlowLayoutPanel();
            pbSearchFilm = new PictureBox();
            txtSearchFilmBar = new TextBox();
            tabSearch = new TabControl();
            panel1 = new Panel();
            pbHomebtn = new PictureBox();
            pbBackbtn = new PictureBox();
            tabActorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchActor).BeginInit();
            tabFilmPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchFilm).BeginInit();
            tabSearch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).BeginInit();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Snow;
            lblSearch.Location = new Point(417, 64);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(208, 46);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Area";
            // 
            // lblSearchInfo
            // 
            lblSearchInfo.AutoSize = true;
            lblSearchInfo.Font = new Font("Segoe UI", 9.6F, FontStyle.Italic);
            lblSearchInfo.ForeColor = Color.Snow;
            lblSearchInfo.Location = new Point(424, 128);
            lblSearchInfo.Name = "lblSearchInfo";
            lblSearchInfo.Size = new Size(194, 21);
            lblSearchInfo.TabIndex = 2;
            lblSearchInfo.Text = "\"Search a film or an actor\"";
            // 
            // tabActorPage
            // 
            tabActorPage.AutoScroll = true;
            tabActorPage.BackColor = Color.FromArgb(34, 34, 34);
            tabActorPage.Controls.Add(pbSearchActor);
            tabActorPage.Controls.Add(flpActorResults);
            tabActorPage.Controls.Add(txtSearchActorBar);
            tabActorPage.ForeColor = Color.Snow;
            tabActorPage.Location = new Point(4, 33);
            tabActorPage.Name = "tabActorPage";
            tabActorPage.Padding = new Padding(3);
            tabActorPage.Size = new Size(916, 333);
            tabActorPage.TabIndex = 1;
            tabActorPage.Text = "Actor";
            // 
            // pbSearchActor
            // 
            pbSearchActor.BackColor = Color.FromArgb(34, 34, 34);
            pbSearchActor.BackgroundImage = Properties.Resources.search_icon;
            pbSearchActor.BackgroundImageLayout = ImageLayout.Zoom;
            pbSearchActor.Cursor = Cursors.Hand;
            pbSearchActor.Location = new Point(562, 32);
            pbSearchActor.Name = "pbSearchActor";
            pbSearchActor.Size = new Size(32, 29);
            pbSearchActor.TabIndex = 2;
            pbSearchActor.TabStop = false;
            // 
            // flpActorResults
            // 
            flpActorResults.AutoScroll = true;
            flpActorResults.FlowDirection = FlowDirection.TopDown;
            flpActorResults.Location = new Point(305, 87);
            flpActorResults.Name = "flpActorResults";
            flpActorResults.Size = new Size(568, 231);
            flpActorResults.TabIndex = 1;
            flpActorResults.WrapContents = false;
            // 
            // txtSearchActorBar
            // 
            txtSearchActorBar.BackColor = Color.FromArgb(34, 34, 34);
            txtSearchActorBar.ForeColor = Color.Snow;
            txtSearchActorBar.Location = new Point(343, 32);
            txtSearchActorBar.Name = "txtSearchActorBar";
            txtSearchActorBar.PlaceholderText = "Type in an actor name...";
            txtSearchActorBar.Size = new Size(213, 29);
            txtSearchActorBar.TabIndex = 0;
            txtSearchActorBar.TextChanged += txtSearchBar_TextChanged;
            // 
            // tabFilmPage
            // 
            tabFilmPage.BackColor = Color.FromArgb(34, 34, 34);
            tabFilmPage.BorderStyle = BorderStyle.FixedSingle;
            tabFilmPage.Controls.Add(flpFilmResult);
            tabFilmPage.Controls.Add(pbSearchFilm);
            tabFilmPage.Controls.Add(txtSearchFilmBar);
            tabFilmPage.Location = new Point(4, 33);
            tabFilmPage.Name = "tabFilmPage";
            tabFilmPage.Padding = new Padding(3);
            tabFilmPage.Size = new Size(916, 333);
            tabFilmPage.TabIndex = 0;
            tabFilmPage.Text = "Film";
            // 
            // flpFilmResult
            // 
            flpFilmResult.AutoScroll = true;
            flpFilmResult.BackColor = Color.FromArgb(34, 34, 34);
            flpFilmResult.FlowDirection = FlowDirection.TopDown;
            flpFilmResult.ForeColor = Color.Snow;
            flpFilmResult.Location = new Point(305, 87);
            flpFilmResult.Margin = new Padding(10);
            flpFilmResult.Name = "flpFilmResult";
            flpFilmResult.Size = new Size(568, 231);
            flpFilmResult.TabIndex = 3;
            flpFilmResult.WrapContents = false;
            // 
            // pbSearchFilm
            // 
            pbSearchFilm.BackColor = Color.FromArgb(34, 34, 34);
            pbSearchFilm.BackgroundImage = Properties.Resources.search_icon;
            pbSearchFilm.BackgroundImageLayout = ImageLayout.Zoom;
            pbSearchFilm.Cursor = Cursors.Hand;
            pbSearchFilm.Location = new Point(562, 32);
            pbSearchFilm.Name = "pbSearchFilm";
            pbSearchFilm.Size = new Size(32, 29);
            pbSearchFilm.TabIndex = 1;
            pbSearchFilm.TabStop = false;
            // 
            // txtSearchFilmBar
            // 
            txtSearchFilmBar.BackColor = Color.FromArgb(34, 34, 34);
            txtSearchFilmBar.ForeColor = Color.Snow;
            txtSearchFilmBar.Location = new Point(343, 32);
            txtSearchFilmBar.Name = "txtSearchFilmBar";
            txtSearchFilmBar.PlaceholderText = "Type in a film title...";
            txtSearchFilmBar.Size = new Size(213, 29);
            txtSearchFilmBar.TabIndex = 0;
            txtSearchFilmBar.TextChanged += txtSearchFilmBar_TextChanged;
            // 
            // tabSearch
            // 
            tabSearch.Appearance = TabAppearance.FlatButtons;
            tabSearch.Controls.Add(tabFilmPage);
            tabSearch.Controls.Add(tabActorPage);
            tabSearch.Location = new Point(56, 166);
            tabSearch.Name = "tabSearch";
            tabSearch.SelectedIndex = 0;
            tabSearch.Size = new Size(924, 370);
            tabSearch.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pbHomebtn);
            panel1.Controls.Add(pbBackbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 37);
            panel1.TabIndex = 36;
            // 
            // pbHomebtn
            // 
            pbHomebtn.BackColor = Color.FromArgb(34, 34, 34);
            pbHomebtn.BackgroundImage = Properties.Resources.home_icon;
            pbHomebtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbHomebtn.Location = new Point(986, 0);
            pbHomebtn.Name = "pbHomebtn";
            pbHomebtn.Size = new Size(40, 40);
            pbHomebtn.TabIndex = 16;
            pbHomebtn.TabStop = false;
            pbHomebtn.Click += pbHomebtn_Click;
            // 
            // pbBackbtn
            // 
            pbBackbtn.BackColor = Color.FromArgb(34, 34, 34);
            pbBackbtn.BackgroundImage = Properties.Resources.back_arrow_previous1;
            pbBackbtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbBackbtn.Location = new Point(0, 0);
            pbBackbtn.Name = "pbBackbtn";
            pbBackbtn.Size = new Size(40, 40);
            pbBackbtn.TabIndex = 17;
            pbBackbtn.TabStop = false;
            pbBackbtn.Click += pbBackbtn_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1026, 580);
            Controls.Add(panel1);
            Controls.Add(tabSearch);
            Controls.Add(lblSearchInfo);
            Controls.Add(lblSearch);
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Your Film or Actor";
            Load += SearchActorForm_Load;
            tabActorPage.ResumeLayout(false);
            tabActorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchActor).EndInit();
            tabFilmPage.ResumeLayout(false);
            tabFilmPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearchFilm).EndInit();
            tabSearch.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSearch;
        private Label lblSearchInfo;
        private TabPage tabActorPage;
        private FlowLayoutPanel flpActorResults;
        private TextBox txtSearchActorBar;
        private TabPage tabFilmPage;
        private FlowLayoutPanel flpFilmResult;
        private PictureBox pbSearchFilm;
        private TextBox txtSearchFilmBar;
        private TabControl tabSearch;
        private Panel panel1;
        private PictureBox pbHomebtn;
        private PictureBox pbBackbtn;
        private PictureBox pbSearchActor;
    }
}