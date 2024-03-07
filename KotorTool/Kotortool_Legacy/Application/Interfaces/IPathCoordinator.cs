namespace Kotortool_Legacy.Application.Interfaces;

public interface IPathCoordinator
{
    public string FindRootPath(string path);
    public string AppendRelativePath(string path);
}