using MotoSerwis.Components.Account.Shared.Enums;

namespace MotoSerwis.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int YearOfManufacture { get; set; }
        public string IssueDescription { get; set; } = null!;
        public MotorcycleServiceStatus Status { get; set; }
        public string MotorcycleVin { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
