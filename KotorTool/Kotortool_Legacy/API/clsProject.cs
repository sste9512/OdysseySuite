// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsProject
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

[Serializable]
public class ClsProject
{
    private string _mProjectName;
    private ArrayList _mOverrideFiles;
    private ArrayList _mModules;
    private ArrayList _mLipsModules;
    private ArrayList _mStreamWavesFiles;
    private ArrayList _mStreamWavesModules;
    private string _mReleaseFilePath;
    private string _mDebugFilePath;
    private int _mKotorVersionIndex;

    public ClsProject()
    {
        _mProjectName = "Project";
        _mOverrideFiles = new ArrayList();
        _mModules = new ArrayList();
        _mLipsModules = new ArrayList();
        _mStreamWavesFiles = new ArrayList();
        _mStreamWavesModules = new ArrayList();
        _mKotorVersionIndex = -1;
    }

    public string Name
    {
        get => _mProjectName;
        set => _mProjectName = value;
    }

    public string DebugFilePath
    {
        get => _mDebugFilePath;
        set => _mDebugFilePath = value;
    }

    public string ReleaseFilePath
    {
        get => _mReleaseFilePath;
        set => _mReleaseFilePath = value;
    }

    [XmlArray]
    [XmlArrayItem(typeof(string))]
    public ArrayList OverrideFiles
    {
        get => _mOverrideFiles;
        set => _mOverrideFiles = value;
    }

    [XmlArray]
    [XmlArrayItem(typeof(ModuleFileEntry))]
    public ArrayList Modules
    {
        get => _mModules;
        set => _mModules = value;
    }

    [XmlArray]
    [XmlArrayItem(typeof(ModuleFileEntry))]
    public ArrayList LipsModules
    {
        get => _mLipsModules;
        set => _mLipsModules = value;
    }

    [XmlArrayItem(typeof(string))]
    [XmlArray]
    public ArrayList StreamWavesFiles
    {
        get => _mStreamWavesFiles;
        set => _mStreamWavesFiles = value;
    }

    [XmlArrayItem(typeof(ModuleFileEntry))]
    [XmlArray]
    public ArrayList StreamWavesModules
    {
        get => _mStreamWavesModules;
        set => _mStreamWavesModules = value;
    }

    [XmlIgnore]
    public Hashtable OverrideFilesHashTable
    {
        get
        {
            var overrideFilesHashTable = new Hashtable(_mOverrideFiles.Count);
            try
            {
                foreach (var overrideFile in _mOverrideFiles)
                {
                    var key = StringType.FromObject(overrideFile);
                    overrideFilesHashTable.Add(key, "");
                }
            }
            finally
            {
                  
            }

            return overrideFilesHashTable;
        }
    }

    [XmlIgnore]
    public Hashtable StreamWavesFilesHashTable
    {
        get
        {
            var wavesFilesHashTable = new Hashtable(_mStreamWavesFiles.Count);
            try
            {
                foreach (var streamWavesFile in _mStreamWavesFiles)
                {
                    var key = StringType.FromObject(streamWavesFile);
                    wavesFilesHashTable.Add(key, "");
                }
            }
            finally
            {
                   
            }

            return wavesFilesHashTable;
        }
    }

    public int KotorVersionIndex
    {
        get => _mKotorVersionIndex;
        set => _mKotorVersionIndex = value;
    }

