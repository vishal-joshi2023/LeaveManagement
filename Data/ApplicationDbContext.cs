using LeaveManagement.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        // This is bridge btwn what we wwant vs what c# can do
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        // define Roles and Users
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }


        // Desing of the table based on leaveType
        // Dbset<> collection Type
        // these are connected o Db  
        public DbSet<LeaveType> LeaveTypes { get; set; } 
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    } 
}