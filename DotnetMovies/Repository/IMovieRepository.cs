using DotnetMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetMovies.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Get();

        Movie Get(int id);

        Movie Post(Movie movie);

        Movie Put(Movie movie);

        bool Delete(int id);
    }
}