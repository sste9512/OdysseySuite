// Decompiled with JetBrains decompiler
// Type: kotor_tool.GFFType16
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class GFFType16
{
    public float f1;
    public float f2;
    public float f3;
    public float f4;

    public GFFType16()
    {
        }

    public GFFType16(float field1, float field2, float field3, float field4)
    {
            f1 = field1;
            f2 = field2;
            f3 = field3;
            f4 = field4;
        }

    public float W
    {
        get => f1;
        set => f1 = value;
    }

    public float X
    {
        get => f2;
        set => f2 = value;
    }

    public float Y
    {
        get => f3;
        set => f3 = value;
    }

    public float Z
    {
        get => f4;
        set => f4 = value;
    }
}