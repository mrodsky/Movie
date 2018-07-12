using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Library.Models
{
   public class Fredbox
    {
        private List<MovieClass> Movies;
      
        public Fredbox()
        {
            Movies = new List<MovieClass>();
        }

        public IEnumerable<MovieClass> GetMovies()
        {
            return Movies;
        }

        public MovieClass MakeMovie(string title)
        {
            return new MovieClass()
            {
                Title = title
            };
        }

        public void DistributeMovie(MovieClass m)
        {
            Movies.Add(m);
        }
    }
}
