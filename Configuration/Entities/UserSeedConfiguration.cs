using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
               new Employee
               {
                   Id = "cccd1234-6520-4cb0-8a5a-6113724b44a9",
                   Email = "admin@localhost.com",
                   NormalizedEmail = "ADMIN@LOCALHOST.COM",
                   UserName= "admin@localhost.com",
                   NormalizedUserName = "ADMIN@LOCALHOST.COM",
                   FirstName = "System",
                   LastName = "Admin",                 
                   PasswordHash = hasher.HashPassword(null, "P@ssWord1"),
                   EmailConfirmed = true
               },
               new Employee
               {
                  Id = "cbcd8765-6520-48ce-b45a-61a3724b44b9",
                  Email = "user@localhost.com",
                  NormalizedEmail = "USER@LOCALHOST.COM",
                  UserName = "user@localhost.com",
                  NormalizedUserName = "USER@LOCALHOST.COM",             
                  FirstName = "System",
                  LastName = "User",
                  PasswordHash = hasher.HashPassword(null, "P@ssWord1"),
                  EmailConfirmed = true
               });
        }
    }
}