using Movie.Domain.Interfaces;
using Movie.Domain.Models;
using Movie.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Infraestructure.Data.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MovieDbContext _dbContext;

        public MoviesRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Movies> GetMovieById(int id)
        {
            var movie = from m in _dbContext.Movies where m.Id == id select m;
            return movie;
        }

        public IEnumerable<Movies> GetMovies()
        {
            return _dbContext.Movies;
        }
    }
}
