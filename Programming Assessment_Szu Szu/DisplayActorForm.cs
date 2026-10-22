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
    public partial class DisplayActorForm : Form
    {
        private List<Film> Films;
        private List<Actor> Actors;

        public DisplayActorForm()
        {
            InitializeComponent();

            Films = Data.GetFilmList();
            Actors = Data.GetActorList();
            Data.LoadLinks(Films, Actors);

            //list view column headers
            lvActors.Columns.Add("", 70);
            lvActors.Columns.Add("Name", 290);
            lvActors.Columns.Add("Film(s)", 455);
            lvActors.Columns.Add("Rating", 160);

            LoadActorList();

            //ToolTips
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbEditbtn, "Edit (Double-Clicking the item works too)");
            toolTip.SetToolTip(pbDeletebtn, "Click or Press Delete to delete");
            toolTip.SetToolTip(pbHomebtn, "Home");
            toolTip.SetToolTip(pbBackbtn, "Back");
        }

        //Member functions
        public void LoadActorList()
        {
            lvActors.Items.Clear();
            foreach (Actor a in Actors)
            {
                ListViewItem row = new ListViewItem(">");
                row.SubItems.Add(a.GetName().ToUpper());

                List<Film> films = a.GetFilms();
                List<string> filmAppearance = new List<string>();

                foreach (Film film in films)
                {
                    filmAppearance.Add(film.GetTitle());
                }

                if (filmAppearance.Count == 0)
                {
                    row.SubItems.Add("-");
                }

                else
                {
                    string film = string.Join(", ", filmAppearance);
                    row.SubItems.Add(film);
                }

                row.SubItems.Add(a.GetActorRating().ToString());

                lvActors.Items.Add(row);

            }
        }

        private void DeleteActor()
        {
            if (lvActors.SelectedItems.Count <= 0) return;
            int index = lvActors.SelectedItems[0].Index;
            lvActors.Items.RemoveAt(index);
            Actors.RemoveAt(index);

            if (lvActors.Items.Count <= 0) return;

            int nextIndex = index;
            if (nextIndex >= lvActors.Items.Count)
            {
                nextIndex = lvActors.Items.Count - 1;
            }

            lvActors.Items[nextIndex].Selected = true;

            Data.SaveData(Films, Actors);
        }

        //Event Handlers
        private void pbBackbtn_Click(object sender, EventArgs e)
        {
            Close();
            ActorForm actorForm = new ActorForm();
            actorForm.ShowDialog();
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
            if (lvActors.SelectedItems.Count <= 0) return;
            int selectedItem = lvActors.SelectedItems[0].Index;
            Actor a = Actors[selectedItem];

            ActorEditor ed = new ActorEditor(a);
            ed.ShowDialog();
            Data.SaveData(Films, Actors);

            LoadActorList();
        }

        private void pbDeletebtn_Click(object sender, EventArgs e)
        {
            DeleteActor();
        }

        private void lvActors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteActor();
            }
        }   
    }

 
}