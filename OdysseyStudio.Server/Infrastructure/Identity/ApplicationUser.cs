using Microsoft.AspNetCore.Identity;
using OdysseyStudio.Server.Application.Common.Interfaces;

namespace OdysseyStudio.Server.Infrastructure.Identity;

public sealed class ApplicationUser : IdentityUser
{
    public Guid AuthorizationFlowTypeId { get; set; }
    public AuthorizationFlowType? AuthorizationFlowType { get; set; }
}
