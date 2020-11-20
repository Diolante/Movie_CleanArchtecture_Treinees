using Movie.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Application.Interfaces
{
    public interface IDirectorsService
    {
        IEnumerable<DirectorsDto> GetDirectorsDtos();

        DirectorsDto PostDirector(DirectorsDto directorsDto);
    }
}
