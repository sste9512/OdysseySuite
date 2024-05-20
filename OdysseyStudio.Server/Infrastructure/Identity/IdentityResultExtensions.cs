using Microsoft.AspNetCore.Identity;
using OdysseyStudio.Server.Application.Models;

namespace OdysseyStudio.Server.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
