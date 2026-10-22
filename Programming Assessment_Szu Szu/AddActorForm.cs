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
    public partial class AddActorForm : Form
    {
        private List<Film> Films;
        private List<Actor> Actors;
        public AddActorForm(string actorName, string filmTitle)
        {
            InitializeComponent();
            Films = Data.GetFilmList();
            Actors = Data.GetActorList();

            Data.LoadLinks(Films, Actors);
            //Data.Linking(Films, Actors);

            //foreach (Actor actor in Actors)
            //{
            //    lbxLoadActorData.Items.Add(actor);
            //}

            foreach (Film film in Films)
            {
                lbxDisplayFilms.Items.Add(film);
            }

            txtAddName.Text = actorName;
            txtAddFilmAppearance.Text = filmTitle;

            nudAddActorRating.DecimalPlaces = 1;
            nudAddActorRating.Maximum = 10;
            nudAddActorRating.Minimum = 1;

            Data.SaveData(Films, Actors);

            //ToolTips
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbHomebtn, "Home");
            toolTip.SetToolTip(pbBackbtn, "Back");
            toolTip.SetToolTip(btnClear, "Clear Fields");
            toolTip.SetToolTip(btnAdd, "Click or Press Enter to Add Actor");
        }


        //Member Function
        public Actor CreateActor()
        {
            string name = txtAddName.Text;
            float rating = Convert.ToSingle(nudAddActorRating.Value);

            Actor actor = new Actor(name, rating);
            return actor;
        }

        private Film FilmCreatedFromActorForm(string filmTitle, string actorName)
        {
            AddFilmForm filmForm = new AddFilmForm(filmTitle, actorName);
            filmForm.DisableCastInput();

            DialogResult result = filmForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                return filmForm.CreateFilm();
            }

            return null;
        }
        public void DisableFilmInput()
        {
            txtAddFilmAppearance.Enabled = false;
            lbxDisplayFilms.Enabled = false;
        }

        //Event Handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newActorName = txtAddName.Text;
            string newFilmAppearance = txtAddFilmAppearance.Text;
            float newActorRating = Convert.ToSingle(nudAddActorRating.Value);

            Actor a = new Actor("", 1);

            //Validation
            Actor.Status nameStatus = a.SetName(newActorName);
            Actor.Status ratingStatus = a.SetActorRating(newActorRating);

            //Name
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

            //Rating
            if (ratingStatus == Actor.Status.Empty)
            {
                lblWarning.Text = "* Rating cannot be blank";
                return;
            }

            if (ratingStatus == Actor.Status.OutOfRange)
            {
                lblWarning.Text = "* Rating must be between 1-10";
                return;
            }

            if (string.IsNullOrWhiteSpace(newFilmAppearance))
            {
                lblWarning.Text = "* Film Appearance cannot be blank";
                return;
            }

            Actor newActor = new Actor(newActorName, newActorRating);

            //Check Duplicates
            Actor.Status ActorDuplicateStatus = newActor.CheckDuplicateActor(Actors);

            if (ActorDuplicateStatus == Actor.Status.Duplicates)
            {
                lblWarning.Text = "* Actor Already On List";
                lblGuide.Text = "Go to 'Display Actor' page to update actor details";
                return;
            }

            //Add actor
            Actors.Add(newActor);
            Data.SaveActorData(Actors);

            List<string> filmAppearances = newFilmAppearance.Split(',').ToList();
            bool DuplicatedFilm = false;

            //check whether actor is on list
            for (int i = 0; i < filmAppearances.Count; i++)
            {
                string filmTitle = filmAppearances[i].Trim();
                if (string.IsNullOrWhiteSpace(filmTitle)) continue;

                Film existingFilm = null;
                for (int j = 0; j < Films.Count; j++)
                {
                    if (Films[j].GetTitle().ToUpper() == filmTitle.ToUpper())
                    {
                        existingFilm = Films[j];
                        break;
                    }
                }

                //if film on list
                if (existingFilm != null)
                {
                    //link
                    existingFilm.ActorsInFilm(newActor);
                }

                //if film not list => ask user to add
                else
                {
                    DialogResult q = MessageBox.Show($"Would you like to add '{filmTitle}' to film list?", "Unknown Film!", MessageBoxButtons.YesNo);

                    if (q == DialogResult.Yes)
                    {
                        Film createdFilm = FilmCreatedFromActorForm(filmTitle, newActor.GetName());

                        if (createdFilm != null)
                        {
                            Films.Add(createdFilm);
                            lbxDisplayFilms.Items.Add(createdFilm);

                            //link
                            createdFilm.ActorsInFilm(newActor);
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
            MessageBox.Show("Actor Added!");

            this.DialogResult = DialogResult.OK;
            Close();
        }


        private void lbxDisplayFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film f = lbxDisplayFilms.SelectedItem as Film;
            txtAddFilmAppearance.Text = f.GetTitle();
        }

        private void pbBackbtn_Click(object sender, EventArgs e)
        {
            Hide();
            ActorForm actorForm = new ActorForm();
            actorForm.ShowDialog();
        }

        private void pbHomebtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            txtAddName.Clear();
            txtAddFilmAppearance.Clear();
            nudAddActorRating.Value = nudAddActorRating.Minimum;
            lblGuide.Text = "";
            lblWarning.Text = "";
        }
    }

}
