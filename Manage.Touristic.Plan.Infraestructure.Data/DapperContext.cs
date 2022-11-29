using Manage.Touristic.Plan.Transversal.Common.Constants;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace Manage.Touristic.Plan.Infraestructure.Data
{
    public class DapperContext
    {
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _connectionString = configuration[Variables.CONNECTION_STRING_NAME];
        }

        public IDbConnection CreateConnection() => new NpgsqlConnection(_connectionString);
    }
}
