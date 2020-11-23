using Microsoft.AspNetCore.Mvc;
using Movie.Application.Dtos;
using Movie.Application.Interfaces;
using Movie.Application.Validation;

namespace Movie.UI.WebApi.Controllers
{
    [Route("api/diretores")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorsService _directorsService;
        private readonly DirectorsValidation _directorsValidation;

        public DirectorsController(IDirectorsService directorsService, DirectorsValidation directorsValidation)
        {
            _directorsService = directorsService;
            _directorsValidation = directorsValidation;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_directorsService.GetDirectorsDtos());
        }

        [HttpPost]
        public IActionResult Post([FromBody]DirectorsDto directorsDto)
        {
            if (_directorsValidation.CountMoviesMoreThan15(directorsDto))
                return BadRequest("Não é possível cadastrar um diretor com mais de 15 filmes!");
            
            return Ok(_directorsService.PostDirector(directorsDto));
        }


        public int Calcular(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
