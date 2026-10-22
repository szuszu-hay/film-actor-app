namespace Programming_Assessment_Szu_Szu
{
    partial class DisplayFilmForm
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
            lvFilms = new ListView();
            panel1 = new Panel();
            pbHomebtn = new PictureBox();
            pbBackbtn = new PictureBox();
            lblInfo = new Label();
            lblTitle = new Label();
            pbEditbtn = new PictureBox();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditbtn).BeginInit();
            SuspendLayout();
            // 
            // lvFilms
            // 
            lvFilms.BackColor = Color.FromArgb(34, 34, 34);
            lvFilms.ForeColor = Color.Snow;
            lvFilms.FullRowSelect = true;
            lvFilms.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvFilms.Location = new Point(12, 162);
            lvFilms.Name = "lvFilms";
            lvFilms.Size = new Size(1002, 364);
            lvFilms.TabIndex = 0;
            lvFilms.UseCompatibleStateImageBehavior = false;
            lvFilms.View = View.Details;
            lvFilms.DoubleClick += pbEditbtn_Click;
            lvFilms.KeyDown += lvFilms_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pbHomebtn);
            panel1.Controls.Add(pbBackbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 40);
            panel1.TabIndex = 22;
            // 
            // pbHomebtn
            // 
            pbHomebtn.BackColor = Color.FromArgb(34, 34, 34);
            pbHomebtn.BackgroundImage = Properties.Resources.home_icon;
            pbHomebtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbHomebtn.Location = new Point(989, 1);
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
            pbBackbtn.Location = new Point(0, 1);
            pbBackbtn.Name = "pbBackbtn";
            pbBackbtn.Size = new Size(40, 40);
            pbBackbtn.TabIndex = 17;
            pbBackbtn.TabStop = false;
            pbBackbtn.Click += pbBackbtn_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9.6F, FontStyle.Italic);
            lblInfo.ForeColor = Color.Snow;
            lblInfo.Location = new Point(380, 127);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(292, 21);
            lblInfo.TabIndex = 27;
            lblInfo.Text = "\"All films you've added will appear here\"";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(450, 68);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 46);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "Film List";
            // 
            // pbEditbtn
            // 
            pbEditbtn.BackColor = Color.FromArgb(34, 34, 34);
            pbEditbtn.BackgroundImage = Properties.Resources.edit;
            pbEditbtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbEditbtn.BorderStyle = BorderStyle.FixedSingle;
            pbEditbtn.Cursor = Cursors.Hand;
            pbEditbtn.Location = new Point(974, 116);
            pbEditbtn.Name = "pbEditbtn";
            pbEditbtn.Size = new Size(40, 40);
            pbEditbtn.TabIndex = 28;
            pbEditbtn.TabStop = false;
            pbEditbtn.Click += pbEditbtn_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.delete_icon;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(974, 532);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 40);
            btnDelete.TabIndex = 29;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DisplayFilmForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1026, 580);
            Controls.Add(btnDelete);
            Controls.Add(pbEditbtn);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Controls.Add(lvFilms);
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "DisplayFilmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display Film List";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvFilms;
        private Panel panel1;
        private PictureBox pbHomebtn;
        private PictureBox pbBackbtn;
        private Label lblInfo;
        private Label lblTitle;
        private PictureBox pbEditbtn;
        private Button btnDelete;
    }
}