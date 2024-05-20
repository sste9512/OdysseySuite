using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OdysseyStudio.Server.Application.Common.Interfaces;
using OdysseyStudio.Server.Domain.Entities;
using OdysseyStudio.Server.Infrastructure.Identity;

namespace OdysseyStudio.Server.Infrastructure.Data;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IApplicationDbContext
{
    public DbSet<Organization> Organizations => Set<Organization>();

    public DbSet<OrganizationIdentityConfiguration> OrganizationIdentityConfigurations =>
        Set<OrganizationIdentityConfiguration>();

    public DbSet<AuthorizationFlowType> AuthorizationFlowTypes => Set<AuthorizationFlowType>();

    public DbSet<AuthenticationEnforcementPolicy> AuthenticationEnforcementPolicies =>
        Set<AuthenticationEnforcementPolicy>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new OrganizationIdentityConfiguration());

        base.OnModelCreating(builder);
    }
}