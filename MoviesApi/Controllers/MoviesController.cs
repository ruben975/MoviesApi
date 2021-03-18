using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesApi.Models;
namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>()
        {
            new Movie() { ID = Guid.NewGuid(), Name = "The Hunger Games",ReleaseYear = 2018 },
            new Movie() { ID = Guid.NewGuid(), Name = "The Sound of Music", ReleaseYear = 2018 },
            new Movie() { ID = Guid.NewGuid(), Name = "Lord of the Rings", ReleaseYear = 2018 },
            new Movie() { ID = Guid.NewGuid(), Name = "City of Angels", ReleaseYear = 2018 },
            new Movie() { ID = Guid.NewGuid(), Name = "About Time",ReleaseYear = 2018 }
        };

        [HttpGet]
        public Movie[] Get()
        {
            return movies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            if (movie.ID == Guid.Empty)
                movie.ID = Guid.NewGuid();

            movies.Add(movie);
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
            Movie currentMovie = movies.FirstOrDefault(m => m.ID == movie.ID);
            currentMovie.Name = movie.Name;
            currentMovie.ReleaseYear = movie.ReleaseYear;
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            movies.RemoveAll(movie => movie.ID == id);
        }
    }
}