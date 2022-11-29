using Manage.Touristic.Plan.Infraestructure.Interface;

namespace Manage.Touristic.Plan.Infraestructure.Repositories
{
    internal class UnitOfWork:IUnitOfWork
    {
        public ITouristicPlanRepository TouristicPlanRepository { get; }

        public UnitOfWork(ITouristicPlanRepository customers)
        {
            TouristicPlanRepository = customers;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
