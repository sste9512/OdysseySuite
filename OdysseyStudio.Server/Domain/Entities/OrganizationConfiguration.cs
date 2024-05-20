using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OdysseyStudio.Server.Domain.Entities;



public sealed class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        
        builder.Property(t => t.Name).HasMaxLength(100);

        builder.Property(t => t.Description).HasMaxLength(200);

        builder.Property(t => t.Website).HasMaxLength(50);

        builder.Property(t => t.Logo).HasMaxLength(100);

        builder.Property(t => t.Address).HasMaxLength(100);

        builder.Property(t => t.City).HasMaxLength(100);

        builder.Property(t => t.State).HasMaxLength(40);

        builder.Property(t => t.Country).HasMaxLength(100);

        builder.Property(t => t.PostalCode).HasMaxLength(20);

        builder.Property(t => t.PhoneNumber).HasMaxLength(20);

        builder.Property(t => t.FaxNumber).HasMaxLength(20);

        builder.Property(t => t.Email).HasMaxLength(40);

        builder.Property(t => t.PrimaryContact).HasMaxLength(100);
    }
}
