namespace Programming_Assessment_Szu_Szu
{
    partial class ActorEditor
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
            lblTitle = new Label();
            txtName = new TextBox();
            txtFilm = new TextBox();
            lblName = new Label();
            lblFilm = new Label();
            lblRating = new Label();
            btnDone = new Button();
            nudRating = new NumericUpDown();
            lblInfo = new Label();
            lblWarning = new Label();
            undoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(218, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(82, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit";
            // 
            // txtName
            // 
            txtName.Location = new Point(144, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 29);
            txtName.TabIndex = 1;
            // 
            // txtFilm
            // 
            txtFilm.Enabled = false;
            txtFilm.Location = new Point(144, 206);
            txtFilm.Name = "txtFilm";
            txtFilm.ReadOnly = true;
            txtFilm.Size = new Size(239, 29);
            txtFilm.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(64, 157);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Name: ";
            // 
            // lblFilm
            // 
            lblFilm.AutoSize = true;
            lblFilm.Location = new Point(64, 209);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(60, 21);
            lblFilm.TabIndex = 5;
            lblFilm.Text = "Film(s):";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(64, 261);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(58, 21);
            lblRating.TabIndex = 6;
            lblRating.Text = "Rating:";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(34, 34, 34);
            btnDone.Cursor = Cursors.Hand;
            btnDone.ForeColor = Color.Snow;
            btnDone.Location = new Point(201, 322);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(128, 45);
            btnDone.TabIndex = 7;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(144, 258);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(239, 29);
            nudRating.TabIndex = 8;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(135, 421);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(248, 23);
            lblInfo.TabIndex = 9;
            lblInfo.Text = "Note: Film(s) cannot be edited ";
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(186, 388);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 23);
            lblWarning.TabIndex = 25;
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
            undoBtn.TabIndex = 26;
            undoBtn.UseVisualStyleBackColor = false;
            undoBtn.Click += undoBtn_Click;
            // 
            // ActorEditor
            // 
            AcceptButton = btnDone;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(480, 463);
            Controls.Add(undoBtn);
            Controls.Add(lblWarning);
            Controls.Add(lblInfo);
            Controls.Add(nudRating);
            Controls.Add(btnDone);
            Controls.Add(lblRating);
            Controls.Add(lblFilm);
            Controls.Add(lblName);
            Controls.Add(txtFilm);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "ActorEditor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Actor";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtName;
        private TextBox txtFilm;
        private Label lblName;
        private Label lblFilm;
        private Label lblRating;
        private Button btnDone;
        private NumericUpDown nudRating;
        private Label lblInfo;
        private Label lblWarning;
        private Button undoBtn;
    }
}