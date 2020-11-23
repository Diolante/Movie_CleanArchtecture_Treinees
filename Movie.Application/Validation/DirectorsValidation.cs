using Movie.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Application.Validation
{
    public class DirectorsValidation
    {
        public bool CountMoviesMoreThan15(DirectorsDto directorsDto)
        {
            return directorsDto.quantidade_filmes > 15;

            //if (directorsDto.quantidade_filmes > 15)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
