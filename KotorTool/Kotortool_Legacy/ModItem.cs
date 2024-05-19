// Decompiled with JetBrains decompiler
// Type: kotor_tool.ModItem
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public sealed class ModItem : IComparable
{
    private int _screenX;
    private int _screenY;
    private float _x;
    private float _y;
    private float _z;
    private string _ResRef;
    private string _path;
    private string _localTag;
    private int _ItemType;
    private string _XPosAccessor;
    private string _YPosAccessor;
    private string _ZPosAccessor;
    private ArrayList _GeometryList;
    private ArrayList _spawnPointList;
    private ModItem _Parent;
    public const int ItemTypeCreature = 2027;
    public const int ItemTypePlaceable = 2044;
    public const int ItemTypeDoor = 2042;
    public const int ItemTypeSound = 2035;
    public const int ItemTypeWaypoint = 2058;
    public const int ItemTypeCamera = 6;
    public const int ItemTypeStore = 2051;
    public const int ItemTypeTrigger = 2032;
    public const int ItemTypeEncounter = 2040;
    public const int ItemTypeEncounterSpawnPoint = 12040;
    public const int ItemTypeItem = 2025;
    public const int ItemTypeStartPoint = 5000;

    public ModItem(int ScreenX, int ScreenY, float X, float Y, string ResRef, string path)
    {
        _screenX = ScreenX;
        _screenY = ScreenY;
        _x = X;
        _y = Y;
        _path = path;
        _ResRef = ResRef;
    }

    public ModItem(
        int ScreenX,
        int ScreenY,
        float X,
        float Y,
        string ResRef,
        string path,
        ModItem parent)
        : this(ScreenX, ScreenY, X, Y, ResRef, path)
    {
        _Parent = parent;
    }

    public ModItem(
        int ScreenX,
        int ScreenY,
        float X,
        float Y,
        string ResRef,
        string path,
        bool dummy,
        string Tag)
        : this(ScreenX, ScreenY, X, Y, ResRef, path)
    {
        _localTag = Tag;
    }

    public int ScreenX
    {
        get => _screenX;
        set => _screenX = value;
    }

    public int ScreenY
    {
        get => _screenY;
        set => _screenY = value;
    }

    public float X
    {
        get => _x;
        set => _x = value;
    }

    public float Y
    {
        get => _y;
        set => _y = value;
    }

    public float Z
    {
        get => _z;
        set => _z = value;
    }

    public string Path
    {
        get => _path;
        set => _path = value;
    }

    public string ResRef
    {
        get => _ResRef;
        set => _ResRef = value;
    }

    public int ItemType
    {
        get => _ItemType;
        set => _ItemType = value;
    }

    public string XPosAccessor
    {
        get => _XPosAccessor;
        set => _XPosAccessor = value;
    }

    public string YPosAccessor
    {
        get => _YPosAccessor;
        set => _YPosAccessor = value;
    }

    public string ZPosAccessor
    {
        get => _ZPosAccessor;
        set => _ZPosAccessor = value;
    }

    public string XPosPath => _path + "." + _XPosAccessor;

    public string YPosPath => _path + "." + _YPosAccessor;

    public string ZPosPath => _path + "." + _ZPosAccessor;

    public ArrayList GeometryList
    {
        get => _GeometryList;
        set => _GeometryList = value;
    }

    public ArrayList SpawnPointList
    {
        get => _spawnPointList;
        set => _spawnPointList = value;
    }

    public string FileExtension
    {
        get
        {
            switch (_ItemType)
            {
                case 2025:
                    return ".uti";
                case 2027:
                    return ".utc";
                case 2032:
                    return ".utt";
                case 2035:
                    return ".uts";
                case 2040:
                    return ".ute";
                case 2042:
                    return ".utd";
                case 2044:
                    return ".utp";
                case 2051:
                    return ".utm";
                case 2058:
                    return ".utw";
                default:
                    string fileExtension = string.Empty;
                    return fileExtension;
            }
        }
    }

    public string FileName => _ResRef + FileExtension;

    public ModItem Parent
    {
        get => _Parent;
        set => _Parent = value;
    }

    public string Tag
    {
        get => _localTag;
        set => _localTag = value;
    }

    public bool IsEqual(ModItem mi) => mi != null && mi.ItemType == ItemType && mi.X == (double)X &&
                                       mi.Y == (double)Y &&
                                       StringType.StrCmp(mi.ResRef, ResRef, false) == 0;

    public int CompareTo(object obj) => string.Compare(ResRef, ((ModItem)obj).ResRef);
}