using Microsoft.AspNetCore.Identity;

namespace HospitalManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public required string UserName { get; set; }
        public required string Email { get; set; }

    }
}

