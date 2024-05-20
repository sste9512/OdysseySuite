using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OdysseyStudio.Server.Application.Infrastructure;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Infrastructure.Identity;

namespace OdysseyStudio.Server.Api.Endpoints;

public sealed class AuthManagement : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        /*app.MapGroup(this)
            .MapPost(Authenticate);*/

        // Add a minimal action responsible for triggering a GitHub challenge
        // and redirecting the user agent to the GitHub authorization endpoint.
       // app.MapGet("challenge", () => Results.Challenge(properties: null, authenticationSchemes: [OpenIddictClientWebIntegrationConstants.Providers.GitHub]));
        
        
        /*app.MapMethods("callback/login/github", [HttpMethods.Get, HttpMethods.Post], async (HttpContext context) =>
        {
            var result = await context.AuthenticateAsync(OpenIddictClientWebIntegrationConstants.Providers.GitHub);

            return Results.Text(string.Format("{0} has {1} public repositories.",
                result.Principal!.FindFirst("name")!.Value,
                result.Principal!.FindFirst("public_repos")!.Value));
        });*/
        
        
    }


    /*public async Task<string> Authenticate(
        [FromServices] IIdentityService identityService,
        [FromServices] UserManager<ApplicationUser> userManager,
        [FromServices] UserClaimsPrincipalFactory<ApplicationUser> principalFactory,
        [FromServices] IAuthorizationService authorizationService,
        [FromBody] Credential credential)
    {
        const string secretKey = "kkkkkkkkkkkkkkkkkkkk";

        var user = userManager.Users.SingleOrDefault(u => u.UserName == String.Empty);

        if (user == null)
        {
            return string.Empty;
        }

        var principal = await principalFactory.CreateAsync(user);

        //var result = await authorizationService.AuthorizeAsync(principal, policyName);

        //return result.Succeeded;

        var jwt = new JwtSecurityToken(
            issuer: "https://localhost:5001",
            audience: "https://localhost:5001",
            claims: new[] { new Claim(ClaimTypes.Name, "John Doe") },
            expires: DateTime.Now.AddMinutes(5),
            signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)),
                SecurityAlgorithms.HmacSha256Signature)
        );

        var result = new JwtSecurityTokenHandler().WriteToken(jwt);

        return result;
        //return await identityService.AuthorizeAsync(userId, policyName);
    }*/
}
