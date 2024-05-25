using Microsoft.AspNetCore.Mvc;
using OdysseyStudio.Server.Application.Infrastructure;
using OdysseyStudio.Server.Application.Interfaces;
using OdysseyStudio.Server.Domain.Entities;
using IIdentityService = OdysseyStudio.Server.Application.Interfaces.IIdentityService;

namespace OdysseyStudio.Server.Api.Endpoints;

public sealed class ProjectManagement: EndpointGroupBase
{

    public override void Map(WebApplication app)
    {
        app.MapGroup(this).MapPost(CreateProject, "/create");
    }

    private async Task<Project> CreateProject([FromServices]IIdentityService identityService,[FromServices]IDocumentStore documentStore, [FromBody]Project project)
    {
        documentStore.Projects.Insert(project);
        return project;
    }

    /*public async Task<string> GetChitinKey([FromServices]IIdentityService identityService,[FromServices]IDocumentStore documentStore, string projectId)
    {

        return await identityService.GetUserNameAsync(userId);
    }*/

}