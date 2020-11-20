using Movie.Domain.Models;
using System.Collections.Generic;

namespace Movie.Domain.Interfaces
{
    public interface IDirectorsRepository
    {
        IEnumerable<Directors> GetDirectors();

        Directors PostDirector(Directors directors);
    }
}
