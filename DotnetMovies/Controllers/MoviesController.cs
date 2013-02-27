using DotnetMovies.Models;
using DotnetMovies.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotnetMovies.Controllers
{
    public class MoviesController : ApiController
    {

        private MovieRepository movieRepository;

        public MoviesController()
        {
            this.movieRepository = new MovieRepository();
        }
        
        // GET api/movies
        public IEnumerable<Movie> Get()
        {
            return movieRepository.Get();
        }

        // GET api/movies/5
        public Movie Get(int id)
        {
            return movieRepository.Get(id);
        }

        // POST api/movies
        public void Post([FromBody]Movie value)
        {
            movieRepository.Post(value);
        }

        // PUT api/movies/5
        public void Put(int id, [FromBody]Movie value)
        {
            movieRepository.Put(value);
        }

        // DELETE api/movies/5
        public void Delete(int id)
        {
            movieRepository.Delete(id);
        }
    }
}
