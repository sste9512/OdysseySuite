namespace Kotortool_Legacy.Application.Interfaces;

public interface IStartup
{
    Task Initialise(CancellationToken cancellationToken = default);
}