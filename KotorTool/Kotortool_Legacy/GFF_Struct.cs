// Decompiled with JetBrains decompiler
// Type: kotor_tool.GFF_Struct
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class GffStruct
{
    public int type;
    public int fieldCount;
    public int DataOrDataOffset;
    public GFF_Field[] fields;

    public GffStruct()
    {
        }

    public GffStruct(int InitialFieldCount)
    {
            fieldCount = InitialFieldCount;
            fields = new GFF_Field[checked(InitialFieldCount - 1 + 1)];
        }

    public GffStruct(int InitialFieldCount, int StructType)
        : this(InitialFieldCount)
    {
            type = StructType;
        }
}