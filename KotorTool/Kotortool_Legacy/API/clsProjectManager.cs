// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsProjectManager
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class ClsProjectManager
{
    public ClsProjectManager(string ProjectFilePath)
    {
        this.ProjectFilePath = ProjectFilePath;
        if (File.Exists(ProjectFilePath))
            Project = LoadProject();
        if (Project != null)
            return;
        var num = (int)Interaction.MsgBox("Couldn't load project file", MsgBoxStyle.Critical,
            nameof(ClsProjectManager));
    }

    public ClsProjectManager(string ProjectFilePath, string NewProjectName)
    {
        this.ProjectFilePath = ProjectFilePath;
        Project = new ClsProject
        {
            Name = NewProjectName
        };
    }

    public ClsProject Project { get; set; }

    public string ProjectFilePath { get; set; }

    public int ProjectKotorVersionIndex
    {
        get => Project.KotorVersionIndex;
        set => Project.KotorVersionIndex = value;
    }

    public ArrayList GetProjectOverrideFiles() => Project.OverrideFiles;

    public int GetProjectModuleCount() => Project.Modules.Count;

    public ArrayList GetProjectModuleFiles(int fileNum) => (ArrayList)Project.Modules[fileNum];

    public ClsProject LoadProject() => LoadProject(ProjectFilePath);

    public ClsProject LoadProject(string projectPath)
    {
        ClsProject clsProject;
        try
        {
            if (File.Exists(projectPath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClsProject));
                FileStream fileStream = new FileStream(projectPath, FileMode.Open, FileAccess.Read);
                Project = (ClsProject)xmlSerializer.Deserialize(fileStream);
                fileStream.Close();
            }

            clsProject = Project;
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            int num = (int)Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "");
            clsProject = null;
            ProjectData.ClearProjectError();
        }

        return clsProject;
    }

    public void SaveProject() => SaveProject(ProjectFilePath, Project);

    public static void SaveProject(string ProjectFilePath, ClsProject Project)
    {
        try
        {
            var xmlSerializer = new XmlSerializer(typeof(ClsProject));
            var fileStream = new FileStream(ProjectFilePath, FileMode.Create, FileAccess.ReadWrite);
            xmlSerializer.Serialize(fileStream, Project);
            fileStream.Close();
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            int num = (int)Interaction.MsgBox(ex.ToString());
            ProjectData.ClearProjectError();
        }
    }
}