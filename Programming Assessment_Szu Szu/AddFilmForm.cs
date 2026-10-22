using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment_Szu_Szu
{
    public partial class AddFilmForm : Form
    {
        private List<Film> Films;
        private List<Actor> Actors;
        public AddFilmForm(string newFilm, string newActor)
        {
            InitializeComponent();

            Films = Data.GetFilmList();
            Actors = Data.GetActorList();

            Data.LoadLinks(Films, Actors); //data loaded from file
            //Data.Linking(Films, Actors);

            //foreach (Film film in Films)
            //{
            //    lbxFilmList.Items.Add(film);
            //}

            foreach (Actor actor in Actors)
            {
                lbxDisplayActors.Items.Add(actor);
            }

            txtAddTitle.Text = newFilm;
            txtAddCast.Text = newActor;

            nudAddYear.Maximum = DateTime.Now.Year;
            nudAddYear.Minimum = 1900;

            nudAddFilmRating.DecimalPlaces = 1;
            nudAddFilmRating.Maximum = 10;
            nudAddFilmRating.Minimum = 1;

            Data.SaveData(Films, Actors);


            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbMenuBtn, "Home");
            toolTip.SetToolTip(pbPreviousPage, "Back");
            toolTip.SetToolTip(btnClear, "Clear All Fields");
            toolTip.SetToolTip(btnAdd, "Click or Press Enter to Add Film");
        }

        //Member Function
        private Actor ActorCreatedFromFilmForm(string actorName, string filmTitle)
        {
            AddActorForm actorForm = new AddActorForm(actorName, filmTitle);
            actorForm.DisableFilmInput();

            //Reference https://www.reddit.com/r/learnprogramming/comments/6u6ih5/c_how_do_i_get_a_dialogresult_value_from_a_prompt/

            DialogResult result = actorForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                return actorForm.CreateActor();
            }

            else return null;
        }

        public Film CreateFilm()
        {
            string title = txtAddTitle.Text;
            string genre = txtAddGenre.Text;
            int year = Convert.ToInt32(nudAddYear.Value);
            float rating = Convert.ToSingle(nudAddFilmRating.Value);

            Film film = new Film(title, genre, year, rating);
            return film;
        }

        public void DisableCastInput()
        {
            txtAddCast.Enabled = false;
            lbxDisplayActors.Enabled = false;
        }

        //Event Handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newTitle = txtAddTitle.Text;
            string newGenre = txtAddGenre.Text;
            string newCast = txtAddCast.Text;
            int newReleaseYear = Convert.ToInt32(nudAddYear.Value);
            float newFilmRating = Convert.ToSingle(nudAddFilmRating.Value);

            Film f = new Film("", "", 1900, 1);
            Film.Status titleStatus = f.SetTitle(newTitle);
            Film.Status genreStatus = f.SetGenre(newGenre);
            Film.Status yearStatus = f.SetReleaseYear(newReleaseYear);
            Film.Status ratingStatus = f.SetFilmRating(newFilmRating);

            if (titleStatus == Film.Status.Empty)
            {
                lblWarning.Text = "* Title cannot be blank";
                return;
            }

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

            if (yearStatus == Film.Status.OutOfRange)
            {
                lblWarning.Text = "* Release Year must be between 1900 and current year";
                return;
            }

            if (ratingStatus == Film.Status.OutOfRange)
            {
                lblWarning.Text = "* Rating must be between 1-10";
                return;
            }

            if (string.IsNullOrWhiteSpace(newCast))
            {
                lblWarning.Text = "* Cast cannot be blank";
                return;
            }

            Film newFilm = new Film(newTitle, newGenre, newReleaseYear, newFilmRating);

            Film.Status filmStatus = newFilm.CheckDuplicateFilm(Films);
            if (filmStatus == Film.Status.Duplicates)
            {
                lblWarning.Text = "* Film Already on List";
                lblGuide.Text = "Go to 'Display Film' page to update film details";
                return;
            }

            //Add Film
            Films.Add(newFilm);
            Data.SaveFilmData(Films);

            //getting each actor name if user input more than one actor
            List<string> cast = newCast.Split(',').ToList();
            bool DuplicatedActor = false;

            //check whether actor is on list
            for (int i = 0; i < cast.Count; i++)
            {
                string castName = cast[i].Trim();
                if (string.IsNullOrWhiteSpace(castName)) continue;

                Actor existingActor = null;
                for (int j = 0; j < Actors.Count; j++)
                {
                    if (Actors[j].GetName().ToUpper() == castName.ToUpper())
                    {
                        existingActor = Actors[j];
                        break;
                    }
                }

                //if actor exists
                if (existingActor != null)
                {
                    //link
                    newFilm.ActorsInFilm(existingActor);
                }

                //if actor not exist
                else
                {
                    DialogResult q = MessageBox.Show($"Would you like to add '{castName}' to actor list?", "Unknown Actor!", MessageBoxButtons.YesNo);

                    if (q == DialogResult.Yes)
                    {
                        Actor createdActor = ActorCreatedFromFilmForm(castName, newFilm.GetTitle());

                        if (createdActor != null)
                        {
                            Actors.Add(createdActor);
                            lbxDisplayActors.Items.Add(createdActor);

                            //link
                            newFilm.ActorsInFilm(createdActor);
                        }

                    }

                    else
                    {
                        Hide();
                        MainMenu menu = new MainMenu();
                        menu.ShowDialog();
                    }
                }

            }

            Data.SaveData(Films, Actors);
            MessageBox.Show("Film Added!");
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void lbxDisplayActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actor a = lbxDisplayActors.SelectedItem as Actor;
            txtAddCast.Text = a.GetName();
        }

        private void pbMenuBtn_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

        private void pbPreviousPage_Click(object sender, EventArgs e)
        {
            Close();
            FilmForm filmForm = new FilmForm();
            filmForm.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddTitle.Clear();
            txtAddGenre.Clear();
            txtAddCast.Clear();
            nudAddYear.Value = nudAddYear.Minimum;
            nudAddFilmRating.Value = nudAddFilmRating.Minimum;
            lblGuide.Text = "";
            lblWarning.Text = "";
        }
    }
}
