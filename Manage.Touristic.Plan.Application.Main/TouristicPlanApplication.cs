using AutoMapper;
using Manage.Touristic.Plan.Application.DTO;
using Manage.Touristic.Plan.Application.Interface;
using Manage.Touristic.Plan.Domain.Entities;
using Manage.Touristic.Plan.Transversal.Common;
using Manage.Touristic.Plan.Transversal.Common.Constants;
using Manage.Touristic.Plan.Domain.Interface;

namespace Manage.Touristic.Plan.Application.Main
{
    internal class TouristicPlanApplication : ITouristicPlanApplication
    {
        private readonly IMapper _mapper;
        private readonly ITouristicPlanDomain _service;
        private const string PLAN = "Touristic plan";

        public TouristicPlanApplication(IMapper mapper, ITouristicPlanDomain service)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<Response<bool>> CreateAsync(PlanDto Plan)
        {
            Response<bool> response = new Response<bool>();
            try
            {
                TouristicPlan newPlan = _mapper.Map<TouristicPlan>(Plan);
                response.Data = await _service.AddPlanAsync(newPlan);
                response.IsSuccess = true;
                response.Message = string.Format(Messages.SUCCESS,PLAN,Messages.CREATED);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}