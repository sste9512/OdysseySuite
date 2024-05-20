using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OdysseyStudio.Server.Application.Infrastructure;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Application.Models;
using OdysseyStudio.Server.Infrastructure.Identity;

namespace OdysseyStudio.Server.Api.Endpoints;


public sealed class UserManagement: EndpointGroupBase
{

    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetUserNameAsync, "{userId}")
            .MapGet(IsInRoleAsync, "{userId}/{role}")
            .MapPost(AuthorizeAsync, "{userId}/{policyName}")
            .MapPost(CreateUserAsync)
            .MapDelete(DeleteUserAsync, "{userId}");
    }

    public async Task<string> GetUserNameAsync([FromServices]IIdentityService identityService, string userId)
    {
        return await identityService.GetUserNameAsync(userId);
    }

    public Task<IdentityResult> CreateAsync([FromServices]IUserStore<ApplicationUser> userStore, ApplicationUser user, CancellationToken cancellationToken)
    {
        return userStore.CreateAsync(user, cancellationToken);
    }

    public Task<IdentityResult> UpdateAsync([FromServices]IUserStore<ApplicationUser> userStore,ApplicationUser user, CancellationToken cancellationToken)
    {
        return userStore.UpdateAsync(user, cancellationToken);
    }

    public Task<IdentityResult> DeleteAsync([FromServices]IUserStore<ApplicationUser> userStore,ApplicationUser user, CancellationToken cancellationToken)
    {
        return userStore.DeleteAsync(user, cancellationToken);
    }

    public Task<ApplicationUser?> FindByIdAsync([FromServices]IUserStore<ApplicationUser> userStore,string userId, CancellationToken cancellationToken)
    {
        return userStore.FindByIdAsync(userId, cancellationToken);
    }

    public async Task<bool> IsInRoleAsync([FromServices]IIdentityService identityService, string userId, string role)
    {
        return await identityService.IsInRoleAsync(userId, role);
    }

    public async Task<bool> AuthorizeAsync([FromServices]IIdentityService identityService, string userId, string policyName)
    {
        return await identityService.AuthorizeAsync(userId, policyName);
    }

    public async Task<(Result Result, string UserId)> CreateUserAsync([FromServices]IIdentityService identityService, string userName,
        string password)
    {
        return await identityService.CreateUserAsync(userName, password);
    }

    public async Task<Result> DeleteUserAsync([FromServices]IIdentityService identityService, string userId)
    {
        return await identityService.DeleteUserAsync(userId);
    }
}

