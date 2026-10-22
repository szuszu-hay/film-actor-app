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
    public partial class ActorForm : Form
    {
        public ActorForm()
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

        //To Add Actor Page
        private void pbToAddActorPage_Click(object sender, EventArgs e)
        {
            Close();
            AddActorForm actor = new AddActorForm("", "");
            actor.ShowDialog();
        }

        private void lblAddPgInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            AddActorForm actor = new AddActorForm("", "");
            actor.ShowDialog();
        }

        private void panelAddActor_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            AddActorForm actor = new AddActorForm("", "");
            actor.ShowDialog();
        }

        //To Display Actor List Page
        private void pbShowActorList_Click(object sender, EventArgs e)
        {
            Close();
            DisplayActorForm actors = new DisplayActorForm();
            actors.ShowDialog();
        }

        private void lblDisplayInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            DisplayActorForm actors = new DisplayActorForm();
            actors.ShowDialog();
        }

        private void panelDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            DisplayActorForm actors = new DisplayActorForm();
            actors.ShowDialog();
            Show();
        }

        //To Search Actor Page
        private void pbSearchActor_Click(object sender, EventArgs e)
        {
            Close();
            SearchForm searchActorForm = new SearchForm("actorForm");
            searchActorForm.ShowDialog();
        }

        private void lblSearchInfo_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            SearchForm searchActorForm = new SearchForm("actorForm");
            searchActorForm.ShowDialog();
        }
        private void panelSearch_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
            SearchForm searchActorForm = new SearchForm("actorForm");
            searchActorForm.ShowDialog();
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
                originalColor = panelAddActor.BackColor;
            }

            panelAddActor.BackColor = Color.DarkRed;
        }
        private void ChangeDisplayPanelColor()
        {
            if (originalColor == Color.Empty)
            {
                originalColor = panelDisplay.BackColor;
            }

            panelDisplay.BackColor = Color.DarkRed;
        }
        private void ChangeSearchPanelColor()
        {
            if (originalColor == Color.Empty)
            {
                originalColor = panelSearch.BackColor;
            }

            panelSearch.BackColor = Color.DarkRed;
        }

        //Event Handlers

        //Add Actor Panel
        private void panelAddActor_MouseEnter(object sender, EventArgs e)
        {
            ChangeAddPanelColor();
        }

        private void panelAddActor_MouseLeave(object sender, EventArgs e)
        {
            panelAddActor.BackColor = originalColor;
        }

        //Add Actor PictureBox
        private void pbToAddActorPage_MouseEnter(object sender, EventArgs e)
        {
            ChangeAddPanelColor();
        }

        private void pbToAddActorPage_MouseLeave(object sender, EventArgs e)
        {
            panelAddActor.BackColor = originalColor;
        }

        //Add Actor Label
        private void lblAddPgInfo_MouseEnter(object sender, EventArgs e)
        {
            ChangeAddPanelColor();
        }

        private void lblAddPgInfo_MouseLeave(object sender, EventArgs e)
        {
            panelAddActor.BackColor = originalColor;
        }

        //Display Actor Panel
        private void panelDisplay_MouseEnter(object sender, EventArgs e)
        {
            ChangeDisplayPanelColor();
        }

        private void panelDisplay_MouseLeave(object sender, EventArgs e)
        {
            panelDisplay.BackColor = originalColor;
        }

        //Display Actor PictureBox
        private void pbShowActorList_MouseEnter(object sender, EventArgs e)
        {
            ChangeDisplayPanelColor();
        }

        private void pbShowActorList_MouseLeave(object sender, EventArgs e)
        {
            panelDisplay.BackColor = originalColor;
        }

        //Display Actor Label
        private void lblDisplayInfo_MouseEnter(object sender, EventArgs e)
        {
            ChangeDisplayPanelColor();
        }

        private void lblDisplayInfo_MouseLeave(object sender, EventArgs e)
        {
            panelDisplay.BackColor = originalColor;
        }

        //Search Actor Panel
        private void panelSearch_MouseEnter(object sender, EventArgs e)
        {
            ChangeSearchPanelColor();
        }

        private void panelSearch_MouseLeave(object sender, EventArgs e)
        {
            panelSearch.BackColor = originalColor;
        }

        //Search Actor PictureBox
        private void pbSearchActor_MouseEnter(object sender, EventArgs e)
        {
            ChangeSearchPanelColor();
        }

        private void pbSearchActor_MouseLeave(object sender, EventArgs e)
        {
            panelSearch.BackColor = originalColor;
        }

        //Search Actor Label
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
