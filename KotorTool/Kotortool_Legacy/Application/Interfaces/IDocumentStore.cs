using LiteDB;

namespace Kotortool_Legacy.Application.Interfaces;

public interface IDocumentStore
{
    ILiteCollection<Project> Projects { get; }
}