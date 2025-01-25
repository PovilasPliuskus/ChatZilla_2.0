using ChatZilla.User.Application.Services;
using ChatZilla.User.Infrastructure.Persistence;
using ChatZilla.User.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ChatZilla.User
{
    public static class UserDiModule
    {
        public static IServiceCollection BuildUserDiModule(this IServiceCollection services, string postgresConnectionString)
        {
            services
                .AddScoped<IUserService, UserService>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddDbContext<UserDbContext>(options => options.UseNpgsql(postgresConnectionString));
            
            return services;
        }
    }
}