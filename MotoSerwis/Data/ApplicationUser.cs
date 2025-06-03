using Microsoft.AspNetCore.Identity;
using MotoSerwis.Data.Entities;

namespace MotoSerwis.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
