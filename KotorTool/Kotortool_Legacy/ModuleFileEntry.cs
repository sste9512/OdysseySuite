using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public sealed class ModuleFileEntry
{
    private string _mModuleName;
    private ArrayList _mModuleFiles;
    private string _mPackageType;

    public ModuleFileEntry()
    {
        _mPackageType = "MOD";
        _mModuleName = "";
        _mModuleFiles = new ArrayList();
    }

    public ModuleFileEntry(string Name)
        : this()
    {
        _mModuleName = Name;
    }

    public string ModuleName
    {
        get => _mModuleName;
        set => _mModuleName = value;
    }

    public string PackageType
    {
        get => _mPackageType;
        set => _mPackageType = value;
    }

    [XmlIgnore]
    public Hashtable FilesHashTable
    {
        get
        {
            Hashtable filesHashTable = new Hashtable(ModuleFiles.Count);
            try
            {
                foreach (object moduleFile in ModuleFiles)
                {
                    string key = StringType.FromObject(moduleFile);
                    filesHashTable.Add(key, "");
                }
            }
            finally
            {
            }

            return filesHashTable;
        }
    }

    [XmlArrayItem(typeof(string))]
    [XmlArray]
    public ArrayList ModuleFiles
    {
        get => _mModuleFiles;
        set => _mModuleFiles = value;
    }
}