    public int GetModuleIndex(string ModuleName)
    {
        var num = checked(_mModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mModules[index]).ModuleName, ModuleName, false) == 0)
                return index;
            checked
            {
                ++index;
            }
        }

        return -1;
    }

    public void RemoveAllModules() => _mModules.Clear();

    public int AddModule(string Name) => _mModules.Add(new ModuleFileEntry(Name));

    public int AddModuleFile(string ModuleName, string FilePath)
    {
        var num = checked(_mModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mModules[index]).ModuleName, ModuleName, false) == 0)
            {
                ((ModuleFileEntry)_mModules[index]).ModuleFiles.Add(FilePath);
                return 0;
            }

            checked
            {
                ++index;
            }
        }

        return -1;
    }

    public void RemoveModule(string ModuleName)
    {
        var num = checked(_mModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mModules[index]).ModuleName, ModuleName, false) == 0)
            {
                _mModules.RemoveAt(index);
                break;
            }

            checked
            {
                ++index;
            }
        }
    }

    public void RemoveAllModuleFiles(string ModuleName)
    {
        var num = checked(_mModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mModules[index]).ModuleName, ModuleName, false) == 0)
            {
                ((ModuleFileEntry)_mModules[index]).ModuleFiles.Clear();
                break;
            }

            checked
            {
                ++index;
            }
        }
    }

    public ArrayList GetModuleNames()
    {
        var moduleNames = new ArrayList();
        try
        {
            foreach (ModuleFileEntry module in _mModules)
                moduleNames.Add(module.ModuleName);
        }
        finally
        {
               
        }

        return moduleNames;
    }

    public ArrayList GetModuleFiles(int index) =>
        _mModules.Count >= index ? ((ModuleFileEntry)_mModules[index]).ModuleFiles : null;

    public ArrayList GetModuleFiles(string ModuleName) =>
        ((ModuleFileEntry)_mModules[GetModuleIndex(ModuleName)]).ModuleFiles;

    public int RemoveModuleFile(string ModuleName, string FilePath)
    {
        var num = checked(_mModules.Count - 1);
        var index1 = 0;
        while (index1 <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mModules[index1]).ModuleName, ModuleName, false) == 0)
            {
                var index2 = ((ModuleFileEntry)_mModules[index1]).ModuleFiles.IndexOf(FilePath);
                if (index2 != -1)
                {
                    ((ModuleFileEntry)_mModules[index1]).ModuleFiles.RemoveAt(index2);
                    return 0;
                }
            }

            checked
            {
                ++index1;
            }
        }

        return -1;
    }

    public int RemoveOverrideFile(string FilePath)
    {
        var index = _mOverrideFiles.IndexOf(FilePath);
        if (index == -1)
            return -1;
        _mOverrideFiles.RemoveAt(index);
        return 0;
    }

    public void RemoveAllOverrideFiles() => _mOverrideFiles.Clear();

    public int GetLipsModuleIndex(string ModuleName)
    {
        var num = checked(_mLipsModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mLipsModules[index]).ModuleName, ModuleName, false) == 0)
                return index;
            checked
            {
                ++index;
            }
        }

        return -1;
    }

    public void RemoveAllLipsModules() => _mLipsModules.Clear();

    public int AddLipsModule(string Name) => _mLipsModules.Add(new ModuleFileEntry(Name));

    public int AddLipsModuleFile(string ModuleName, string FilePath)
    {
        var num = checked(_mLipsModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mLipsModules[index]).ModuleName, ModuleName, false) == 0)
            {
                ((ModuleFileEntry)_mLipsModules[index]).ModuleFiles.Add(FilePath);
                return 0;
            }

            checked
            {
                ++index;
            }
        }

        return -1;
    }

    public void RemoveLipsModule(string ModuleName)
    {
        var num = checked(_mLipsModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mLipsModules[index]).ModuleName, ModuleName, false) == 0)
            {
                _mLipsModules.RemoveAt(index);
                break;
            }

            checked
            {
                ++index;
            }
        }
    }

    public void RemoveAllLipsModuleFiles(string ModuleName)
    {
        var num = checked(_mLipsModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mLipsModules[index]).ModuleName, ModuleName, false) == 0)
            {
                ((ModuleFileEntry)_mLipsModules[index]).ModuleFiles.Clear();
                break;
            }

            checked
            {
                ++index;
            }
        }
    }

    public ArrayList GetLipsModuleNames()
    {
        var lipsModuleNames = new ArrayList();
        try
        {
            foreach (ModuleFileEntry lipsModule in _mLipsModules)
                lipsModuleNames.Add(lipsModule.ModuleName);
        }
        finally
        {
               
        }

        return lipsModuleNames;
    }

    public ArrayList GetLipsModuleFiles(int index) => _mLipsModules.Count >= index
        ? ((ModuleFileEntry)_mLipsModules[index]).ModuleFiles
        : null;

    public ArrayList GetLipsModuleFiles(string ModuleName) =>
        ((ModuleFileEntry)_mLipsModules[GetLipsModuleIndex(ModuleName)]).ModuleFiles;

    public int RemoveLipsModuleFile(string ModuleName, string FilePath)
    {
        var num = checked(_mLipsModules.Count - 1);
        var index1 = 0;
        while (index1 <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mLipsModules[index1]).ModuleName, ModuleName, false) == 0)
            {
                var index2 = ((ModuleFileEntry)_mLipsModules[index1]).ModuleFiles.IndexOf(FilePath);
                if (index2 != -1)
                {
                    ((ModuleFileEntry)_mLipsModules[index1]).ModuleFiles.RemoveAt(index2);
                    return 0;
                }
            }

            checked
            {
                ++index1;
            }
        }

        return -1;
    }

    public int GetStreamWavesModuleIndex(string ModuleName)
    {
        var num = checked(_mStreamWavesModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mStreamWavesModules[index]).ModuleName, ModuleName, false) ==
                0)
                return index;
            checked
            {
                ++index;
            }
        }

        return -1;
    }

    public void RemoveAllStreamWavesModules() => _mStreamWavesModules.Clear();

    public int AddStreamWavesModule(string Name) => _mStreamWavesModules.Add(new ModuleFileEntry(Name));

    public int AddStreamWavesModuleFile(string ModuleName, string FilePath)
    {
        var num = checked(_mStreamWavesModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mStreamWavesModules[index]).ModuleName, ModuleName, false) ==
                0)
            {
                ((ModuleFileEntry)_mStreamWavesModules[index]).ModuleFiles.Add(FilePath);
                return 0;
            }

            checked
            {
                ++index;
            }
        }

        return -1;
    }

    public void RemoveStreamWavesModule(string ModuleName)
    {
        var num = checked(_mStreamWavesModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mStreamWavesModules[index]).ModuleName, ModuleName, false) ==
                0)
            {
                _mStreamWavesModules.RemoveAt(index);
                break;
            }

            checked
            {
                ++index;
            }
        }
    }

    public void RemoveAllStreamWavesModuleFiles(string ModuleName)
    {
        var num = checked(_mStreamWavesModules.Count - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mStreamWavesModules[index]).ModuleName, ModuleName, false) ==
                0)
            {
                ((ModuleFileEntry)_mStreamWavesModules[index]).ModuleFiles.Clear();
                break;
            }

            checked
            {
                ++index;
            }
        }
    }

    public ArrayList GetStreamWavesModuleNames()
    {
        var wavesModuleNames = new ArrayList();
        try
        {
            foreach (ModuleFileEntry streamWavesModule in _mStreamWavesModules)
                wavesModuleNames.Add(streamWavesModule.ModuleName);
        }
        finally
        {
              
        }

        return wavesModuleNames;
    }

    public ArrayList GetStreamWavesModuleFiles(int index) => _mStreamWavesModules.Count >= index
        ? ((ModuleFileEntry)_mStreamWavesModules[index]).ModuleFiles
        : null;

    public ArrayList GetStreamWavesModuleFiles(string ModuleName) =>
        ((ModuleFileEntry)_mStreamWavesModules[GetStreamWavesModuleIndex(ModuleName)]).ModuleFiles;

    public int RemoveStreamWavesModuleFile(string ModuleName, string FilePath)
    {
        var num = checked(_mStreamWavesModules.Count - 1);
        var index1 = 0;
        while (index1 <= num)
        {
            if (StringType.StrCmp(((ModuleFileEntry)_mStreamWavesModules[index1]).ModuleName, ModuleName, false) ==
                0)
            {
                var index2 = ((ModuleFileEntry)_mStreamWavesModules[index1]).ModuleFiles.IndexOf(FilePath);
                if (index2 != -1)
                {
                    ((ModuleFileEntry)_mStreamWavesModules[index1]).ModuleFiles.RemoveAt(index2);
                    return 0;
                }
            }

            checked
            {
                ++index1;
            }
        }

        return -1;
    }

    public void RemoveAllStreamWavesFiles() => _mStreamWavesFiles.Clear();

    public int RemoveStreamWavesFile(string FilePath)
    {
        var index = _mStreamWavesFiles.IndexOf(FilePath);
        if (index == -1)
            return -1;
        _mStreamWavesFiles.RemoveAt(index);
        return 0;
    }

    public int AddStreamWavesFile(string Name) => _mStreamWavesFiles.Add(Name);
}