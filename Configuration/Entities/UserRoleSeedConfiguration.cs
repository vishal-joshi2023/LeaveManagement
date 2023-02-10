using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            builder.HasData(
                new IdentityUserRole<string> { 
                  // roleId & userId->Admin   
                  RoleId= "5cca1535-0256-4cb0-8a5a-6113724b44a9",
                  UserId= "cccd1234-6520-4cb0-8a5a-6113724b44a9"
                },
                new IdentityUserRole<string>
                {
                    // roleseed & userseed->User 
                    RoleId = "a45d23bc-0256-4bb1-8d0f-6113224b44a9",
                    UserId = "cbcd8765-6520-48ce-b45a-61a3724b44b9"
                }
                );
        }
    }
}