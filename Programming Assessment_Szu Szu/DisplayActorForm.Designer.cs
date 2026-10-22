namespace Programming_Assessment_Szu_Szu
{
    partial class DisplayActorForm
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
            pbDeletebtn = new PictureBox();
            lvActors = new ListView();
            panel1 = new Panel();
            pbHomebtn = new PictureBox();
            pbBackbtn = new PictureBox();
            lblTitle = new Label();
            lblInfo = new Label();
            pbEditbtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDeletebtn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditbtn).BeginInit();
            SuspendLayout();
            // 
            // pbDeletebtn
            // 
            pbDeletebtn.AccessibleDescription = "";
            pbDeletebtn.BackColor = SystemColors.ActiveCaptionText;
            pbDeletebtn.BackgroundImage = Properties.Resources.delete_icon;
            pbDeletebtn.BackgroundImageLayout = ImageLayout.Zoom;
            pbDeletebtn.BorderStyle = BorderStyle.FixedSingle;
            pbDeletebtn.Location = new Point(974, 532);
            pbDeletebtn.Name = "pbDeletebtn";
            pbDeletebtn.Size = new Size(40, 40);
            pbDeletebtn.TabIndex = 5;
            pbDeletebtn.TabStop = false;
            pbDeletebtn.Click += pbDeletebtn_Click;
            // 
            // lvActors
            // 
            lvActors.BackColor = Color.FromArgb(34, 34, 34);
            lvActors.ForeColor = Color.Snow;
            lvActors.FullRowSelect = true;
            lvActors.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvActors.Location = new Point(12, 162);
            lvActors.Name = "lvActors";
            lvActors.Size = new Size(1002, 364);
            lvActors.TabIndex = 3;
            lvActors.UseCompatibleStateImageBehavior = false;
            lvActors.View = View.Details;
            lvActors.DoubleClick += pbEditbtn_Click;
            lvActors.KeyDown += lvActors_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pbHomebtn);
            panel1.Controls.Add(pbBackbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 39);
            panel1.TabIndex = 23;
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(445, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 46);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Actor List";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9.6F, FontStyle.Italic);
            lblInfo.ForeColor = Color.Snow;
            lblInfo.Location = new Point(381, 126);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(301, 21);
            lblInfo.TabIndex = 25;
            lblInfo.Text = "\"All actors you've added will appear here\"";
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
            pbEditbtn.TabIndex = 18;
            pbEditbtn.TabStop = false;
            pbEditbtn.Click += pbEditbtn_Click;
            // 
            // DisplayActorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(1026, 580);
            Controls.Add(pbEditbtn);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Controls.Add(pbDeletebtn);
            Controls.Add(lvActors);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MaximumSize = new Size(1044, 627);
            MinimumSize = new Size(1044, 627);
            Name = "DisplayActorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display Actor List";
            ((System.ComponentModel.ISupportInitialize)pbDeletebtn).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbHomebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbDeletebtn;
        private ListView lvActors;
        private Button btnEdit;
        private Panel panel1;
        private PictureBox pbHomebtn;
        private PictureBox pbBackbtn;
        private Label lblTitle;
        private Label lblInfo;
        private PictureBox pbEditbtn;
    }
}