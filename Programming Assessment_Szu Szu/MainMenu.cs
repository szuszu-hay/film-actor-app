namespace Programming_Assessment_Szu_Szu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Hide();
            FilmForm film = new FilmForm();
            film.ShowDialog();
            Show();
        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            Hide();
            ActorForm actor = new ActorForm();
            actor.ShowDialog();
            Show();
        }
    }
}
