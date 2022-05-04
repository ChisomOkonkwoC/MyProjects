using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infastructure
{
    public static class Extension
    {
        public static void RegisterDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                getAssembly => getAssembly.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
                ));
        }
    }
}
