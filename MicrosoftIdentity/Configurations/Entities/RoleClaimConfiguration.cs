﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MicrosoftIdentity.Configurations.Base;
using MicrosoftIdentity.Entities;

namespace MicrosoftIdentity.Configurations.Entities;

public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
{
    public void Configure(EntityTypeBuilder<RoleClaim> builder)
    {
        builder.ToTable(DatabaseTableName.RoleClaim, DatabaseSchema.IdentitySchema);

        builder.HasData(new RoleClaim
        {
            Id=1,
            RoleId=1,
            ClaimType = "roleName",
            ClaimValue= "Administrator"
        }, 
        new RoleClaim
        {
            Id = 2,
            RoleId = 2,
            ClaimType = "roleName",
            ClaimValue = "User"
        });

        builder.Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(t => t.ClaimType)
            .HasMaxLength(512);

        builder.Property(t => t.ClaimValue)
             .HasMaxLength(256);

    }
}

