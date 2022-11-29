using Manage.Touristic.Plan.Infraestructure.Interface;
using Manage.Touristic.Plan.Domain.Interface;
using Manage.Touristic.Plan.Domain.Entities;

namespace Manage.Touristic.Plan.Domain.Core
{
    internal class TouristicPlanDomain : ITouristicPlanDomain
    {
        private readonly IUnitOfWork _unitOfWork;

        public TouristicPlanDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> AddPlanAsync(TouristicPlan Plan) => _unitOfWork.TouristicPlanRepository.AddAsync(Plan);
    }
}