namespace Programming_Assessment_Szu_Szu
{
    partial class AddActorForm
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
            lblWarning = new Label();
            btnAdd = new Button();
            nudAddActorRating = new NumericUpDown();
            lblAddActorRating = new Label();
            txtAddFilmAppearance = new TextBox();
            lblAddFilmAppearance = new Label();
            txtAddName = new TextBox();
            lblName = new Label();
            lblAddActor = new Label();
            lbxDisplayFilms = new ListBox();
            lblGuide = new Label();
            panel1 = new Panel();
            pbHomebtn = new PictureBox();
            pbBackbtn = new PictureBox();
            label1 = new Label();
            pbLeo = new PictureBox();
            lblInfo = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAddActorRating).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeo).BeginInit();
            SuspendLayout();
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(265, 464);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 21);
            lblWarning.TabIndex = 30;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(34, 34, 34);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(608, 464);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(59, 54);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudAddActorRating
            // 
            nudAddActorRating.BackColor = Color.FromArgb(34, 34, 34);
            nudAddActorRating.ForeColor = Color.Snow;
            nudAddActorRating.Location = new Point(344, 368);
            nudAddActorRating.Name = "nudAddActorRating";
            nudAddActorRating.Size = new Size(377, 29);
            nudAddActorRating.TabIndex = 27;
            // 
            // lblAddActorRating
            // 
            lblAddActorRating.AutoSize = true;
            lblAddActorRating.ForeColor = Color.Snow;
            lblAddActorRating.Location = new Point(265, 370);
            lblAddActorRating.Name = "lblAddActorRating";
            lblAddActorRating.Size = new Size(58, 21);
            lblAddActorRating.TabIndex = 25;
            lblAddActorRating.Text = "Rating:";
            // 
            // txtAddFilmAppearance
            // 
            txtAddFilmAppearance.BackColor = Color.FromArgb(34, 34, 34);
            txtAddFilmAppearance.ForeColor = Color.Snow;
            txtAddFilmAppearance.Location = new Point(344, 310);
            txtAddFilmAppearance.Name = "txtAddFilmAppearance";
            txtAddFilmAppearance.Size = new Size(377, 29);
            txtAddFilmAppearance.TabIndex = 21;
            // 
            // lblAddFilmAppearance
            // 
            lblAddFilmAppearance.AutoSize = true;
            lblAddFilmAppearance.ForeColor = Color.Snow;
            lblAddFilmAppearance.Location = new Point(265, 313);
            lblAddFilmAppearance.Name = "lblAddFilmAppearance";
            lblAddFilmAppearance.Size = new Size(60, 21);
            lblAddFilmAppearance.TabIndex = 20;
            lblAddFilmAppearance.Text = "Film(s):";
            // 
            // txtAddName
            // 
            txtAddName.BackColor = Color.FromArgb(34, 34, 34);
            txtAddName.ForeColor = Color.Snow;
            txtAddName.Location = new Point(344, 227);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(377, 29);
            txtAddName.TabIndex = 19;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Snow;
            lblName.Location = new Point(265, 230);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 18;
            lblName.Text = "Name:";
            // 
            // lblAddActor
            // 
            lblAddActor.AutoSize = true;
            lblAddActor.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddActor.ForeColor = Color.Snow;
            lblAddActor.Location = new Point(441, 103);
            lblAddActor.Name = "lblAddActor";
            lblAddActor.Size = new Size(183, 46);
            lblAddActor.TabIndex = 17;
            lblAddActor.Text = "Add Actor";
            // 
            // lbxDisplayFilms
            // 
            lbxDisplayFilms.BackColor = Color.FromArgb(34, 34, 34);
            lbxDisplayFilms.ForeColor = Color.Snow;
            lbxDisplayFilms.FormattingEnabled = true;
            lbxDisplayFilms.Location = new Point(783, 141);
            lbxDisplayFilms.Name = "lbxDisplayFilms";
            lbxDisplayFilms.Size = new Size(215, 403);
            lbxDisplayFilms.TabIndex = 16;
            lbxDisplayFilms.SelectedIndexChanged += lbxDisplayFilms_SelectedIndexChanged;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("Segoe UI", 9.6F, FontStyle.Italic);
            lblGuide.ForeColor = SystemColors.ActiveCaption;
            lblGuide.Location = new Point(265, 431);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(0, 21);
            lblGuide.TabIndex = 33;
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
            panel1.TabIndex = 35;
            // 
            // pbHomebtn
            // 
            pbHomebtn.BackColor = Color.FromArgb(34, 34, 34);
            pbHomebtn.BackgroundImage = Properties.Resources.home_icon;
            pbHomebtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbHomebtn.Location = new Point(982, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label1.ForeColor = Color.Pink;
            label1.Location = new Point(344, 277);
            label1.Name = "label1";
            label1.Size = new Size(242, 19);
            label1.TabIndex = 36;
            label1.Text = "* Hint: Add or Select Cast(s) From List";
            // 
            // pbLeo
            // 
            pbLeo.BackgroundImage = Properties.Resources.leo;
            pbLeo.BackgroundImageLayout = ImageLayout.Zoom;
            pbLeo.Location = new Point(12, 350);
            pbLeo.Name = "pbLeo";
            pbLeo.Size = new Size(215, 194);
            pbLeo.TabIndex = 37;
            pbLeo.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.LightGray;
            lblInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.FromArgb(34, 34, 34);
            lblInfo.Location = new Point(783, 112);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(159, 20);
            lblInfo.TabIndex = 41;
            lblInfo.Text = "Films Available on List";
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
            btnClear.Location = new Point(673, 464);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 54);
            btnClear.TabIndex = 42;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AddActorForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            CancelButton = btnClear;
            ClientSize = new Size(1022, 576);
            Controls.Add(btnClear);
            Controls.Add(lblInfo);
            Controls.Add(pbLeo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblGuide);
            Controls.Add(lblWarning);
            Controls.Add(btnAdd);
            Controls.Add(nudAddActorRating);
            Controls.Add(lblAddActorRating);
            Controls.Add(txtAddFilmAppearance);
            Controls.Add(lblAddFilmAppearance);
            Controls.Add(txtAddName);
            Controls.Add(lblName);
            Controls.Add(lblAddActor);
            Controls.Add(lbxDisplayFilms);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "AddActorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Actor";
            ((System.ComponentModel.ISupportInitialize)nudAddActorRating).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWarning;
        private Button btnAdd;
        private NumericUpDown nudAddActorRating;
        private Label lblAddActorRating;
        private TextBox txtAddFilmAppearance;
        private Label lblAddFilmAppearance;
        private TextBox txtAddName;
        private Label lblName;
        private Label lblAddActor;
        private ListBox lbxDisplayFilms;
        private Label lblGuide;
        private Panel panel1;
        private PictureBox pbHomebtn;
        private PictureBox pbBackbtn;
        private Label label1;
        private PictureBox pbLeo;
        private Label lblInfo;
        private Button btnClear;
    }
}