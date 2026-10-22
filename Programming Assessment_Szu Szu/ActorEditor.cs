using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment_Szu_Szu
{
    public partial class ActorEditor : Form
    {
        private List<Film> Films;
        private Actor a;
        public ActorEditor(Actor a)
        {
            InitializeComponent();

            DefaultValues(a);

            //ToolTips
            //Reference: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.tooltip?view=windowsdesktop-10.0

            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(btnDone, "Click or Press Enter to Save Changes");
            toolTip.SetToolTip(nudRating, "Rating must be between 1-10");
            toolTip.SetToolTip(undoBtn, "Return to Default Values");
            toolTip.SetToolTip(txtFilm, "Film cannot be edited");
        }

        //Member Functions
        private void DefaultValues(Actor a)
        {
            this.a = a;

            //fill data
            txtName.Text = a.GetName();

            List<Film> films = a.GetFilms();
            List<string> filmAppearance = new List<string>();
            foreach (Film film in films)
            {
                filmAppearance.Add(film.GetTitle());
            }

            string f = string.Join(", ", films);
            txtFilm.Text = f;

            nudRating.Minimum = 1;
            nudRating.Maximum = 10;
            nudRating.DecimalPlaces = 1;
            nudRating.Value = Convert.ToDecimal(a.GetActorRating());
        }

        //Event Handlers
        private void btnDone_Click(object sender, EventArgs e)
        {
            Actor.Status nameStatus = a.SetName(txtName.Text);

            if (nameStatus == Actor.Status.Empty)
            {
                lblWarning.Text = "* Name cannot be blank";
                return;
            }

            if (nameStatus == Actor.Status.InvalidCharacters)
            {
                lblWarning.Text = "* Invalid Name";
                return;
            }

            a.SetActorRating(Convert.ToSingle(nudRating.Value));
            MessageBox.Show("Actor updated!");
            Close();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            DefaultValues(a);
        }
    }
}
