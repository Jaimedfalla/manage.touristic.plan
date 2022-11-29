using Manage.Touristic.Plan.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Manage.Touristic.Plan.Application.Main
{
    public static class StartUp
    {
        public static IServiceCollection InitApplication(this IServiceCollection service)
        {
            service.AddScoped<ITouristicPlanApplication, TouristicPlanApplication>();

            return service;
        }
    }
}
