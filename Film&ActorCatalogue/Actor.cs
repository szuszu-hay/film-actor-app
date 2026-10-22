using System.Configuration;
using System.Xml.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assessment_Szu_Szu
{
    public class Actor
    {
        //Data
        private string name;
        private float rating;
        private List<Film> FilmList = new List<Film>();

        //Constructors
        public Actor(string name, float rating)
        {
            SetName(name);
            SetActorRating(rating);
        }

        //Member Functions
        public enum Status
        {
            Ok, Empty, InvalidCharacters, OutOfRange, Duplicates
        }

        public Status SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Status.Empty;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-')
                {
                    return Status.InvalidCharacters;
                }

            }

            this.name = name;
            return Status.Ok;
        }

        public Status SetActorRating(float rating)
        {
            if (rating > 0 && rating <= 10)
            {
                this.rating = rating;
                return Status.Ok;
            }

            else
            {
                return Status.OutOfRange;
            }
        }

        public Status CheckDuplicateActor(List<Actor> ActorList)
        {
            if (string.IsNullOrWhiteSpace(this.name))
                return Status.Empty;

            foreach (Actor a in ActorList)
            {
                if (a.GetName().ToLower() == this.name.ToLower())
                {
                    return Status.Duplicates;
                }
            }

            return Status.Ok;
        }

        public void FilmAppearances(Film film)
        {
            if (film != null && !FilmList.Contains(film))
            {
                FilmList.Add(film);
            }
        }

        public string GetName()
        {
            return name;
        }

        public float GetActorRating()
        {
            return rating;
        }

        public List<Film> GetFilms()
        {
            return FilmList;
        }
        public override string ToString()
        {
            return GetName();
        }
    }
}