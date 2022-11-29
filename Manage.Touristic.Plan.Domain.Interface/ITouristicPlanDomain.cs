using Manage.Touristic.Plan.Domain.Entities;

namespace Manage.Touristic.Plan.Domain.Interface;
public interface ITouristicPlanDomain
{
    Task<bool> AddPlanAsync(TouristicPlan Plan);
}
