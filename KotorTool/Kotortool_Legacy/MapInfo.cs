﻿// Decompiled with JetBrains decompiler
// Type: kotor_tool.MapInfo
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;

namespace Kotortool_Legacy;

[Serializable]
public sealed class MapInfo
{
    public ArrayList MapList;
    public string Version;

    [Serializable]
    public class Map
    {
        public bool L;
        public bool S;
        public bool AltS;
        public string Name;
        public string MapName;
        public string ModuleName;
        public string MapAssembler;
        public string MapCalibrator;
        public Decimal LXMul;
        public Decimal LYMul;
        public Decimal SXMul;
        public Decimal SYMul;
        public int LXOff;
        public int LYOff;
        public int SXOff;
        public int SYOff;
        public Decimal AltSXMul;
        public Decimal AltSYMul;
        public int AltSXOff;
        public int AltSYOff;
    }
}