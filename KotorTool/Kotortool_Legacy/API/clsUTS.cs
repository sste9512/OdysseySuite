﻿// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsUTS
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy.API;

public class clsUTS : ClsGff
{
  public clsUTS(int KotorVerIndex)
    : base(KotorVerIndex)
  {
    KotorVersionIndex = KotorVerIndex;
  }

  public clsUTS(FileStream fs, int KotorVerIndex)
    : base(fs, KotorVerIndex)
  {
  }

  public clsUTS(byte[] bytes, int KotorVerIndex)
    : base(bytes, KotorVerIndex)
  {
  }
}