using LiteDB;

namespace Kotortool_Legacy.Application.Interfaces;

public class DocumentStore : IDocumentStore
{
    private readonly ILiteDatabase _db;

    public DocumentStore(ILiteDatabase db)
    {
        _db = db;
    }

    public ILiteCollection<Project> Projects => _db.GetCollection<Project>();
}