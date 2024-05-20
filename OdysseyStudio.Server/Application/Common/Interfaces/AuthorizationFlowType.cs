namespace OdysseyStudio.Server.Application.Common.Interfaces;

public sealed class AuthorizationFlowType
{
    public Guid Id { get; set; }
    public string? Discriminator { get; set; }
    public FlowType FlowType { get; set; }
    public bool Enabled { get; set; }
}
