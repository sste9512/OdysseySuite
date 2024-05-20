using LiteDB;
using OdysseyStudio.Server.Domain.Entities;

namespace OdysseyStudio.Server.Application.Interfaces;

public interface IDocumentStore
{
    ILiteCollection<Project> Projects { get; }
}