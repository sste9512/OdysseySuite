using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Kotortool_Legacy;

public class UserSettings
{
    public static Options GetSettings(string path = default)
    {
            Options settings;
            try
            {
                /*var path = Path.Combine(
                    StringType.FromObject(
                        Registry.LocalMachine.OpenSubKey(@"software\SCM\Kotor Tool")?.GetValue("path")),
                    "settings.xml");*/
                Options options;
                if (File.Exists(path))
                {
                    var xmlSerializer = new XmlSerializer(typeof(Options));
                    var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    options = (Options)xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();
                }
                else
                {
                    /*options = new Options
                    {
                        defaultSaveLocation = StringType.FromObject(Registry.LocalMachine
                            .OpenSubKey(@"software\SCM\Kotor Tool")?.GetValue("path"))
                    };
                    if (!options.defaultSaveLocation.EndsWith("\\"))
                        options.defaultSaveLocation += "\\";*/
                }

                //settings = options;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                var num = (int)Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "");
                settings = null;
                ProjectData.ClearProjectError();
            }

            return null;
            return settings;
        }

    public static void SaveSettings(Options currentSettings)
    {
            try
            {
                var path = Path.Combine(
                    StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool")
                        ?.GetValue("path")), "settings.xml");
                var xmlSerializer = new XmlSerializer(typeof(Options));
                var fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                xmlSerializer.Serialize(fileStream, currentSettings);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                var num = (int)Interaction.MsgBox(ex.ToString());
                ProjectData.ClearProjectError();
            }
        }
}