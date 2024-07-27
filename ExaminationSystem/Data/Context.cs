using ExaminationSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ExaminationSystem.Data
{
    public class Context:IdentityDbContext<ApplicationUser>
    {
    }
}
