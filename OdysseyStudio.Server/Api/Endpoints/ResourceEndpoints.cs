using kotor_tool.API.AuroraParsers;
using kotor_tool.API.AuroraParsers.Biff;
using KotorDotnet.AuroraParsers.Chitin;
using Microsoft.AspNetCore.Mvc;
using OdysseyStudio.Server.Application.Infrastructure;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Domain.AuroraParsers.Chitin;

namespace OdysseyStudio.Server.Api.Endpoints;

public sealed class ResourceEndpoints : EndpointGroupBase
{

    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
           .MapGet(GetChitinKey, "{projectId}")
           .MapGet(GetBifObject, "{filePath}");
    }

    private async Task<KeyObject> GetChitinKey([FromServices]IIdentityService identityService,[FromServices]IDocumentStore documentStore, string path)
    {
        return new KeyObject(new AuroraFile(path));
    }

    private async Task<BiffObject> GetBifObject(string filePath)
    {
        return new BiffObject(new AuroraFile(filePath));
    }

}