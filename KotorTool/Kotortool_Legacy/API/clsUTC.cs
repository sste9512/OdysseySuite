// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsUTC
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class clsUTC : ClsGff
{
  public clsUTC(int KotorVerIndex)
    : base(KotorVerIndex)
  {
    KotorVersionIndex = KotorVerIndex;
  }

  public clsUTC(FileStream fs, int KotorVerIndex)
    : base(fs, KotorVerIndex)
  {
  }

  public clsUTC(byte[] bytes, int KotorVerIndex)
    : base(bytes, KotorVerIndex)
  {
  }

  public void CreateEmptyShell()
  {
    GStructArr = Array.CreateInstance(typeof (object), 40);
    LateBinding.LateIndexSet(GStructArr, new object[2]
    {
      0,
      new GffStruct()
    }, null);
    StructArray(0).type = -1;
    StructArray(0).fieldCount = 69;
    StructArray(0).fields = (GFF_Field[]) Array.CreateInstance(typeof (object), 69);
    StructArray(0).fields[0] = new GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", null);
    StructArray(0).fields[1] = new GFF_Field(GFFField.GFF_byte, "Race", null);
    StructArray(0).fields[2] = new GFF_Field(GFFField.GFF_byte, "SubraceIndex", null);
    StructArray(0).fields[3] = new GFF_Field(GFFField.GFF_CExoLocString, "FirstName", null);
    StructArray(0).fields[4] = new GFF_Field(GFFField.GFF_CExoLocString, "LastName", null);
    StructArray(0).fields[5] = new GFF_Field(GFFField.GFF_word, "Appearance_Type", null);
    StructArray(0).fields[6] = new GFF_Field(GFFField.GFF_byte, "Gender", null);
    StructArray(0).fields[7] = new GFF_Field(GFFField.GFF_int, "Phenotype", null);
    StructArray(0).fields[8] = new GFF_Field(GFFField.GFF_word, "PortraitId", null);
    StructArray(0).fields[9] = new GFF_Field(GFFField.GFF_CExoLocString, "Description", null);
    StructArray(0).fields[10] = new GFF_Field(GFFField.GFF_CExoString, "Tag", null);
    StructArray(0).fields[11] = new GFF_Field(GFFField.GFF_CResRef, "Conversation", null);
    StructArray(0).fields[12] = new GFF_Field(GFFField.GFF_byte, "IsPC", null);
    StructArray(0).fields[13] = new GFF_Field(GFFField.GFF_word, "FactionID", null);
    StructArray(0).fields[14] = new GFF_Field(GFFField.GFF_byte, "Disarmable", null);
    StructArray(0).fields[15] = new GFF_Field(GFFField.GFF_CExoString, "Subrace", null);
    StructArray(0).fields[16] = new GFF_Field(GFFField.GFF_CExoString, "Deity", null);
    StructArray(0).fields[17] = new GFF_Field(GFFField.GFF_word, "SoundSetFile", null);
    StructArray(0).fields[18] = new GFF_Field(GFFField.GFF_byte, "Plot", null);
    StructArray(0).fields[19] = new GFF_Field(GFFField.GFF_byte, "Interruptable", null);
    StructArray(0).fields[20] = new GFF_Field(GFFField.GFF_byte, "NoPermDeath", null);
    StructArray(0).fields[21] = new GFF_Field(GFFField.GFF_byte, "NotReorienting", null);
    StructArray(0).fields[22] = new GFF_Field(GFFField.GFF_byte, "BodyBag", null);
    StructArray(0).fields[23] = new GFF_Field(GFFField.GFF_byte, "BodyVariation", null);
    StructArray(0).fields[24] = new GFF_Field(GFFField.GFF_byte, "TextureVar", null);
    StructArray(0).fields[25] = new GFF_Field(GFFField.GFF_byte, "Min1HP", null);
    StructArray(0).fields[26] = new GFF_Field(GFFField.GFF_byte, "PartyInteract", null);
    StructArray(0).fields[27] = new GFF_Field(GFFField.GFF_byte, "Str", null);
    StructArray(0).fields[28] = new GFF_Field(GFFField.GFF_byte, "Dex", null);
    StructArray(0).fields[29] = new GFF_Field(GFFField.GFF_byte, "Con", null);
    StructArray(0).fields[30] = new GFF_Field(GFFField.GFF_byte, "Int", null);
    StructArray(0).fields[31] = new GFF_Field(GFFField.GFF_byte, "Wis", null);
    StructArray(0).fields[32] = new GFF_Field(GFFField.GFF_byte, "Cha", null);
    StructArray(0).fields[33] = new GFF_Field(GFFField.GFF_int, "WalkRate", null);
    StructArray(0).fields[34] = new GFF_Field(GFFField.GFF_byte, "NaturalAC", null);
    StructArray(0).fields[35] = new GFF_Field(GFFField.GFF_short, "HitPoints", null);
    StructArray(0).fields[36] = new GFF_Field(GFFField.GFF_short, "CurrentHitPoints", null);
    StructArray(0).fields[37] = new GFF_Field(GFFField.GFF_short, "MaxHitPoints", null);
    StructArray(0).fields[38] = new GFF_Field(GFFField.GFF_short, "ForcePoints", null);
    StructArray(0).fields[39] = new GFF_Field(GFFField.GFF_short, "CurrentForce", null);
    StructArray(0).fields[40] = new GFF_Field(GFFField.GFF_short, "refbonus", null);
    StructArray(0).fields[41] = new GFF_Field(GFFField.GFF_short, "willbonus", null);
    StructArray(0).fields[42] = new GFF_Field(GFFField.GFF_short, "fortbonus", null);
    StructArray(0).fields[43] = new GFF_Field(GFFField.GFF_byte, "GoodEvil", null);
    StructArray(0).fields[44] = new GFF_Field(GFFField.GFF_byte, "LawfulChaotic", null);
    StructArray(0).fields[45] = new GFF_Field(GFFField.GFF_float, "ChallengeRating", null);
    StructArray(0).fields[46] = new GFF_Field(GFFField.GFF_byte, "PerceptionRange", null);
    StructArray(0).fields[47] = new GFF_Field(GFFField.GFF_CResRef, "ScriptHeartbeat", null);
    StructArray(0).fields[48] = new GFF_Field(GFFField.GFF_CResRef, "ScriptOnNotice", null);
    StructArray(0).fields[49] = new GFF_Field(GFFField.GFF_CResRef, "ScriptSpellAt", null);
    StructArray(0).fields[50] = new GFF_Field(GFFField.GFF_CResRef, "ScriptAttacked", null);
    StructArray(0).fields[51] = new GFF_Field(GFFField.GFF_CResRef, "ScriptDamaged", null);
    StructArray(0).fields[52] = new GFF_Field(GFFField.GFF_CResRef, "ScriptDisturbed", null);
    StructArray(0).fields[53] = new GFF_Field(GFFField.GFF_CResRef, "ScriptEndRound", null);
    StructArray(0).fields[54] = new GFF_Field(GFFField.GFF_CResRef, "ScriptEndDialogu", null);
    StructArray(0).fields[55] = new GFF_Field(GFFField.GFF_CResRef, "ScriptDialogue", null);
    StructArray(0).fields[56] = new GFF_Field(GFFField.GFF_CResRef, "ScriptSpawn", null);
    StructArray(0).fields[57] = new GFF_Field(GFFField.GFF_CResRef, "ScriptRested", null);
    StructArray(0).fields[58] = new GFF_Field(GFFField.GFF_CResRef, "ScriptDeath", null);
    StructArray(0).fields[59] = new GFF_Field(GFFField.GFF_CResRef, "ScriptUserDefine", null);
    StructArray(0).fields[60] = new GFF_Field(GFFField.GFF_CResRef, "ScriptOnBlocked", null);
    StructArray(0).fields[61] = new GFF_Field(GFFField.GFF_List, "SkillList", null);
    StructArray(0).fields[62] = new GFF_Field(GFFField.GFF_List, "FeatList", null);
    StructArray(0).fields[63] = new GFF_Field(GFFField.GFF_List, "TemplateList", null);
    StructArray(0).fields[64] = new GFF_Field(GFFField.GFF_List, "SpecAbilityList", null);
    StructArray(0).fields[65] = new GFF_Field(GFFField.GFF_List, "ClassList", null);
    StructArray(0).fields[66] = new GFF_Field(GFFField.GFF_List, "Equip_ItemList", null);
    StructArray(0).fields[67] = new GFF_Field(GFFField.GFF_byte, "PaletteID", null);
    StructArray(0).fields[68] = new GFF_Field(GFFField.GFF_CExoString, "Comment", null);
  }

  public GffStruct StructArray(object n) => ((GffStruct[]) GStructArr)[IntegerType.FromObject(n)];

  public GffStruct[] StructArray() => (GffStruct[]) GStructArr;
}