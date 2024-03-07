using Kotortool_Legacy.Application.Interfaces;

namespace Kotortool_Legacy.Application.Implementations;

public sealed class ScopedPathCoordinator : IPathCoordinator
{
    private readonly IApplicationInfo _applicationInfo;

    public ScopedPathCoordinator(IApplicationInfo applicationInfo)
    {
            _applicationInfo = applicationInfo;
        }
        
    public string FindRootPath(string path)
    {
            return default;
        }

    public string AppendRelativePath(string path)
    {
            return _applicationInfo.RootPath + path;
        }
}