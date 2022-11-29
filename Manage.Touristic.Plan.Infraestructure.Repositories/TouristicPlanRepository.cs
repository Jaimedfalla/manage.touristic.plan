using Dapper;
using Manage.Touristic.Plan.Domain.Entities;
using Manage.Touristic.Plan.Infraestructure.Data;
using Manage.Touristic.Plan.Infraestructure.Interface;
using System.Data;
using System.Text;

namespace Manage.Touristic.Plan.Infraestructure.Repositories
{
    internal class TouristicPlanRepository : ITouristicPlanRepository
    {
        private readonly DapperContext _context;

        public TouristicPlanRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(TouristicPlan entity)
        {
            using IDbConnection con = _context.CreateConnection();
            var command = con.CreateCommand();
            StringBuilder query = new StringBuilder("INSERT INTO VASS.Plan (fk_airline,name,number_passenger_adult,number_passenger_children,end_date,price,discount,food,n_days)");
            query = query.Append("VALUES (@airline,@name,@number_passenger_adult,@number_passenger_children,@end_date,@price,@discount,@food,@n_days)");

            var parameter = new DynamicParameters();
            parameter.Add("@airline", entity.Airline);
            parameter.Add("@name", entity.Name);
            parameter.Add("@number_passenger_adult", entity.NumberAdults);
            parameter.Add("@number_passenger_children", entity.NumberChildren);
            parameter.Add("@end_date", entity.EndDate);
            parameter.Add("@price", entity.Price);
            parameter.Add("@discount", entity.Discount);
            parameter.Add("@food", entity.Food);
            parameter.Add("@n_days", entity.NDays);

            var result = await con.ExecuteAsync(query.ToString(), parameter);
            return result > 0;
        }
    }
}
