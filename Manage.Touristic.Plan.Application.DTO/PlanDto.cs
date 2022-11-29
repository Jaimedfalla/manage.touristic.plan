namespace Manage.Touristic.Plan.Application.DTO
{
    public class PlanDto
    {
        public Guid? Id { get; set; }
        public int Airline { get; set; }
        public string Name { get; set; }
        public int NumberAdults { get; set; }
        public int NumberChildren { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public bool Food { get; set; }
        public int NDays { get; set; }
    }
}