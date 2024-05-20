using OdysseyStudio.Server.Application.Infrastructure;

namespace OdysseyStudio.Server.Api.Endpoints;

public sealed class ResourceEndpoints : EndpointGroupBase
{

    public override void Map(WebApplication app)
    {
        app.MapGroup(this);
        //.MapGet(GetChitinKey, "{projectId}")
    }

    /*public async Task<string> GetChitinKey([FromServices]IIdentityService identityService,[FromServices]IDocumentStore documentStore, string projectId)
    {
        
        return await identityService.GetUserNameAsync(userId);
    }*/

}