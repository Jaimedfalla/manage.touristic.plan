using Manage.Touristic.Plan.Infraestructure.Data;
using Manage.Touristic.Plan.Infraestructure.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Manage.Touristic.Plan.Infraestructure.Repositories
{
    public static class StartUp
    {
        public static IServiceCollection InitInfraestructure(this IServiceCollection service)
        {
            service.AddSingleton<DapperContext>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<ITouristicPlanRepository, TouristicPlanRepository>();

            return service;
        }
    }
}
