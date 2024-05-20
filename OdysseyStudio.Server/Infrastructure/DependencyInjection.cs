using Ardalis.GuardClauses;
using LiteDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Domain.Constants;
using OdysseyStudio.Server.Infrastructure.Data;
using OdysseyStudio.Server.Infrastructure.Data.Interceptors;
using OdysseyStudio.Server.Infrastructure.Identity;
using IApplicationDbContext = OdysseyStudio.Server.Application.Common.Interfaces.IApplicationDbContext;
using IIdentityService = OdysseyStudio.Server.Application.Common.Interfaces.IIdentityService;

namespace OdysseyStudio.Server.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        Guard.Against.Null(connectionString, message: "Connection string 'DefaultConnection' not found.");

        services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
        services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.UseSqlite("Data Source=blogging.db");
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
        });

        services.AddScoped<ILiteDatabase>(x => new LiteDatabase("Filename=MyData.db; Connection=shared"));
        services.AddScoped<IDocumentStore, DocumentStore>();

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<ApplicationDbContextInitialiser>();

        services.AddAuthorizationBuilder();


        /*services.AddOpenIddict()
            .AddClient(options =>
            {
                // Allow the OpenIddict client to negotiate the authorization code flow.
                options.AllowAuthorizationCodeFlow();

                // Register the signing and encryption credentials used to protect
                // sensitive data like the state tokens produced by OpenIddict.
                options.AddDevelopmentEncryptionCertificate()
                    .AddDevelopmentSigningCertificate();

                // Register the ASP.NET Core host and configure the ASP.NET Core-specific options.
                // options.UseAspNetCore()
                //     .EnableRedirectionEndpointPassthrough();

                // Register the GitHub integration.
                options.UseWebProviders()
                    .AddGitHub(options =>
                    {
                        options.SetClientId("[your client identifier]")
                            .SetClientSecret("[your client secret]")
                            .SetRedirectUri("callback/login/github");
                    });

                options.UseWebProviders().AddAuth0(x =>
                {
                    x.SetClientId("");
                    x.SetClientSecret("");
                    x.SetRedirectUri("");
                });
            })
            .AddCore(options =>
            {
                options
                    .UseEntityFrameworkCore()
                    .UseDbContext<ApplicationDbContext>();
            })
            .AddServer(options =>
            {
                options.AllowPasswordFlow();
                options.SetTokenEndpointUris("login");

                options.AcceptAnonymousClients();

                options.AddDevelopmentEncryptionCertificate();
                options.AddDevelopmentSigningCertificate();

                options.UseAspNetCore()
                    .EnableTokenEndpointPassthrough();
            })
            .AddValidation(options =>
            {
                options.UseLocalServer();

                options.UseAspNetCore();
            });*/

        services
            .AddIdentityCore<ApplicationUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddApiEndpoints();

        services.AddSingleton(TimeProvider.System);
        services.AddTransient<IIdentityService, IdentityService>();

        services.AddAuthorization(options =>
            options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));

        return services;
    }
}
