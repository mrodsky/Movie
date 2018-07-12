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
            get;
            set;
        }

        
        public MovieClass()
        {
            Actors = new List<Actor>();
            Actors.Add(new Actor());
            Title = string.Empty;
            Genre = EGenre.Romantic_Western;
        }

        public MovieClass(string t, string g, Actor a)
        {
            Title = t;
            if (EGenre.IsDefined(typeof(EGenre), g))
            {
                Genre = Enum.g;
            }
            Actors.Add(a);

        }

    }
}
