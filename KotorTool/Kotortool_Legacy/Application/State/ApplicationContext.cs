namespace Kotortool_Legacy.Application.State;

public sealed class ApplicationContext()
{
     public string ApplicationRootDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory;
  
}