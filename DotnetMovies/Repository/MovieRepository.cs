using DotnetMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetMovies.Repository
{
    public class MovieRepository//:IMovieRepository
    {


        private List<Movie> Movies
        {
            get
            {
                if (HttpContext.Current.Cache["Movies"] == null)
                    HttpContext.Current.Cache["Movies"] = new List<Movie>();

                return HttpContext.Current.Cache["Movies"] as List<Movie>;
            }
        }

        public IEnumerable<Movie> Get()
        {
            return Movies;
        }

        public Movie Get(int id)
        {
            return Movies.Find(m => m.Id == id);
        }

        public Movie Post(Movie movie)
        {
            if (Movies.Any())
                movie.Id = Movies.Max(m => m.Id) + 1;
            else
                movie.Id = 1;
            Movies.Add(movie);

            return movie;
        }

        public Movie Put(Movie Movie)
        {
            var m = Get(Movie.Id);

            if (m == null)
                throw new Exception(string.Format("Movie with id {0} not exists.", Movie.Id));

            m.Actors = Movie.Actors;
            m.Directors = Movie.Directors;
            m.Poster = Movie.Poster;
            m.Rate = Movie.Rate;
            m.ReleaseYear = Movie.ReleaseYear;
            m.Synopsis = Movie.Synopsis;
            m.Title = Movie.Title;
            return m;
        }

        public bool Delete(int id)
        {
            var m = Get(id);

            if (m == null)
                return false;

            Movies.Remove(m);

            return true;
        }
    }
}