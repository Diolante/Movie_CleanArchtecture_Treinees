using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Movie.Application.Dtos;
using Movie.Application.Interfaces;
using Movie.UI.WebApi.Controllers;
using System.Collections.Generic;
using FluentAssertions;


namespace Movie.Tests.UI.Controllers
{
    [TestClass]
    public class MoviesControllerTests
    {
        private MoviesController moviesController;
        Mock<IMoviesService> mockIMoviesService;

        [TestInitialize]
        public void Iniciar()
        {
            mockIMoviesService = new Mock<IMoviesService>();
            moviesController = new MoviesController(mockIMoviesService.Object);
        }

        [TestMethod]
        public void Get_Test_Ok()
        {
            var movies = new List<MoviesDto>() {
                    new MoviesDto(){
                        codigo_filme = 1,
                        nome_filme = "teste",
                        nota = 4
                    },
                    new MoviesDto(){
                        codigo_filme = 1,
                        nome_filme = "teste",
                        nota = 4
                    },
                    new MoviesDto(){
                        codigo_filme = 1,
                        nome_filme = "teste",
                        nota = 4
                    }
            };

            mockIMoviesService
                .Setup(m => m.GetMovies())
                .Returns(movies);

            mockIMoviesService
                .Setup(ms => ms.GetMovieById(1))
                .Returns(new MoviesDto() { });

            var result = moviesController.Get();
            var okResult = result as OkObjectResult;
            

            okResult.StatusCode.Should().Be(200);
            Assert.AreEqual(200, okResult.StatusCode);

            result.Should().NotBeNull();
            Assert.IsNotNull(result);
        }
    }
}
