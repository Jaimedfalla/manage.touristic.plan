using AutoMapper;
using Manage.Touristic.Plan.Domain.Entities;
using Manage.Touristic.Plan.Application.DTO;

namespace Manage.Touristic.Plan.Transversal.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<TouristicPlan, PlanDto>().ReverseMap();
        }
    }
}