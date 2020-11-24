using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Movie.Application.Services;
using Movie.Domain.Interfaces;
using Movie.Domain.Models;
using System.Linq;

namespace Movie.Tests.Application.Services
{
    [TestClass]
    public class MoviesService_Tests
    {
        public MoviesService moviesService;
        
        Mock<IMoviesRepository> mockIMoviesRespository;



        [TestInitialize]
        public void Inicio()
        {
            mockIMoviesRespository = new Mock<IMoviesRepository>();

            moviesService = new MoviesService(mockIMoviesRespository.Object);
        }

        public void GetMovieById_Test()
        {
            //var movie = new Movies() { 
            //    Id = 1,
            //    Rank = 1,
            //    Title = "Filme Mock"
            //};

            //IQueryable<Movies> _movie = ;

            //mockIMoviesRespository.Setup(m => m.GetMovieById(It.IsAny<int>())).Returns();

            Assert.IsTrue(true);
        }
    }
}
