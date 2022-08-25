using Portfolio.Domain;
using Portfolio.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public class MovieRepository : IMovieRepository
    {
        private List<Movie> MovieList { get; set; }

        public MovieRepository()
        {
            MovieList = new List<Movie>();
        }
        public void AddMovie(Movie movie)
        {
            MovieList.Add(movie);
        }

        public List<Movie> SearchMovieByTitle(string movieName)
        {
            return MovieList.Where(movie => movie.Title.ToLower().Contains(movieName.ToLower())).ToList();
        }
        public List<Movie> SearchMovieByReleaseYear(ushort releaseYear)
        {
            return MovieList.Where(movie => movie.ReleaseYear == releaseYear).ToList();
        }

        public List<Movie> SearchMovieByCategory(Category category)
        {
            return MovieList.Where(movie => movie.Category == category).ToList();
        }

        public List<Movie> SearchMovieByStudio(Studio studio)
        {
            return MovieList.Where(movie => movie.Studio == studio).ToList();
        }

        public Movie GetMovie(string title)
        {
            return MovieList.FirstOrDefault(movie => movie.Title == title);
        }
        public Movie GetMovie(string title, string releaseYear)
        {
            return MovieList.FirstOrDefault(movie => movie.Title == title && movie.ReleaseYear == ushort.Parse(releaseYear));
        }

        public int Count()
        {
            return MovieList.Count();
        }

        public List<Movie> GetMovieList()
        {
            return MovieList;
        }
    }
}
