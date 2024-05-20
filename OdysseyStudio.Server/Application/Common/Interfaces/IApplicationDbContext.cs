using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdysseyStudio.Server.Domain.Entities;

namespace OdysseyStudio.Server.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Organization> Organizations { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

public enum FlowType
{
    Standard,
    ExternalOidc = 2,
    Oidc = 3
}



public sealed class OrganizationIdentityConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        throw new NotImplementedException();
    }
}

public sealed class SystemOnboardingResults
{
    
      public Guid GlobalAdmin { get; init; }
      public string? AdminEmail { get; init; }
      
}
