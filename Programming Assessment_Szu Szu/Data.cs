using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assessment_Szu_Szu
{
    class Data
    {
        public static List<Film> GetFilmList()
        {
            List<Film> films = new List<Film>();
            LoadFilmData(films);

            return films;

            //return new List<Film>()
            //{
            //    //0) Titanic
            //    new Film("Titanic", "Romance, Adventure", 1997, 7.9f),

            //    //1) The Notebook
            //    new Film("The Notebook", "Romance, Comedy", 2004, 7.8f),

            //    //2) Parasite
            //    new Film("Parasite", "Thriller, Comedy", 2019, 8.5f),

            //    //3) Fast & Furious
            //    new Film("Fast & Furious", "Action, Crime", 2009, 6.5f),

            //    //4) Jurassic Park
            //    new Film("Jurassic Park", "Adventure, Sci-fi", 1993, 8.2f),

            //    //5) Red Notice
            //    new Film("Red Notice", "Action, Comedy", 2021, 6.3f)

            //};
        }


        public static List<Actor> GetActorList()
        {
            List<Actor> actors = new List<Actor>();
            LoadActorData(actors);
            return actors;


            //return new List<Actor>()
            //{
            //    new Actor("Leonardo DiCaprio" , 8.3f), //0
            //    new Actor("Kate Winslet" , 6.2f), //1
            //    new Actor("Ryan Gosling" , 5.8f), //2
            //    new Actor("Dwayne Johnson" , 8.2f), //3
            //    new Actor("Song Kang-ho" , 7f), //4
            //    new Actor("Tom Holland" , 7.2f) //5
            //};

        }

        //Linking
        public static void Linking(List<Film> f, List<Actor> a)
        {
                ////Titanic
                //f[0].ActorsInFilm(a[0]);
                //f[0].ActorsInFilm(a[1]);

                ////The Notebook
                //f[1].ActorsInFilm(a[2]);

                ////Parasite
                //f[2].ActorsInFilm(a[4]);

                ////Fast&Furious
                //f[3].ActorsInFilm(a[3]);

                ////Red Notice
                //f[5].ActorsInFilm(a[3]);

        }

        public static void SaveFilmData(List<Film> FilmList)
        {
            string data = "";

            foreach (Film f in FilmList)
            {
                data += $"{f.GetTitle()} | ";
                data += $"{f.GetGenre()} | ";
                data += $"{f.GetReleaseYear()} | ";
                data += $"{f.GetFilmRating()}\n";
            }

            File.WriteAllText("films.txt", data);
        }

        public static void SaveActorData(List<Actor> ActorList)
        {
            string data = "";

            foreach (Actor a in ActorList)
            {
                data += $"{a.GetName()} | ";
                data += $"{a.GetActorRating()}\n";
            }

            File.WriteAllText("actors.txt", data);
        }

        public static void SaveLink(List<Film> FilmList, List<Actor> ActorList)
        {
            string data = "";

            foreach (Film f in FilmList)
            {
                foreach (Actor a in f.GetActors())
                {
                    data += $"{f.GetTitle()} | {a.GetName()}\n";
                }

            }

            File.WriteAllText("links.txt", data);
        }

        public static void SaveData(List<Film> films, List<Actor> actors)
        {
            SaveFilmData(films);
            SaveActorData(actors);
            SaveLink(films, actors);
        }

        public static void LoadFilmData(List<Film> films)
        {
            films.Clear();
            string path = "films.txt";

            if (File.Exists(path))
            {
                List<string> lines = File.ReadAllLines(path).ToList();

                foreach (string line in lines)
                {
                    List<string> parts = line.Split(" | ").ToList();

                    if (parts.Count != 4)
                    {
                        MessageBox.Show("🚫ERROR: Data incomplete");
                        continue;

                    }

                    string title = parts[0].Trim();
                    string genre = parts[1].Trim();
                    int release = int.Parse(parts[2].Trim());
                    float rating = float.Parse(parts[3].Trim());

                    Film f = new Film(title, genre, release, rating);
                    films.Add(f);
                }
            }

            else
            {
                return;
            }
        }

        public static void LoadActorData(List<Actor> actors)
        {
            actors.Clear();
            string path = "actors.txt";

            if (File.Exists(path))
            {
                List<string> lines = File.ReadAllLines(path).ToList();

                foreach (string line in lines)
                {
                    List<string> parts = line.Split(" | ").ToList();

                    if (parts.Count != 2)
                    {
                        MessageBox.Show("🚫ERROR: Data incomplete");
                        continue;
                    }

                    string name = parts[0].Trim();
                    float rating = float.Parse(parts[1].Trim());

                    Actor a = new Actor(name, rating);
                    actors.Add(a);
                }
            }

            else
            {
                return;
            }
        }

        public static void LoadLinks(List<Film> films, List<Actor> actors)
        {
            string path = "links.txt";

            if (File.Exists(path))
            {
                List<string> lines = File.ReadAllLines(path).ToList();

                foreach (string line in lines)
                {
                    List<string> parts = line.Split(" | ").ToList();

                    if (parts.Count != 2)
                    {
                        MessageBox.Show("🚫ERROR: Data incomplete");
                        continue;
                    }

                    string filmTitle = parts[0].Trim();
                    string actorName = parts[1].Trim();

                    Film film = null;
                    foreach (Film f in films)
                    {
                        if (f.GetTitle() == filmTitle)
                        {
                            film = f;
                            break;
                        }
                    }

                    Actor actor = null;
                    foreach (Actor a in actors)
                    {
                        if (a.GetName() == actorName)
                        {
                            actor = a;
                            break;
                        }
                    }

                    //link
                    if (film != null && actor != null)
                    {
                        film.ActorsInFilm(actor);
                    }
                }
            }

            else
            {
                return;
            }
        }

    }
}
