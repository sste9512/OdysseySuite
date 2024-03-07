// Decompiled with JetBrains decompiler
// Type: kotor_tool.GFF_Field
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Runtime.CompilerServices;

namespace Kotortool_Legacy;

public class GFF_Field
{
  public GFFField Type;
  public int labelIndex;
  public string label;
  public object value;
  public int DataOffset;

  public GFF_Field()
  {
    }

  public GFF_Field(GFFField FieldType, string FieldLabel, object FieldValue)
  {
      Type = FieldType;
      label = FieldLabel;
      value = RuntimeHelpers.GetObjectValue(FieldValue);
    }
}