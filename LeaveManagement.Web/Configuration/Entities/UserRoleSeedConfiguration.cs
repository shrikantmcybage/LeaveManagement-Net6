using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "0f4881d6-a06e-44b5-978c-bfcc9fcfbf29",  
                    UserId= "0d4881d6-a06e-44b5-978c-bfcc9fcfbf29"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "0d4881d6-b06e-44b5-978c-bfcc9fcfbf29",
                    UserId = "0d4881d6-a06e-44b5-978e-bfcc9fcfbf29"
                }
                );
        }
    }
}