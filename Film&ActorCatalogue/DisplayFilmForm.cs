using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assessment_Szu_Szu
{
    public partial class DisplayFilmForm : Form
    {
        private List<Film> Films;
        private List<Actor> Actors;
        public DisplayFilmForm()
        {
            InitializeComponent();

            Films = Data.GetFilmList();
            Actors = Data.GetActorList();
            Data.LoadLinks(Films, Actors);

            //list view column headers
            lvFilms.Columns.Add("", 60);
            lvFilms.Columns.Add("Title", 238);
            lvFilms.Columns.Add("Genre(s)", 210);
            lvFilms.Columns.Add("Cast(s)", 250);
            lvFilms.Columns.Add("Release Year", 130);
            lvFilms.Columns.Add("Rating", 110);

            LoadFilmList();

            //ToolTips
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbEditbtn, "Edit (Double-Clicking the item works too)");
            toolTip.SetToolTip(btnDelete, "Click or Press Delete to delete");
            toolTip.SetToolTip(pbHomebtn, "Home");
            toolTip.SetToolTip(pbBackbtn, "Back");
        }


        //Member functions
        public void LoadFilmList()
        {
            lvFilms.Items.Clear();
            foreach (Film f in Films)
            {
                ListViewItem row = new ListViewItem(">");
                row.SubItems.Add(f.GetTitle().ToUpper());
                row.SubItems.Add(f.GetGenre());

                List<Actor> actors = f.GetActors();
                List<string> cast = new List<string>();

                foreach (Actor actor in actors)
                {
                    cast.Add(actor.GetName());
                }

                if (cast.Count == 0)
                {
                    row.SubItems.Add("-");
                }

                else
                {
                    string casts = string.Join(", ", cast);
                    row.SubItems.Add(casts);
                }

                row.SubItems.Add(f.GetReleaseYear().ToString());
                row.SubItems.Add(f.GetFilmRating().ToString());

                lvFilms.Items.Add(row);
            }
        }

        //delete with keyboard
        private void DeleteFilm()
        {
            if (lvFilms.SelectedItems.Count <= 0) return;
            int index = lvFilms.SelectedItems[0].Index;
            lvFilms.Items.RemoveAt(index);
            Films.RemoveAt(index);

            if (lvFilms.Items.Count <= 0) return;
            int nextIndex = index;
            if (nextIndex >= lvFilms.Items.Count)
            {
                nextIndex = lvFilms.Items.Count - 1;
            }

            lvFilms.Items[nextIndex].Selected = true;

            Data.SaveData(Films, Actors);
        }

        //Event Handlers
        private void pbBackbtn_Click(object sender, EventArgs e)
        {
            Close();
            FilmForm filmForm = new FilmForm();
            filmForm.ShowDialog();
        }

        private void pbHomebtn_Click(object sender, EventArgs e)
        {
            Close();

            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            Show();
        }

        private void pbEditbtn_Click(object sender, EventArgs e)
        {
            if (lvFilms.SelectedItems.Count <= 0) return;
            int selectedItem = lvFilms.SelectedItems[0].Index;
            Film f = Films[selectedItem];

            FilmEditor ed = new FilmEditor(f);
            ed.ShowDialog();
            Data.SaveData(Films, Actors);

            LoadFilmList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFilm();
        }

        private void lvFilms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteFilm();
            }
        }
    }
}
