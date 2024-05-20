using Microsoft.AspNetCore.Mvc;
using OdysseyStudio.Server.Application.Infrastructure;
using OdysseyStudio.Server.Application.Interfaces;

namespace OdysseyStudio.Server.Api.Endpoints;

public sealed class FileExploration: EndpointGroupBase
{

    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(FindLogicalDrives, "/drives")
            .MapGet(ViewDirectory, "/explore/{directoryPath}");
    }

    private async Task<DirectoryInfo> ViewDirectory([FromServices]IIdentityService identityService,[FromServices]IDocumentStore documentStore, [FromQuery]string directoryPath)
    {
       return new DirectoryInfo(directoryPath);
    }

    private async Task<string[]> FindLogicalDrives()
    {
        return DriveInfo.GetDrives().Select(drive => drive.VolumeLabel).ToArray();
    }



}