using Manage.Touristic.Plan.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Manage.Touristic.Plan.Domain.Core
{
    public static class Startup
    {
        public static IServiceCollection InitDomain(this IServiceCollection service)
        {
            service.AddScoped<ITouristicPlanDomain, TouristicPlanDomain>();

            return service;
        }
    }
}
