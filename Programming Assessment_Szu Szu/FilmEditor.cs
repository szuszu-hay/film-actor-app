using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment_Szu_Szu
{
    public partial class FilmEditor : Form
    {
        private List<Actor> Actors;
        private Film f;
        public FilmEditor(Film f)
        {
            InitializeComponent();

            DefaultValues(f);

            //ToolTips
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btnDone, "Click or Press Enter to Save Changes");
            toolTip.SetToolTip(nudYear, "Release Year must be between 1900 and current year");
            toolTip.SetToolTip(nudRating, "Rating must be between 1-10");
            toolTip.SetToolTip(undoBtn, "Return to Default Values");
            toolTip.SetToolTip(txtCast, "Cast cannot be edited");
        }

        //Member Functions
        private void DefaultValues(Film f)
        {
            lblWarning.Text = "";

            this.f = f;

            //fill data
            txtFilmTitle.Text = f.GetTitle();
            txtGenre.Text = f.GetGenre();

            List<Actor> actors = f.GetActors();
            List<string> castList = new List<string>();
            foreach (Actor actor in actors)
            {
                castList.Add(actor.GetName());
            }

            string a = string.Join(", ", actors);
            txtCast.Text = a;

            nudYear.Minimum = 1900;
            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Value = f.GetReleaseYear();

            nudRating.Minimum = 1;
            nudRating.Maximum = 10;
            nudRating.DecimalPlaces = 1;
            nudRating.Value = Convert.ToDecimal(f.GetFilmRating());
        }

        //Event Handlers
        private void btnDone_Click(object sender, EventArgs e)
        {
            Film.Status titleStatus = f.SetTitle(txtFilmTitle.Text);

            if (titleStatus == Film.Status.Empty)
            {
                lblWarning.Text = "* Title cannot be blank";
                return;
            }

            Film.Status genreStatus = f.SetGenre(txtGenre.Text);

            if (genreStatus == Film.Status.Empty)
            {
                lblWarning.Text = "* Genre cannot be blank";
                return;
            }

            if (genreStatus == Film.Status.InvalidCharacters)
            {
                lblWarning.Text = "* Invalid Genre";
                return;
            }

            f.SetReleaseYear(Convert.ToInt32(nudYear.Value));
            f.SetFilmRating(Convert.ToSingle(nudRating.Value));
            MessageBox.Show("Film updated!");
            Close();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            DefaultValues(f);
        }

    }
}
