using System.ComponentModel.DataAnnotations.Schema;
using OdysseyStudio.Server.Application.Common.Interfaces;
using OdysseyStudio.Server.Domain.Common;

namespace OdysseyStudio.Server.Domain.Entities;

public sealed class AuthenticationEnforcementPolicy : BaseAuditableEntity<Guid>
{
    /// <summary>
    /// If this is enabled users can sign up or login with external providers 
    /// </summary>
    public bool AllowMultipleTypes { get; set; }

    [NotMapped] private List<(bool, AuthorizationFlowType)>? _authorizationFlowTypes = [];
    
    /// <summary>
    /// if -> Organization rules dictate only one type of login is allowed, the first value in the collection will be returned
    /// else -> all values will be returned
    /// </summary>
    [Column(TypeName = "jsonb")]
    public List<(bool, AuthorizationFlowType)> AuthorizationFlowTypes {
        get
        {
            return (!AllowMultipleTypes ? _authorizationFlowTypes![..1] : _authorizationFlowTypes)!;
        }
        set => _authorizationFlowTypes = value;
    }
}
