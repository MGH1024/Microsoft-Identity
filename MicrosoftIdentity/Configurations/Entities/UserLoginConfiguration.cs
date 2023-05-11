using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MicrosoftIdentity.Configurations.Base;
using MicrosoftIdentity.Entities;

namespace MicrosoftIdentity.Configurations.Entities;

public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
{
    public void Configure(EntityTypeBuilder<UserLogin> builder)
    {
        builder.ToTable(DatabaseTableName.UserLogin, DatabaseSchema.IdentitySchema);


        builder.Property(t => t.ProviderDisplayName)
            .HasMaxLength(512);
    }
}

