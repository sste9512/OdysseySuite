using System.Text.Json;

namespace Kotortool_Legacy.Application.Interfaces;

public interface IProjectManager
{
    public Task<Project> CreateNewFromPath(string filePath,string userId, string name);

    public Task<Project> QueryProject(string projectId);
}

public class BaseProjectManager() : IProjectManager
{
    public async Task<Project> CreateNewFromPath(string filePath, string userId, string name)
    {
        var rootdirectory = AppDomain.CurrentDomain.BaseDirectory + "/projects/";

        if (!Directory.Exists(rootdirectory))
        {
            Directory.CreateDirectory(rootdirectory);
        }

        var projectDirectory = rootdirectory + "/" + name;

        if (!Directory.Exists(projectDirectory))
        {
            Directory.CreateDirectory(projectDirectory);
        }

        var project = new Project
        {
            Id =  Guid.NewGuid(),
            FilePath = filePath,
            UserId = userId,
            Name = name
        };

        /*using (var file = File.CreateText(projectDirectory + "/project.json"))
        {
            var serializer = new JsonSerializer();
            serializer.Serialize(file, project);
        }*/

        return project;
    }

    public Task<Project> QueryProject(string projectId)
    {
        throw new System.NotImplementedException();
    }
}