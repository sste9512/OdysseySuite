// Decompiled with JetBrains decompiler
// Type: kotor_tool.ModuleEditorProjectOptions
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

[Serializable]
public class ModuleEditorProjectOptions
{
    private string _moduleEditorModOutputPath;
    private bool _useHiResMap;
    private bool _filterShowCreatures;
    private bool _filterShowDoors;
    private bool _filterShowPlaceables;
    private bool _filterShowEncounters;
    private bool _filterShowTriggers;
    private bool _filterShowMerchants;
    private bool _filterShowSounds;
    private bool _filterShowWaypoints;
    private string _mapSize;
    private bool _showItemLabels;
    private bool _showTagsOnModulePalette;
    private int _LastScrollPosX;
    private int _LastScrollPosY;

    public ModuleEditorProjectOptions()
    {
            _moduleEditorModOutputPath = "";
            _useHiResMap = true;
            _filterShowCreatures = true;
            _filterShowDoors = true;
            _filterShowPlaceables = true;
            _filterShowEncounters = true;
            _filterShowTriggers = true;
            _filterShowMerchants = true;
            _filterShowSounds = true;
            _filterShowWaypoints = true;
            _mapSize = "small";
            _showItemLabels = true;
            _showTagsOnModulePalette = false;
            _LastScrollPosX = 0;
            _LastScrollPosY = 0;
        }

    public string ModuleEditorModOutputPath
    {
        get => _moduleEditorModOutputPath;
        set => _moduleEditorModOutputPath = value;
    }

    public bool UseHiResMap
    {
        get => _useHiResMap;
        set => _useHiResMap = value;
    }

    public bool FilterShowCreatures
    {
        get => _filterShowCreatures;
        set => _filterShowCreatures = value;
    }

    public bool FilterShowDoors
    {
        get => _filterShowDoors;
        set => _filterShowDoors = value;
    }

    public bool FilterShowPlaceables
    {
        get => _filterShowPlaceables;
        set => _filterShowPlaceables = value;
    }

    public bool FilterShowEncounters
    {
        get => _filterShowEncounters;
        set => _filterShowEncounters = value;
    }

    public bool FilterShowTriggers
    {
        get => _filterShowTriggers;
        set => _filterShowTriggers = value;
    }

    public bool FilterShowMerchants
    {
        get => _filterShowMerchants;
        set => _filterShowMerchants = value;
    }

    public bool FilterShowSounds
    {
        get => _filterShowSounds;
        set => _filterShowSounds = value;
    }

    public bool FilterShowWaypoints
    {
        get => _filterShowWaypoints;
        set => _filterShowWaypoints = value;
    }

    public string MapSize
    {
        get => _mapSize;
        set => _mapSize = value;
    }

    public bool ShowItemLabels
    {
        get => _showItemLabels;
        set => _showItemLabels = value;
    }

    public bool ShowTagsOnModulePalette
    {
        get => _showTagsOnModulePalette;
        set => _showTagsOnModulePalette = value;
    }

    public int LastScrollPosX
    {
        get => _LastScrollPosX;
        set => _LastScrollPosX = value;
    }

    public int LastScrollPosY
    {
        get => _LastScrollPosY;
        set => _LastScrollPosY = value;
    }
}