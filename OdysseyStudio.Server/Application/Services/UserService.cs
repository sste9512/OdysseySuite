using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Infrastructure.Identity;

namespace OdysseyStudio.Server.Application.Services;

public sealed class UserService : IUserService
{
    private readonly IApplicationFactory _applicationFactory;

    public UserService(IApplicationFactory applicationFactory)
    {
        _applicationFactory = applicationFactory;
    }
    
    public async Task<ApplicationUser?> GetUserAsync(string userId)
    {
        var cache = _applicationFactory.Create<IMemoryCache>();
        
        if (cache.TryGetValue(userId, out var user))
        {
            return ((ApplicationUser) user!);
        }

        using var userManager = _applicationFactory.Create<UserManager<ApplicationUser>>();
        var userFromDb = await userManager.FindByIdAsync(userId);
        cache.Set(userId, userFromDb, TimeSpan.FromMinutes(5));
        return userFromDb;
    }

    public async Task<List<ApplicationUser>?> GetUsersPaginatedAsync(int page, int pageSize)
    {
        var cache = _applicationFactory.Create<IMemoryCache>();
        
        if (cache.TryGetValue("cached-users", out List<ApplicationUser>? users))
        {
            return users;
        }

        using var userManager = _applicationFactory.Create<UserManager<ApplicationUser>>();
        var usersFromDb = await userManager.Users.Skip(page * pageSize)
            .Take(pageSize)
            .ToListAsync(CancellationToken.None);
        cache.Set("cached-users", usersFromDb, TimeSpan.FromMinutes(5));
        return usersFromDb;
    }

    public ValueTask<bool> UpdateUserAsync(ApplicationUser user)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteUserAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
