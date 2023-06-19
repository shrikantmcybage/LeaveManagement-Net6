using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29",
                    Email = "admin@abc.com",
                    NormalizedEmail = "ADMIN@ABC.COM",
                    NormalizedUserName = "ADMIN@ABC.COM",
                    UserName = "admin@abc.com",
                    Firstname = "Admin",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29",
                    Email = "user@abc.com",
                    NormalizedEmail = "USER@ABC.COM",
                    NormalizedUserName = "USER@ABC.COM",
                    UserName = "user@abc.com",
                    Firstname = "User",
                    Lastname = "UserLast",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true   
                }
            ) ;
        }
    }
}