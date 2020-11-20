using Movie.Domain.Interfaces;
using Movie.Domain.Models;
using Movie.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Infraestructure.Data.Repositories
{
    public class DirectorsRepository : IDirectorsRepository
    {
        private readonly MovieDbContext _dbContext;

        public DirectorsRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Directors> GetDirectors()
        {

            return _dbContext.Directors;
        }

        public Directors PostDirector(Directors directors)
        {
            _dbContext.Directors.Add(directors);
            _dbContext.SaveChanges();

            return directors;
        }
    }
}
