using OdysseyStudio.Server.Infrastructure.Identity;

namespace OdysseyStudio.Server.Application.Interfaces;

public interface IUserService
{
    public Task<ApplicationUser?> GetUserAsync(string userId);
    public Task<List<ApplicationUser>?> GetUsersPaginatedAsync(int page, int pageSize);
    public ValueTask<bool> UpdateUserAsync(ApplicationUser user);
    public ValueTask<bool> DeleteUserAsync(string userId);
}
