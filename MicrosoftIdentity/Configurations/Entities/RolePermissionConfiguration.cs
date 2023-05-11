﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MicrosoftIdentity.Configurations.Base;
using MicrosoftIdentity.Entities;

namespace MicrosoftIdentity.Configurations.Entities;

public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable(DatabaseTableName.RolePermission, DatabaseSchema.IdentitySchema);
            builder.Property(t => t.RolePermissionId)
               .IsRequired()
               .ValueGeneratedOnAdd();

            builder.Property(t => t.Description)
              .HasMaxLength(512);

            //navigations
            builder.HasOne<Role>(a => a.Role)
           .WithMany(a => a.RolePermissions)
           .HasForeignKey(a => a.RoleId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Permission>(a => a.Permission)
           .WithMany(a => a.RolePermissions)
           .HasForeignKey(a => a.PermissionId)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }

