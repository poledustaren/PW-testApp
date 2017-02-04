using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ParrotWingsTestApplication.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<UserPw> UserPws { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}