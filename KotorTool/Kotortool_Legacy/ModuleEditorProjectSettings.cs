// Decompiled with JetBrains decompiler
// Type: kotor_tool.ModuleEditorProjectSettings
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class ModuleEditorProjectSettings
{
    public static ModuleEditorProjectOptions GetSettings(string LoadPath)
    {
            ModuleEditorProjectOptions settings;
            try
            {
                LoadPath = Path.Combine(LoadPath, "project settings.xml");
                ModuleEditorProjectOptions editorProjectOptions;
                if (File.Exists(LoadPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ModuleEditorProjectOptions));
                    FileStream fileStream = new FileStream(LoadPath, FileMode.Open, FileAccess.Read);
                    editorProjectOptions = (ModuleEditorProjectOptions)xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();
                }
                else
                    editorProjectOptions = new ModuleEditorProjectOptions();

                settings = editorProjectOptions;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "");
                settings = null;
                ProjectData.ClearProjectError();
            }

            return settings;
        }

    public static void SaveSettings(ModuleEditorProjectOptions currentSettings, string savePath)
    {
            try
            {
                savePath = Path.Combine(savePath, "project settings.xml");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ModuleEditorProjectOptions));
                FileStream fileStream = new FileStream(savePath, FileMode.Create, FileAccess.ReadWrite);
                xmlSerializer.Serialize(fileStream, currentSettings);
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