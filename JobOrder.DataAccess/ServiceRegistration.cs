using JobOrder.Application.Interfaces;
using JobOrder.DataAccess.Context;
using JobOrder.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JobOrder.DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessLayerRegistration(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("joborderDb"));
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ILagRepository, LagRepository>();
        }
    }
}
