using Movie.Library.Abstracts;
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
       
        public MovieClass()
        {
            Actors = new List<Actor>();
            Actors.Add(new Actor());
        }
    }
}
