using Microsoft.AspNetCore.Mvc;
using Movie.Application.Interfaces;

namespace Movie.UI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_moviesService.GetMovies());
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_moviesService.GetMovieById(id));
        }
    }
}
