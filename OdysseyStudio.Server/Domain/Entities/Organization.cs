using OdysseyStudio.Server.Application.Common.Interfaces;
using OdysseyStudio.Server.Domain.Common;

namespace OdysseyStudio.Server.Domain.Entities;

/// <summary>
/// Data for entire client organization, central point of authority for all users and applications
/// </summary>
public sealed class Organization : BaseAuditableEntity<Guid>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }
    public string? Logo { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<AuthorizationFlowType>? AuthorizationFlowTypes { get; init; }
    
    /// <summary>
    /// Singular, there can only exist one of these per organization
    /// </summary>
    public AuthenticationEnforcementPolicy? AuthorizationEnforcementPolicy { get; init; }
    
}
