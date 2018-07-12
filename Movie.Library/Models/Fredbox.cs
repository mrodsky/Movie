using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Library.Models
{
   public class Fredbox
    {
        private List<MovieClass> Movies;
      
        //public Fredbox()
        //{
        //    Movies = new List<MovieClass>();
        //}

        
        public IEnumerable<MovieClass> GetMovies()
        {
            return Movies;
        }

        public MovieClass MakeMovie(string title)
        {
            MovieClass Movie1;
            try
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentNullException(title, "tittle cannot be null or whitespace");
                }
                else
                {
                    return new MovieClass()
                    {
                        Title = title
                    };
                }
                
            } //end of try block 
            catch  (ArgumentNullException ex)
            {
                MakeMovie("default");
            }
            catch (ArgumentException ex)
            {
                throw new Exception("not sure how it happened", ex);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                Movie1 = new MovieClass(title);
                GC.Collect();
            }
            return new MovieClass();
        }

        public void DistributeMovie(MovieClass m)
        {
            Movies.Add(m);
        }

        public Fredbox(List<MovieClass> movies)
        {
            Initialize(movies);
        }

        public void Initialize(List<MovieClass> movies = null)
        {
            Movies = movies;
        }
    }
}
