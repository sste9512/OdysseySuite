using OdysseyStudio.Server.Domain.Common;

namespace OdysseyStudio.Server.Domain.Entities;

/// <summary>
/// Represents business account registered to this system, can hold or represent multiple organizations.
/// </summary>
public sealed class Account : BaseAuditableEntity<Guid>
{
     public string? Name { get; set; }
     public ICollection<Organization>? Organizations { get; set; }
}
