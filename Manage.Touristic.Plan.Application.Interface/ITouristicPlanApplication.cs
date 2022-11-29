using Manage.Touristic.Plan.Application.DTO;
using Manage.Touristic.Plan.Transversal.Common;

namespace Manage.Touristic.Plan.Application.Interface
{
    public interface ITouristicPlanApplication
    {
        Task<Response<bool>> CreateAsync(PlanDto Plan);
    }
}
