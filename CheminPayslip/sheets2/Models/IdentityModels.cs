using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CheminPayslip.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<EmployeeDetails> Employess { get; set; }
        public DbSet<myLogin> MyLogins { get; set; }
        public DbSet<EmployeeDetails2> Employee2 { get; set; }
        public DbSet<EmployeeDetails3> Employee3 { get; set; }
        public DbSet<Site> SiteAdmin { get; set; }
        public DbSet<TableValid> TableValid { get; set; }
        public DbSet<MasterSite> Master { get; set; }
        public DbSet<SubContract> Sub { get; set; }
        public DbSet<CoordinatorforSite> Coordinator { get; set; }
        public DbSet<Commitments> Commitment { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}