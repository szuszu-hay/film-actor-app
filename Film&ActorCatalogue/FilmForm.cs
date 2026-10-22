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
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();

            //ToolTip
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 300;
            toolTip.ShowAlways = true;

            toolTip.SetToolTip(pbMenuBtn, "Home");
        }

        //Event Handlers

        //To Add Film Page
        private void pbToAddFilmPage_Click(object sender, EventArgs e)
        {
            Close();
            AddFilmForm film = new AddFilmForm("", "");
            film.ShowDialog();
        }

        private void lblAddPgInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            AddFilmForm film = new AddFilmForm("", "");
            film.ShowDialog();
        }

        private void panelAdd_Click(object sender, EventArgs e)
        {
            Close();
            AddFilmForm film = new AddFilmForm("", "");
            film.ShowDialog();
        }

        //To Display Film List Page

        private void pbShowFilmList_Click(object sender, EventArgs e)
        {
            Close();
            DisplayFilmForm films = new DisplayFilmForm();
            films.ShowDialog();
        }

        private void lblDisplayInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            DisplayFilmForm films = new DisplayFilmForm();
            films.ShowDialog();
        }

        private void panelDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            DisplayFilmForm films = new DisplayFilmForm();
            films.ShowDialog();
        }

        //To Search Film Page
        private void pbSearchFilms_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            SearchForm searchForm = new SearchForm("filmForm");
            searchForm.ShowDialog();
        }
        
        private void lblSearchInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            SearchForm searchForm = new SearchForm("filmForm");
            searchForm.ShowDialog();
        }

        private void panelSearch_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            SearchForm searchForm = new SearchForm("filmForm");
            searchForm.ShowDialog();
        }

        //To Main Menu
        private void pbMenuBtn_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();

        }

        //Change Color on Hover

        private Color originalColor;

        //Functions
        private void ChangeAddPanelColor()
        {
            if (originalColor == Color.Empty)
            {
                originalColor = panelAdd.BackColor;
            }

            panelAdd.BackColor = Color.DarkBlue;
        }
        private void ChangeDisplayPanelColor()
        {
            if (originalColor == Color.Empty)
            {
                originalColor = panelDisplay.BackColor;
            }

            panelDisplay.BackColor = Color.DarkBlue;
        }
        private void ChangeSearchPanelColor()
        {
            if (originalColor == Color.Empty)
            {
                originalColor = panelSearch.BackColor;
            }

            panelSearch.BackColor = Color.DarkBlue;
        }

        //Event Handlers

        //Add Film PictureBox
        private void pbToAddFilmPage_MouseEnter(object sender, EventArgs e)
        {
            ChangeAddPanelColor();
        }

        private void pbToAddFilmPage_MouseLeave(object sender, EventArgs e)
        {
            panelAdd.BackColor = originalColor;
        }

        //Add Film Panel
        private void panelAddActor_MouseEnter(object sender, EventArgs e)
        {
            ChangeAddPanelColor();
        }

        private void panelAdd_MouseLeave(object sender, EventArgs e)
        {
            panelAdd.BackColor = originalColor;
        }

        //Add Film Label
        private void lblAddPgInfo_MouseEnter(object sender, EventArgs e)
        {
            ChangeAddPanelColor();
        }

        private void lblAddPgInfo_MouseLeave(object sender, EventArgs e)
        {
            panelAdd.BackColor = originalColor;
        }

        //Display Film PictureBox
        private void pbShowFilmList_MouseEnter(object sender, EventArgs e)
        {
            ChangeDisplayPanelColor();
        }

        private void pbShowFilmList_MouseLeave(object sender, EventArgs e)
        {
            panelDisplay.BackColor = originalColor;
        }

        //Display Film Panel
        private void panelDisplay_MouseEnter(object sender, EventArgs e)
        {
            ChangeDisplayPanelColor();
        }

        private void panelDisplay_MouseLeave(object sender, EventArgs e)
        {
            panelDisplay.BackColor = originalColor;
        }

        //Display Film Label
        private void lblDisplayInfo_MouseEnter(object sender, EventArgs e)
        {
            ChangeDisplayPanelColor();
        }

        private void lblDisplayInfo_MouseLeave(object sender, EventArgs e)
        {
            panelDisplay.BackColor = originalColor;
        }

        //Search Film PictureBox
        private void pbSearchFilms_MouseEnter(object sender, EventArgs e)
        {
            ChangeSearchPanelColor();
        }

        private void pbSearchFilms_MouseLeave(object sender, EventArgs e)
        {
            panelSearch.BackColor = originalColor;
        }

        //Search Film Panel
        private void panelSearch_MouseEnter(object sender, EventArgs e)
        {
            ChangeSearchPanelColor();
        }

        private void panelSearch_MouseLeave(object sender, EventArgs e)
        {
            panelSearch.BackColor = originalColor;
        }

        //Search Film Label
        private void lblSearchInfo_MouseEnter(object sender, EventArgs e)
        {
            ChangeSearchPanelColor();
        }

        private void lblSearchInfo_MouseLeave(object sender, EventArgs e)
        {
            panelSearch.BackColor = originalColor;
        }
    }
}
