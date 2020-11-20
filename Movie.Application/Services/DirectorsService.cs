using Movie.Application.Dtos;
using Movie.Application.Interfaces;
using Movie.Domain.Interfaces;
using Movie.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Application.Services
{
    public class DirectorsService : IDirectorsService
    {
        private readonly IDirectorsRepository _directorsRepository;

        public DirectorsService(IDirectorsRepository directorsRepository)
        {
            _directorsRepository = directorsRepository;
        }

        public IEnumerable<DirectorsDto> GetDirectorsDtos()
        {
            var diretoresDto = new List<DirectorsDto>();

            var diretores = _directorsRepository.GetDirectors();

            foreach (var diretor in diretores)
            {
                diretoresDto.Add(new DirectorsDto() {
                    codigo = diretor.Id,
                    nome = diretor.Name,
                    quantidade_filmes = diretor.CountMovies
                });
            }

            return diretoresDto;
        }

        public DirectorsDto PostDirector(DirectorsDto directorsDto)
        {
            var diretor = new Directors() {
                Name = directorsDto.nome,
                CountMovies = directorsDto.quantidade_filmes
            };

            _directorsRepository.PostDirector(diretor);

            return directorsDto;
        }
    }
}
