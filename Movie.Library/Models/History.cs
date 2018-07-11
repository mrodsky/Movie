using Movie.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Library.Models
{
   public class History : AModel
    {
        public List<MovieClass> Movies
        {
            get;
            set;
        }
        public History()
        {
            Movies = new List<MovieClass>();
            Movies.Add(new MovieClass());
        }
    }
}
