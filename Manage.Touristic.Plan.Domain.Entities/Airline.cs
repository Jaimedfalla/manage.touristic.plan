using System.ComponentModel.DataAnnotations.Schema;

namespace Manage.Touristic.Plan.Domain.Entities
{
    [Table("airline")]
    public class Airline
    {
        [Column("id_airline")]
        private int Id { get; set; }

        [Column("name")]
        private string Name { get; set; }
    }
}
