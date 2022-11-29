namespace Manage.Touristic.Plan.Infraestructure.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        ITouristicPlanRepository TouristicPlanRepository { get; }
    }
}
