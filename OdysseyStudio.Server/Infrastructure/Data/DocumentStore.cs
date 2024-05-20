using LiteDB;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Domain.Entities;

namespace OdysseyStudio.Server.Infrastructure.Data;

public sealed class DocumentStore(ILiteDatabase db) : IDocumentStore
{
    public ILiteCollection<Project> Projects => db.GetCollection<Project>();
    
    
}