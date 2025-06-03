namespace MotoSerwis.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public virtual ICollection<Service> Services { get; set; }
    }
}
