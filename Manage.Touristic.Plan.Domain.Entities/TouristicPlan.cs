using System.ComponentModel.DataAnnotations.Schema;

namespace Manage.Touristic.Plan.Domain.Entities
{
    [Table("Plan",Schema ="VASS")]
    public class TouristicPlan
    {
        [Column("id_plan")]
        public Guid Id { get; set; }

        [Column("fk_airline")]
        public int Airline { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("number_passenger_adult")]
        public int NumberAdults { get; set; }

        [Column("number_passenger_children")]
        public int NumberChildren { get; set; }

        [Column("end_date")]
        public DateTimeOffset EndDate { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("discount")]
        public int Discount { get; set; }

        [Column("food")]
        public bool Food { get; set; }

        [Column("n_days")]
        public int NDays { get; set; }
    }
}