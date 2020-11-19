using Movie.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Application.Interfaces
{
    public interface IMoviesService
    {
        IEnumerable<MoviesDto> GetMovies();
        MoviesDto GetMovieById(int id);
    }
}
