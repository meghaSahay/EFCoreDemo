using Application;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace SocialNetworkingAPI.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            

            services.AddMediatR
            (
                cfg => cfg.RegisterServicesFromAssemblies(typeof(ListUsers.Handler).Assembly)
            );

            return services;
        }
        
    }
}