using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.Application.Dtos;
using Movie.Application.Interfaces;

namespace Movie.UI.WebApi.Controllers
{
    [Route("api/diretores")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorsService _directorsService;

        public DirectorsController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_directorsService.GetDirectorsDtos());
        }

        [HttpPost]
        public IActionResult Post([FromBody]DirectorsDto directorsDto)
        {
            return Ok(_directorsService.PostDirector(directorsDto));
        }
    }
}
