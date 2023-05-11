using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MicrosoftIdentity.Configurations.Base;
using MicrosoftIdentity.Entities;

namespace MicrosoftIdentity.Configurations.Entities;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable(DatabaseTableName.UseRole, DatabaseSchema.IdentitySchema);

        builder.HasData
            (new UserRole
            {
                RoleId=1,
                UserId=1,
            });
    }
}
