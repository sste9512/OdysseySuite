namespace OdysseyStudio.Server.Domain.Entities;

public sealed class Project
{
    public Guid Id { get; set;}
    public string FilePath { get; set; }
    public string GameBackupFilePath { get; set; }
    public string UserId { get; set; }
    public string Name { get; set; }
}