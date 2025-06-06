using MotoSerwis.Components.Account.Shared.Enums;

namespace MotoSerwis.Data.Entities
{
    public class Service
    {
        // Unikalny identyfikator zlecenia
        public int Id { get; set; }
        // Powiazana marka motocykla
        public int MakeId { get; set; }
        public Make Make { get; set; }
        // Powiazany model motocykla
        public int ModelId { get; set; }
        public Model Model { get; set; }
        // Klient jaki zglosil moto
        public int ClientId { get; set; }
        public Client Client { get; set; }
        // Mechanik przypisany
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } //ef
        public int YearOfManufacture { get; set; }
        public string IssueDescription { get; set; } = null!;
        public MotorcycleServiceStatus Status { get; set; }
        public string MotorcycleVin { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
