using LeaveManagement.Configuration.StringsRoles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace LeaveManagement.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {


        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "5cca1535-0256-4cb0-8a5a-6113724b44a9",
                    //Name = "Administrator",
                    Name = Role.Admin,
                    //NormalizedName = "ADMINISTRATOR"
                    NormalizedName = Role.Admin.ToUpper()
                },
                new IdentityRole
                {
                    Id = "a45d23bc-0256-4bb1-8d0f-6113224b44a9",
                    // Name = "User",
                    Name = Role.User,
                    //NormalizedName = "USER"
                    NormalizedName = Role.User.ToUpper()
                }) ;
        }
    }
}