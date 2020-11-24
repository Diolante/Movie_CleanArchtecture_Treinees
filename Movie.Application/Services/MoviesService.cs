using Movie.Application.Dtos;
using Movie.Application.Interfaces;
using Movie.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie.Application.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;



        public MoviesService(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public MoviesDto GetMovieById(int id)
        {
            var movie = _moviesRepository.GetMovieById(id).FirstOrDefault();

            var movieDto = new MoviesDto() {
                codigo_filme = movie.Id,
                nome_filme = movie.Title,
                nota = movie.Rank
            };

            return movieDto;
        }

        public IEnumerable<MoviesDto> GetMovies()
        {
            List<MoviesDto> moviesDtos = new List<MoviesDto>();

            var movies = _moviesRepository.GetMovies();

            foreach (var movie in movies)
            {
                moviesDtos.Add(new MoviesDto()
                {
                    codigo_filme = movie.Id,
                    nome_filme = movie.Title,
                    nota = movie.Rank
                });
            }


            return moviesDtos;
        }
    }
}
