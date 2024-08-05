using Microsoft.AspNetCore.Identity;

namespace ExaminationSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
