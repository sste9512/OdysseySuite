using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OdysseyStudio.Server.Application.Common.Interfaces;
using OdysseyStudio.Server.Domain.Constants;
using OdysseyStudio.Server.Infrastructure.Identity;

namespace OdysseyStudio.Server.Infrastructure.Data;

public static class InitialiserExtensions
{
    public static async Task InitialiseDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();

        await initialiser.InitialiseAsync();
    }
}

public sealed class ApplicationDbContextInitialiser(
    ILogger<ApplicationDbContextInitialiser> logger,
    ApplicationDbContext context,
    UserManager<ApplicationUser> userManager,
    RoleManager<IdentityRole> roleManager)
{
    public async Task InitialiseAsync()
    {
        try
        {
            if (!await context.Database.CanConnectAsync())
            {
                Console.WriteLine("Cannot connect to the database. Please check your connection string and try again.");
                return;
            }

            var pendingMigrations = await context.Database.GetPendingMigrationsAsync();

            if (pendingMigrations.Any())
            {
                Console.WriteLine("Applying pending migrations...");
                await context.Database.MigrateAsync();
            }

            await SeedAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while initialising the database");
            throw;
        }
    }

    private async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "An error occurred while seeding the database");
            throw;
        }
    }

    private async Task TrySeedAsync()
    {

        var standardAuthFlowType = new AuthorizationFlowType
        {
            Id = Guid.NewGuid(), Discriminator = "InternalFlowType", FlowType = FlowType.Standard, Enabled = true
        };

        /*if (!context.AuthorizationFlowTypes.Any())
        {
            await context.AuthorizationFlowTypes.AddAsync(standardAuthFlowType);
            await context.SaveChangesAsync();
        }*/
        
        
        // Default roles
        // TODO: Create default roles here
        var administratorRole = new IdentityRole(Roles.Administrator);
        var serviceAccountRole = new IdentityRole(Roles.ServiceAccount);
        
        
        if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await roleManager.CreateAsync(administratorRole);
        }

        if (!roleManager.Roles.Any(x => x.Name == serviceAccountRole.Name))
        {
            await roleManager.CreateAsync(serviceAccountRole);
        }
        

        await roleManager.AddClaimAsync(administratorRole, new Claim("iasUser", "administrator"));
        
        
        // Default users
        var administrator =
            new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

        
        
        if (userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await userManager.CreateAsync(administrator, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(administratorRole.Name))
            {
                await userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
            }
        }
    }
}
