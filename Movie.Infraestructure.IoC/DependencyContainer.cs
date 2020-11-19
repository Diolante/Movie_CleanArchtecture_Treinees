using Microsoft.Extensions.DependencyInjection;
using Movie.Application.Interfaces;
using Movie.Application.Services;
using Movie.Domain.Interfaces;
using Movie.Infraestructure.Data.Repositories;

namespace Movie.Infraestructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IMoviesService, MoviesService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IMoviesRepository, MoviesRepository>();
        }
    }
}
