using Manage.Touristic.Plan.Application.Main;
using Manage.Touristic.Plan.Domain.Core;
using Manage.Touristic.Plan.Transversal.Mapper;
using Manage.Touristic.Plan.Infraestructure.Repositories;

namespace Manage.Touristic.Plan.Api.Modules.Layers
{
    public static class LayersExternsions
    {
        public static IServiceCollection AddLayers(this IServiceCollection services) {
            services.InitMapper();
            services.InitApplication();
            services.InitDomain();
            services.InitInfraestructure();
            services.InitMapper();

            return services;
        }

        public static IServiceCollection InitMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingProfile()));

            return services;
        }
    }
}
