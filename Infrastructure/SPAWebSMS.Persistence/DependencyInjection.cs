using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SPAWebSMS.Application.Interfaces;

namespace SPAWebSMS.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<SPAWebSMSDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<ISPAWebSMSDbContext>(provider =>
                provider.GetRequiredService<SPAWebSMSDbContext>());
            return services;
        }
    }
}
