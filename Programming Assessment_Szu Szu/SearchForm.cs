using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming_Assessment_Szu_Szu
{
    public partial class SearchForm : Form
    {
        private string openFrom;

        private List<Film> Films;
        private List<Actor> Actors;
        public SearchForm(string from)
        {
            InitializeComponent();
            this.openFrom = from;

            Films = Data.GetFilmList();
            Actors = Data.GetActorList();

            Data.LoadLinks(Films, Actors);

            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbHomebtn, "Home");
            toolTip.SetToolTip(pbBackbtn, "Back");
            toolTip.SetToolTip(txtSearchFilmBar, "Search Bar");
            toolTip.SetToolTip(txtSearchActorBar, "Search Bar");
            toolTip.SetToolTip(pbSearchFilm, "Search Icon");
            toolTip.SetToolTip(pbSearchActor, "Search Icon");
        }

        private void SearchActorForm_Load(object sender, EventArgs e)
        {
            if (openFrom == "filmForm") tabSearch.SelectedIndex = 0;
            if (openFrom == "actorForm") tabSearch.SelectedIndex = 1;
        }

        //------------------------------------------------------------------------------------------------------
        //member functions

        //About film tab

        //clicking title
        private void lblFilm_Click(object sender, EventArgs e)
        {
            Label lblFilm = sender as Label;
            Film film = lblFilm.Tag as Film;
            ShowFilmDetailsPanel(film);
        }

        //titles
        private Label lblClickableTitle(Film f)
        {
            Label lblFilm = new Label();
            lblFilm.Text = f.GetTitle();
            lblFilm.AutoSize = true;
            lblFilm.Width = flpFilmResult.Width - 50;
            lblFilm.Height = 20;
            lblFilm.Cursor = Cursors.Hand;
            lblFilm.Padding = new Padding(2);
            lblFilm.Margin = new Padding(2);

            lblFilm.Tag = f;

            lblFilm.Click += lblFilm_Click;

            return lblFilm;
        }

        //search input
        private void SearchFilms(string input)
        {
            flpFilmResult.Controls.Clear();

            if (string.IsNullOrWhiteSpace(input)) return;

            foreach (Film film in Films)
            {
                //if title contains user input
                if (film.GetTitle().ToLower().Contains(input.ToLower()))
                {
                    flpFilmResult.Controls.Add(lblClickableTitle(film));
                }
            }
        }
        private void ShowFilmDetailsPanel(Film f)
        {
            flpFilmResult.Controls.Clear();
            flpFilmResult.Controls.Add(FilmDetailsPanel(f));
        }

        private Panel FilmDetailsPanel(Film f)
        {
            Panel panel = new Panel();
            panel.Width = flpFilmResult.Width - 20;
            panel.Height = flpFilmResult.Height - 20;
            panel.Margin = new Padding(10);
            panel.AutoScroll = true;
            

            Label lblTitle = new Label();
            lblTitle.Text = f.GetTitle().ToUpper();
            lblTitle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 5);

            Label lblGenre = new Label();
            lblGenre.Text = $"> Genre(s): {f.GetGenre()}";
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(15, 40);

            Label lblReleaseYear = new Label();
            lblReleaseYear.Text = $"> Release Year: {f.GetReleaseYear()}";
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(15, 70);

            Label lblCast = new Label();
            List<Actor> actors = f.GetActors();
            List<string> cast = new List<string>();

            foreach (Actor actor in actors)
            {
                cast.Add(actor.GetName());
            }

            if (cast.Count == 0)
            {
                lblCast.Text = "> Cast(s): -";
            }

            else
            {
                string casts = string.Join(", ", cast);
                lblCast.Text = $"> Cast(s): {casts}";
            }

            lblCast.AutoSize = true;
            lblCast.Location = new Point(15, 100);

            Label lblRating = new Label();
            lblRating.Text = $"> Rating: {f.GetFilmRating()}";
            lblRating.AutoSize = true;
            lblRating.Location = new Point(15, 130);

            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblGenre);
            panel.Controls.Add(lblReleaseYear);
            panel.Controls.Add(lblCast);
            panel.Controls.Add(lblRating);

            return panel;
        }

        //event for search input
        private void txtSearchFilmBar_TextChanged(object sender, EventArgs e)
        {
            SearchFilms(txtSearchFilmBar.Text);
        }

        //------------------------------------------------------------------------------------------------------

        //Actor tab

        //clicking title
        private void lblActor_Click(object sender, EventArgs e)
        {
            Label lblActor = sender as Label;
            Actor actor = lblActor.Tag as Actor;
            ShowActorDetailsPanel(actor);
        }

        //titles
        private Label lblClickableName(Actor a)
        {
            Label lblActor = new Label();
            lblActor.Text = a.GetName();
            lblActor.AutoSize = true;
            lblActor.Width = flpActorResults.Width - 50;
            lblActor.Height = 20;
            lblActor.Cursor = Cursors.Hand;
            lblActor.Padding = new Padding(2);
            lblActor.Margin = new Padding(2);

            lblActor.Tag = a;

            lblActor.Click += lblActor_Click;

            return lblActor;
        }

        //search input
        private void SearchActors(string input)
        {
            flpActorResults.Controls.Clear();

            if (string.IsNullOrWhiteSpace(input)) return;

            foreach (Actor actor in Actors)
            {
                //if title contains user input
                if (actor.GetName().ToLower().Contains(input.ToLower()))
                {
                    flpActorResults.Controls.Add(lblClickableName(actor));
                }
            }
        }

        private void ShowActorDetailsPanel(Actor a)
        {
            flpActorResults.Controls.Clear();
            flpActorResults.Controls.Add(ActorDetailsPanel(a));
        }

        private Panel ActorDetailsPanel(Actor a)
        {
            Panel panel = new Panel();
            panel.Width = flpActorResults.Width - 20;
            panel.Height = 200;
            panel.Margin = new Padding(10);
            panel.AutoScroll = true;
            panel.Location = (new Point(100, 20));

            Label lblTitle = new Label();
            lblTitle.Text = a.GetName().ToUpper();
            lblTitle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(10, 5);

            Label lblFilmAppearance = new Label();

            List<Film> films = a.GetFilms();
            List<string> filmAppearance = new List<string>();

            foreach (Film film in films)
            {
                filmAppearance.Add(film.GetTitle());
            }

            if (filmAppearance.Count == 0)
            {
                lblFilmAppearance.Text = "> Film(s): -";
            }

            else
            {
                string film = string.Join(", ", films);
                lblFilmAppearance.Text = $"> Film(s): {film}";
            }

            lblFilmAppearance.AutoSize = true;
            lblFilmAppearance.Location = new Point(15, 40);

            Label lblRating = new Label();
            lblRating.Text = $"> Rating: {a.GetActorRating()}";
            lblRating.AutoSize = true;
            lblRating.Location = new Point(15, 70);

            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblFilmAppearance);
            panel.Controls.Add(lblRating);

            return panel;
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            SearchActors(txtSearchActorBar.Text);
        }

        private void pbBackbtn_Click(object sender, EventArgs e)
        {
            if (openFrom == "filmForm")
            {
                Hide();
                FilmForm filmForm = new FilmForm();
                filmForm.ShowDialog();
            }

            if (openFrom == "actorForm")
            {
                Hide();
                ActorForm actorForm = new ActorForm();
                actorForm.ShowDialog();
            }
        }

        private void pbHomebtn_Click(object sender, EventArgs e)
        {
            Hide();

            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            Show();
        }
    }
}
