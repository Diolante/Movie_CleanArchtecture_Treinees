using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movie.Application.Dtos;
using Movie.Application.Validation;


namespace Movie.Tests.Application.Validation
{
    [TestClass]
    public class DirectorsValidationTests
    {
        private DirectorsValidation directorsValidation;

        [TestInitialize]
        public void Iniciar()
        {
            directorsValidation = new DirectorsValidation();
        }

        [TestMethod]
        public void CountMoviesMoreThan15_Test_True()
        {
            var directorsDto = new DirectorsDto()
            {
                codigo = 1,
                nome = "Diretor test",
                quantidade_filmes = 15
            };

            var expected = false;

            var result = directorsValidation.CountMoviesMoreThan15(directorsDto);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CountMoviesMoreThan15_Test_False()
        {
            var directorsDto = new DirectorsDto()
            {
                codigo = 1,
                nome = "Diretor test",
                quantidade_filmes = 150
            };

            var expected = false;

            var result = directorsValidation.CountMoviesMoreThan15(directorsDto);

            Assert.IsTrue(result);
        }
    }
}
