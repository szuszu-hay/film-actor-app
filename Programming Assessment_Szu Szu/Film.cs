using System.Configuration;
using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assessment_Szu_Szu
{
    public class Film
    {
        //Data
        private string title;
        private string genre;
        private int releaseYear;
        private float rating;
        private List<Actor> ActorList = new List<Actor>();

        //Constructors
        public Film(string title, string genre, int releaseYear, float rating)
        {
            SetTitle(title);
            SetGenre(genre);
            SetReleaseYear(releaseYear);
            SetFilmRating(rating);
        }

        //Member Functions
        public enum Status
        {
            Ok, Empty, InvalidCharacters, OutOfRange, Duplicates
        }

        public Status SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return Status.Empty;

            this.title = title;
            return Status.Ok;
        }

        public Status SetGenre(string genre)
        {
            if (string.IsNullOrWhiteSpace(genre))
                return Status.Empty;

            foreach (char c in genre)
            {
                if (char.IsDigit(c) && c != ',' && c != ' ' && c != '-')
                {
                    return Status.InvalidCharacters;
                }
            }

            this.genre = genre;
            return Status.Ok;
        }
        public Status SetReleaseYear(int releaseYear)
        {
            if (releaseYear >= 1900 && releaseYear <= DateTime.Now.Year)
            {
                this.releaseYear = releaseYear;
                return Status.Ok;
            }

            else
            {
                return Status.OutOfRange;
            }
        }

        public Status SetFilmRating(float rating)
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

        public Status CheckDuplicateFilm(List<Film> FilmList)
        {
            foreach (Film film in FilmList)
            {
                if (film.GetTitle().ToLower() == this.GetTitle().ToLower())
                {
                    return Status.Duplicates;
                }
            }

            return Status.Ok;
        }


        public void ActorsInFilm(Actor actor)
        {
            if (!ActorList.Contains(actor) && actor != null)
            {
                ActorList.Add(actor);
                actor.FilmAppearances(this);
            }
        }

        public string GetTitle() { return title; }
        public string GetGenre() { return genre; }
        public int GetReleaseYear() { return releaseYear; }
        public float GetFilmRating() { return rating; }
        public List<Actor> GetActors() { return ActorList; }

        public override string ToString()
        {
            return GetTitle();
        }
    }
}