using Movie.Library.Abstracts;
using Movie.Library.Enums;
using Movie.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Library
{
    public class MovieClass : AModel
    {
        private string _title;

        public List<Actor> Actors
        {
            get;
            set;
        }

        public EGenre Genre
        {
            get;
            set;
        }

        public string Title
        {
            get
            {

                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                _title = value;
            }
        }

        public MovieClass()
        {
            Initialize();
        }
   
        //private MovieClass()
        //{
        //    Actors = new List<Actor>();
        //    Actors.Add(new Actor());
        //    Title = "(no title)";
        //    Genre = EGenre.Romantic_Western;
        //}

        public MovieClass(string t)
        {
            Initialize(t);
        }

        public MovieClass(string t, EGenre genre)
        {
            Initialize(genre: genre, t: t);
        }

        public MovieClass(string t, EGenre genre, List<Actor> actors)
        {
            Initialize(t, genre, actors);
        }

        public void Initialize(string t = "(no title)", EGenre genre = EGenre.Action,
                                   List<Actor> actors = null)
        {
            Title = t;
            Genre = genre;
            Actors = actors ?? new List<Actor> { new Actor() };
        }
    }
}
