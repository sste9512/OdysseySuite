using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class ClsGff
{
    private int _gStructOffset;
    private int _gStructCount;
    private int _gFieldOffset;
    private int _gFieldCount;
    private int _gLabelOffset;
    private int _gLabelCount;
    private int _gFieldDataOffset;
    private int _gFieldDataCount;
    private int _gFieldIndicesOffset;
    private int _gFieldIndicesCount;
    private int _gListIndicesOffset;
    private int _gListIndicesCount;
    private MemoryStream _gMs;
    private BinaryReader _gRdr;
    public Array GStructArr;
    public ArrayList GGffListArr;
    private int _gTabLevel;
    private StringBuilder _gStringbuilder;
    private bool _gBRtfMode;
    private string[] _nodeSearchPath;
    private int _nodeSearchLevel;
    private GffStruct _rootGffStruct;
    private clsDialogTlk _dialogTlk;
    protected int KotorVersionIndex;
    private int _gFieldCountforCoding;
    private int _maxOffset;
    private int _offsetCnt;
    private const int ItemSizeofGffStruct = 12;
    private const int ItemSizeofGffField = 12;

    public bool RtfMode
    {
        get => _gBRtfMode;
        set => _gBRtfMode = value;
    }

    public override string ToString() => _gStringbuilder.ToString();

    public ClsGff(int KotorVerIndex)
    {
        GGffListArr = new ArrayList();
        _gTabLevel = 0;
        _gStringbuilder = new StringBuilder();
        _gBRtfMode = true;
        _nodeSearchLevel = 0;
        _rootGffStruct = new GffStruct();
        _gFieldCountforCoding = 0;
        _maxOffset = 0;
        _offsetCnt = 0;
        KotorVersionIndex = KotorVerIndex;
        if (KotorVerIndex > -1)
            _dialogTlk = new clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVerIndex) + "\\dialog.tlk");
        CreateRootStruct();
    }

    public ClsGff(byte[] bytes, int KotorVerIndex, bool rtfMode = true)
    {
        GGffListArr = new ArrayList();
        _gTabLevel = 0;
        _gStringbuilder = new StringBuilder();
        _gBRtfMode = true;
        _nodeSearchLevel = 0;
        _rootGffStruct = new GffStruct();
        _gFieldCountforCoding = 0;
        _maxOffset = 0;
        _offsetCnt = 0;
        KotorVersionIndex = KotorVerIndex;
        if (KotorVerIndex > -1)
            _dialogTlk = new clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVerIndex) + "\\dialog.tlk");
        _gBRtfMode = rtfMode;
        Parse(bytes);
    }

    public ClsGff(FileStream fs, int KotorVerIndex, bool rtfMode = true)
    {
        GGffListArr = new ArrayList();
        _gTabLevel = 0;
        _gStringbuilder = new StringBuilder();
        _gBRtfMode = true;
        _nodeSearchLevel = 0;
        _rootGffStruct = new GffStruct();
        _gFieldCountforCoding = 0;
        _maxOffset = 0;
        _offsetCnt = 0;
        KotorVersionIndex = KotorVerIndex;
        byte[] numArray = new byte[checked((int)(fs.Length - 1L) + 1)];
        _gRdr = new BinaryReader(fs, Encoding.ASCII);
        byte[] bytes = _gRdr.ReadBytes(checked((int)fs.Length));
        _gRdr.Close();
        if (KotorVerIndex > -1)
            _dialogTlk = new clsDialogTlk(UserSettings.GetSettings().KotorLocation(KotorVerIndex) + "\\dialog.tlk");
        _gBRtfMode = rtfMode;
        Parse(bytes);
    }

    public ClsGff(string filepath, int KotorVerIndex, bool rtfMode = true)
        : this(new FileStream(filepath, FileMode.Open, FileAccess.Read), KotorVerIndex, rtfMode)
    {
    }

    public int KotorVersIndex() =>
        VerifyNodeExists("KTGameVerIndex") ? IntegerType.FromObject(GetNodeValue("KTGameVerIndex")) : -1;

    public string GetFieldTypeStr(int type)
    {
        return type switch
        {
            0 => "byte",
            1 => "char",
            2 => "word",
            3 => "short",
            4 => "dword",
            5 => "int",
            6 => "dword64",
            7 => "int64",
            8 => "float",
            9 => "double",
            10 => "CExoString",
            11 => "CResRef",
            12 => "CExoLocString",
            13 => "void",
            14 => "Struct",
            15 => "List",
            16 => "GFF Type 16",
            17 => "GFF Type 17",
            _ => "Unknown type: " + type.ToString()
        };
    }

    public void Parse(FileStream fs)
    {
        byte[] numArray = new byte[checked((int)(fs.Length - 1L) + 1)];
        _gRdr = new BinaryReader(fs, Encoding.ASCII);
        byte[] bytes = _gRdr.ReadBytes(checked((int)fs.Length));
        _gRdr.Close();
        Parse(bytes);
    }

    public void Parse(byte[] bytes)
    {
        GFFStructEntry structEntry = new GFFStructEntry();
        _gMs = new MemoryStream(bytes);
        _gRdr = new BinaryReader(_gMs, Encoding.ASCII);
        _gMs.Seek(8L, SeekOrigin.Begin);
        _gStructOffset = _gRdr.ReadInt32();
        _gStructCount = _gRdr.ReadInt32();
        GStructArr = Array.CreateInstance(typeof(object), _gStructCount);
        _gFieldOffset = _gRdr.ReadInt32();
        _gFieldCount = _gRdr.ReadInt32();
        _gLabelOffset = _gRdr.ReadInt32();
        _gLabelCount = _gRdr.ReadInt32();
        _gFieldDataOffset = _gRdr.ReadInt32();
        _gFieldDataCount = _gRdr.ReadInt32();
        _gFieldIndicesOffset = _gRdr.ReadInt32();
        _gFieldIndicesCount = _gRdr.ReadInt32();
        _gListIndicesOffset = _gRdr.ReadInt32();
        _gListIndicesCount = _gRdr.ReadInt32();
        _gMs.Seek(_gStructOffset, SeekOrigin.Begin);
        if (_gBRtfMode)
        {
            PrintMsg(
                "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fmodern\\fprq1\\fcharset0 Lucida Console;}{\\f1\\fnil\\fcharset0 Lucida Console;}}",
                false);
            PrintMsg(
                "{\\colortbl ;\\red0\\green0\\blue255;\\red0\\green120\\blue0;\\red255\\green0\\blue0;\\red255\\green0\\blue255;}",
                false);
            PrintMsg("\\viewkind4\\uc1\\pard\\f0\\fs16", false);
        }

        structEntry.Type = (GFFField)_gRdr.ReadInt32();
        structEntry.DataOrDataOffset = _gRdr.ReadInt32();
        structEntry.FieldCount = _gRdr.ReadInt32();
        _rootGffStruct = GffReadStruct(ref structEntry);
        LateBinding.LateIndexSet(GStructArr, new object[2]
        {
            0,
            _rootGffStruct
        }, null);
        SortStructNames();
        if (!_gBRtfMode)
            return;
        PrintMsg("\\f1\\fs17\\par", false);
    }

    public ArrayList SortStructNames()
    {
        ArrayList arrayList = new ArrayList();
        int num = checked(((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
        {
            0
        }, null)).fields.Length - 1);
        int index = 0;
        while (index <= num)
        {
            arrayList.Add(((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
            {
                0
            }, null)).fields[index].label);
            checked
            {
                ++index;
            }
        }

        arrayList.Sort();
        return arrayList;
    }

    public GffStruct GffReadStruct(ref GFFStructEntry structEntry)
    {
        GFFFieldEntry fieldEntry = new GFFFieldEntry();
        GffStruct gffStruct = new GffStruct();
        gffStruct.fields = new GFF_Field[checked(structEntry.FieldCount - 1 + 1)];
        gffStruct.fieldCount = structEntry.FieldCount;
        gffStruct.type = (int)structEntry.Type;
        gffStruct.DataOrDataOffset = structEntry.DataOrDataOffset;
        if (_gBRtfMode)
            PrintMsg(
                "\\cf1 Struct\\cf0 - \\cf2 Type:\\cf0 " + StringType.FromInteger((int)structEntry.Type) +
                " \\cf2  Field count:\\cf0  " + StringType.FromInteger(structEntry.FieldCount) + "\n" + "\\par", true);
        else
            PrintMsg(
                "Struct - Type: " + StringType.FromInteger((int)structEntry.Type) + "  Field count:  " +
                StringType.FromInteger(structEntry.FieldCount) + "\n", true);
        checked
        {
            ++_gTabLevel;
        }

        if (structEntry.FieldCount == 1)
        {
            _gMs.Seek(checked(_gFieldOffset + structEntry.DataOrDataOffset * 12), SeekOrigin.Begin);
            fieldEntry.Type = (GFFField)_gRdr.ReadInt32();
            fieldEntry.LabelIndex = _gRdr.ReadInt32();
            gffStruct.fields[0] = (GFF_Field)GffReadField(fieldEntry);
        }
        else
        {
            int num = checked(structEntry.FieldCount - 1);
            int index = 0;
            while (index <= num)
            {
                _gMs.Seek(checked(_gFieldIndicesOffset + structEntry.DataOrDataOffset + index * 4), SeekOrigin.Begin);
                _gMs.Seek(checked(_gFieldOffset + _gRdr.ReadInt32() * 12), SeekOrigin.Begin);
                fieldEntry.Type = (GFFField)_gRdr.ReadInt32();
                fieldEntry.LabelIndex = _gRdr.ReadInt32();
                gffStruct.fields[index] = (GFF_Field)GffReadField(fieldEntry);
                checked
                {
                    ++index;
                }
            }
        }

        checked
        {
            --_gTabLevel;
        }

        if (_gBRtfMode)
            PrintMsg("\\cf1 End of struct\\cf0\n\\par", true);
        else
            PrintMsg(" End of struct\n", true);
        return gffStruct;
    }

    public object GffReadField(GFFFieldEntry fieldEntry)
    {
        StringBuilder stringBuilder = new StringBuilder();
        GFF_Field field = new GFF_Field();
        long position = _gRdr.BaseStream.Position;
        _gMs.Seek(checked(_gLabelOffset + fieldEntry.LabelIndex * 16), SeekOrigin.Begin);
        stringBuilder.Length = 0;
        stringBuilder.Append(_gRdr.ReadChars(16));
        int index1 = 0;
        while (Strings.Asc(stringBuilder[index1]) != 0)
        {
            checked
            {
                ++index1;
            }

            if (index1 > 15)
                break;
        }

        stringBuilder.Length = index1;
        field.label = stringBuilder.ToString();
        if (_gBRtfMode)
            PrintMsg("\\cf2 Label:\\cf0  " + field.label.PadRight(16), true);
        else
            PrintMsg("Label:  " + field.label.PadRight(16), true);
        _gMs.Seek(position, SeekOrigin.Begin);
        if (fieldEntry.Type == GFFField.GFF_dword64 || fieldEntry.Type == GFFField.GFF_int64 ||
            fieldEntry.Type >= GFFField.GFF_double)
        {
            fieldEntry.DataOrDataOffset = _gRdr.ReadInt32();
            _gMs.Seek(LongType.FromObject(ObjectType.AddObj(_gFieldDataOffset, fieldEntry.DataOrDataOffset)),
                SeekOrigin.Begin);
        }

        field.Type = fieldEntry.Type;
        switch (fieldEntry.Type)
        {
            case GFFField.GFF_byte:
                field.value = _gRdr.ReadByte();
                break;
            case GFFField.GFF_char:
                field.value = _gRdr.ReadChar();
                break;
            case GFFField.GFF_word:
                field.value = _gRdr.ReadUInt16();
                break;
            case GFFField.GFF_short:
                field.value = _gRdr.ReadInt16();
                break;
            case GFFField.GFF_dword:
                field.value = _gRdr.ReadUInt32();
                break;
            case GFFField.GFF_int:
                field.value = _gRdr.ReadInt32();
                break;
            case GFFField.GFF_dword64:
                field.value = _gRdr.ReadUInt64();
                break;
            case GFFField.GFF_int64:
                field.value = _gRdr.ReadInt64();
                break;
            case GFFField.GFF_float:
                field.value = _gRdr.ReadSingle();
                break;
            case GFFField.GFF_double:
                field.value = _gRdr.ReadDouble();
                break;
            case GFFField.GFF_CExoString:
                int count = _gRdr.ReadInt32();
                byte[] numArray1 = new byte[checked(count - 1 + 1)];
                Encoding encoding1 = Encoding.GetEncoding(1252);
                byte[] bytes1 = _gRdr.ReadBytes(count);
                field.value = encoding1.GetString(bytes1);
                break;
            case GFFField.GFF_CResRef:
                field.value = _gRdr.ReadString();
                break;
            case GFFField.GFF_CExoLocString:
                GFFExoLocString gffExoLocString = new GFFExoLocString()
                {
                    size = _gRdr.ReadInt32(),
                    StringRef = _gRdr.ReadInt32(),
                    StringCount = _gRdr.ReadInt32()
                };
                gffExoLocString.subStringArr =
                    (object[])Array.CreateInstance(typeof(object), gffExoLocString.StringCount);
                checked
                {
                    ++_gTabLevel;
                }

                if (_gBRtfMode)
                {
                    PrintMsg("\\par", false);
                    PrintMsg(
                        "\\cf4CExoLocString\\cf0 - \\cf2 Substring count:\\cf0  " +
                        StringType.FromInteger(gffExoLocString.StringCount) + "\n" + "\\par", true);
                }
                else
                {
                    PrintMsg("\n", false);
                    PrintMsg(
                        "CExoLocString - Substring count:" + StringType.FromInteger(gffExoLocString.StringCount) + "\n",
                        true);
                }

                checked
                {
                    ++_gTabLevel;
                }

                if (gffExoLocString.StringCount > 0)
                {
                    int num = checked(gffExoLocString.StringCount - 1);
                    int index2 = 0;
                    while (index2 <= num)
                    {
                        GFFExoLocSubString gffExoLocSubString = new GFFExoLocSubString();
                        gffExoLocSubString.StringID = _gRdr.ReadInt32();
                        gffExoLocSubString.StringLength = _gRdr.ReadInt32();
                        byte[] numArray2 = new byte[checked(gffExoLocSubString.StringLength - 1 + 1)];
                        Encoding encoding2 = Encoding.GetEncoding(1252);
                        byte[] bytes2 = _gRdr.ReadBytes(gffExoLocSubString.StringLength);
                        gffExoLocSubString.value = encoding2.GetString(bytes2);
                        gffExoLocString.subStringArr[index2] = gffExoLocSubString;
                        if (_gBRtfMode)
                            PrintMsg(
                                "\\cf3Substring:\\cf0  " + StringType.FromInteger(index2) + "  \\cf2 ID:\\cf0  " +
                                StringType.FromInteger(gffExoLocSubString.StringID) + " \\cf2 Value:\\cf0  " +
                                gffExoLocSubString.value + "\n" + "\\par", true);
                        else
                            PrintMsg(
                                "Substring: " + StringType.FromInteger(index2) + " ID: " +
                                StringType.FromInteger(gffExoLocSubString.StringID) + "  Value: " +
                                gffExoLocSubString.value, true);
                        checked
                        {
                            ++index2;
                        }
                    }
                }

                checked
                {
                    --_gTabLevel;
                }

                if (_gBRtfMode)
                    PrintMsg("\\cf4End of CExoLocString\\cf0 - ", true);
                else
                    PrintMsg(" End of CExoLocString - ", true);
                checked
                {
                    --_gTabLevel;
                }

                field.value = gffExoLocString;
                break;
            case GFFField.GFF_Void:
                GffVoid gffVoid = new GffVoid()
                {
                    Size = _gRdr.ReadInt32()
                };
                gffVoid.Bytes = _gRdr.ReadBytes(gffVoid.Size);
                field.value = gffVoid;
                break;
            case GFFField.GFF_Struct:
                if (LateBinding.LateIndexGet(GStructArr, new object[1]
                    {
                        RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset)
                    }, null) == null)
                {
                    _gMs.Seek(
                        LongType.FromObject(ObjectType.AddObj(_gStructOffset,
                            ObjectType.MulObj(fieldEntry.DataOrDataOffset, 12))), SeekOrigin.Begin);
                    var gffStructEntry = new GFFStructEntry()
                    {
                        Type = (GFFField)_gRdr.ReadInt32(),
                        DataOrDataOffset = _gRdr.ReadInt32(),
                        FieldCount = _gRdr.ReadInt32()
                    };
                    LateBinding.LateIndexSet(GStructArr, new object[2]
                    {
                        RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset),
                        GffReadStruct(ref gffStructEntry)
                    }, null);
                }

                field.value = RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset);
                break;
            case GFFField.GFF_List:
                _gMs.Seek(LongType.FromObject(ObjectType.AddObj(_gListIndicesOffset, fieldEntry.DataOrDataOffset)),
                    SeekOrigin.Begin);
                GFFList gffList = new GFFList(_gRdr.ReadInt32());
                if (_gBRtfMode)
                {
                    PrintMsg("\n\\par", false);
                    PrintMsg(
                        "\\cf4List Contents\\cf0 - \\cf2 Struct Count:\\cf0  " +
                        StringType.FromInteger(gffList.structIndices.Count) + "\n" + "\\par", true);
                }
                else
                    PrintMsg(
                        "List Contents - Struct Count: " + StringType.FromInteger(gffList.structIndices.Count) + "\n",
                        true);

                checked
                {
                    ++_gTabLevel;
                }

                if (gffList.structIndices.Count > 0)
                {
                    int num1 = checked(gffList.structIndices.Count - 1);
                    int index3 = 0;
                    while (index3 <= num1)
                    {
                        gffList.structIndices[index3] = _gRdr.ReadInt32();
                        checked
                        {
                            ++index3;
                        }
                    }

                    int num2 = checked(gffList.structIndices.Count - 1);
                    int index4 = 0;
                    while (index4 <= num2)
                    {
                        if (LateBinding.LateIndexGet(GStructArr, new object[1]
                            {
                                RuntimeHelpers.GetObjectValue(gffList.structIndices[index4])
                            }, null) == null)
                        {
                            _gMs.Seek(0L, SeekOrigin.Begin);
                            _gMs.Seek(
                                LongType.FromObject(ObjectType.AddObj(_gStructOffset,
                                    ObjectType.MulObj(gffList.structIndices[index4], 12))), SeekOrigin.Begin);
                            var gffStructEntry = new GFFStructEntry()
                            {
                                Type = (GFFField)_gRdr.ReadInt32(),
                                DataOrDataOffset = _gRdr.ReadInt32(),
                                FieldCount = _gRdr.ReadInt32()
                            };
                            LateBinding.LateIndexSet(GStructArr, new object[2]
                            {
                                RuntimeHelpers.GetObjectValue(gffList.structIndices[index4]),
                                GffReadStruct(ref gffStructEntry)
                            }, null);
                        }

                        checked
                        {
                            ++index4;
                        }
                    }
                }

                checked
                {
                    --_gTabLevel;
                }

                if (_gBRtfMode)
                    PrintMsg("\\cf4End of List Contents\\cf0 - ", true);
                else
                    PrintMsg("End of List Contents - ", true);
                field.value = gffList;
                GGffListArr.Add(gffList);
                break;
            case GFFField.GFF_Type16:
                GFFType16 gffType16 = new GFFType16();
                gffType16.f1 = _gRdr.ReadSingle();
                gffType16.f2 = _gRdr.ReadSingle();
                gffType16.f3 = _gRdr.ReadSingle();
                gffType16.f4 = _gRdr.ReadSingle();
                if (_gBRtfMode)
                    PrintMsg("\\cf4 GFF Type16\\cf0 - \n\\par", true);
                else
                    PrintMsg(" GFF Type16 - \n", true);
                checked
                {
                    ++_gTabLevel;
                }

                PrintMsg(
                    "f1: " + StringType.FromSingle(gffType16.f1) + "  f2: " + StringType.FromSingle(gffType16.f2) +
                    "  f3: " + StringType.FromSingle(gffType16.f3) + "  f4: " + StringType.FromSingle(gffType16.f4),
                    true);
                if (_gBRtfMode)
                    PrintMsg("\\par", true);
                else
                    PrintMsg("\n", true);
                checked
                {
                    --_gTabLevel;
                }

                if (_gBRtfMode)
                    PrintMsg("\\cf4 End of GFF Type16\\cf0 - ", true);
                else
                    PrintMsg(" End of GFF Type16 - ", true);
                field.value = gffType16;
                break;
            case GFFField.GFF_Type17:
                GFFType17 gffType17 = new GFFType17();
                gffType17.f1 = _gRdr.ReadSingle();
                gffType17.f2 = _gRdr.ReadSingle();
                gffType17.f3 = _gRdr.ReadSingle();
                if (_gBRtfMode)
                    PrintMsg("\\cf4 GFF Type17\\cf0 - \n\\par", true);
                else
                    PrintMsg(" GFF Type17 - \n", true);
                checked
                {
                    ++_gTabLevel;
                }

                PrintMsg(
                    "f1: " + StringType.FromSingle(gffType17.f1) + "  f2: " + StringType.FromSingle(gffType17.f2) +
                    "  f3: " + StringType.FromSingle(gffType17.f3), true);
                if (_gBRtfMode)
                    PrintMsg("\\par", true);
                else
                    PrintMsg("\n", true);
                checked
                {
                    --_gTabLevel;
                }

                if (_gBRtfMode)
                    PrintMsg("\\cf4 End of GFF Type17\\cf0 - ", true);
                else
                    PrintMsg(" End of GFF Type17 - ", true);
                field.value = gffType17;
                break;
            default:
                Console.WriteLine("Unknown Field type during read: " + StringType.FromInteger((int)fieldEntry.Type));
                break;
        }

        if (_gBRtfMode)
            PrintMsg("\\cf3Field\\cf0 - \\cf2 Type:\\cf0  " + GetFieldTypeStr((int)fieldEntry.Type).PadRight(14), true);
        else
            PrintMsg("Field -  Type:  " + GetFieldTypeStr((int)fieldEntry.Type).PadRight(14), true);
        PrintViewableFieldValue(field);
        return field;
    }

    private void PrintViewableFieldValue(GFF_Field field)
    {
        switch (field.Type)
        {
            case GFFField.GFF_byte:
            case GFFField.GFF_word:
            case GFFField.GFF_short:
            case GFFField.GFF_dword:
            case GFFField.GFF_int:
            case GFFField.GFF_dword64:
            case GFFField.GFF_int64:
            case GFFField.GFF_float:
            case GFFField.GFF_double:
            case GFFField.GFF_CExoString:
            case GFFField.GFF_CResRef:
                if (_gBRtfMode)
                    PrintMsg("\\cf2 Value:\\cf0  ", false);
                else
                    PrintMsg("Value:  ", false);
                if (field.value != null)
                {
                    if (_gBRtfMode)
                    {
                        PrintMsg(field.value.ToString() + "\n" + "\\par", false);
                        break;
                    }

                    PrintMsg(field.value.ToString() + "\n", false);
                    break;
                }

                if (_gBRtfMode)
                {
                    PrintMsg("(Nothing)\n\\par", false);
                    break;
                }

                PrintMsg("(Nothing)\n", false);
                break;
            case GFFField.GFF_char:
                char ch = CharType.FromObject(field.value);
                string str1 = null;
                string str2 = !_gBRtfMode ? str1 + "Value:  " : str1 + "\\cf2Value:\\cf0  ";
                PrintMsg(
                    (!char.IsLetterOrDigit(ch)
                        ? str2 + "chr(" + StringType.FromInteger(Strings.Asc(ch)) + ")"
                        : str2 + ch.ToString()) + "\n", false);
                if (!_gBRtfMode)
                    break;
                PrintMsg("\\par", false);
                break;
            case GFFField.GFF_CExoLocString:
                string str3 = null;
                if (((GFFExoLocString)field.value).StringRef != -1)
                    str3 = _dialogTlk == null
                        ? "No DialogTlk"
                        : _dialogTlk.GetString(((GFFExoLocString)field.value).StringRef);
                if (_gBRtfMode)
                {
                    PrintMsg("\\cf2Value:\\cf0  " + str3 + "\n" + "\\par", false);
                    break;
                }

                PrintMsg("Value:  " + str3 + "\n", false);
                break;
            case GFFField.GFF_Void:
                PrintMsg(
                    StringType.FromObject(ObjectType.StrCatObj(
                        ObjectType.StrCatObj(
                            ObjectType.StrCatObj("(Data: Size = ",
                                LateBinding.LateGet(
                                    LateBinding.LateGet(field.value, null, "bytes", new object[0], null, null), null,
                                    "length", new object[0], null, null)), ")"), '\n')), false);
                if (!_gBRtfMode)
                    break;
                PrintMsg("\\par", false);
                break;
            default:
                PrintMsg("(Complex)\n", false);
                if (!_gBRtfMode)
                    break;
                PrintMsg("\\par", false);
                break;
        }
    }

    public object FindNode(GffStruct aNode)
    {
        if (aNode.fields != null)
        {
            GFF_Field[] fields = aNode.fields;
            int index = 0;
            while (index < fields.Length)
            {
                GFF_Field node = fields[index];
                if (StringType.StrCmp(node.label, _nodeSearchPath[_nodeSearchLevel], false) == 0)
                {
                    if (_nodeSearchLevel == checked(_nodeSearchPath.Length - 1))
                        return node;
                    checked
                    {
                        ++_nodeSearchLevel;
                    }

                    if (node.Type == GFFField.GFF_Struct)
                        return FindNode((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
                        {
                            RuntimeHelpers.GetObjectValue(node.value)
                        }, null));
                    if (node.Type == GFFField.GFF_List)
                        return _nodeSearchLevel == checked(_nodeSearchPath.Length - 1)
                            ? node
                            : FindNode(FindListElement((GFFList)node.value));
                }

                checked
                {
                    ++index;
                }
            }
        }

        return null;
    }

    public GffStruct FindListElement(GFFList List)
    {
        GffStruct listElement = (GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
        {
            RuntimeHelpers.GetObjectValue(List.structIndices[IntegerType.FromString(_nodeSearchPath[_nodeSearchLevel])])
        }, null);
        checked
        {
            ++_nodeSearchLevel;
        }

        return listElement;
    }

    public object GetNodeValue(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        object objectValue = RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct));
        return objectValue == null ? objectValue : ((GFF_Field)objectValue).value;
    }

    public void SetNodeValue(string Path, object value)
    {
        if (!VerifyNodeExists(Path))
            return;
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        GFF_Field node = (GFF_Field)FindNode(_rootGffStruct);
        if (node.Type != GFFField.GFF_List)
            node.value = RuntimeHelpers.GetObjectValue(value);
        else
            ((GFFList)node.value).structIndices[
                    IntegerType.FromString(_nodeSearchPath[checked(_nodeSearchPath.Length - 1)])] =
                RuntimeHelpers.GetObjectValue(value);
    }

    public GFFList GetListNode(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        object objectValue = RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct));
        return objectValue == null ? new GFFList(0) : (GFFList)((GFF_Field)objectValue).value;
    }

    public bool VerifyNodeExists(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        return RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct)) != null;
    }

    public void AddListElement(string PathToList, GffStruct @struct)
    {
        ArrayList structIndices = GetListNode(PathToList).structIndices;
        int num1 = checked(GStructArr.Length - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
            if (LateBinding.LateIndexGet(GStructArr, new object[1]
                {
                    num2
                }, null) != null)
                checked
                {
                    ++num2;
                }
            else
                break;
        }

        if (num2 < GStructArr.Length)
        {
            structIndices.Add(num2);
            LateBinding.LateIndexSet(GStructArr, new object[2]
            {
                num2,
                @struct
            }, null);
        }
        else
        {
            Array instance = Array.CreateInstance(typeof(GffStruct), checked(GStructArr.Length + 1));
            Array.Copy(GStructArr, instance, GStructArr.Length);
            GStructArr = instance;
            structIndices.Add(checked(GStructArr.Length - 1));
            LateBinding.LateIndexSet(GStructArr, new object[2]
            {
                checked(GStructArr.Length - 1),
                @struct
            }, null);
        }
    }

    public void DeleteListElement(string PathToList, int index)
    {
        int num = IntegerType.FromObject(GetListNode(PathToList).structIndices[index]);
        GetListNode(PathToList).structIndices.RemoveAt(index);
        LateBinding.LateIndexSet(GStructArr, new object[2]
        {
            num,
            null
        }, null);
        FixGffListRefs();
    }

    public void ClearListElements(string PathToList)
    {
        GFFList listNode = GetListNode(PathToList);
        ArrayList structIndices = listNode.structIndices;
        if (structIndices.Count == 0)
            return;
        int index = checked(structIndices.Count - 1);
        while (index >= 0)
        {
            int num = IntegerType.FromObject(structIndices[index]);
            structIndices.RemoveAt(index);
            ScanStructForLists((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
            {
                num
            }, null));
            LateBinding.LateIndexSet(GStructArr, new object[2]
            {
                num,
                null
            }, null);
            FixGffListRefs();
            checked
            {
                index += -1;
            }
        }

        listNode.size = 0;
    }

    public void ClearListElements(GFFList List)
    {
        ArrayList structIndices = List.structIndices;
        if (structIndices.Count == 0)
            return;
        int index = checked(structIndices.Count - 1);
        while (index >= 0)
        {
            int num = IntegerType.FromObject(structIndices[index]);
            structIndices.RemoveAt(index);
            LateBinding.LateIndexSet(GStructArr, new object[2]
            {
                num,
                null
            }, null);
            FixGffListRefs();
            checked
            {
                index += -1;
            }
        }

        List.size = 0;
    }

    public void FixGffListRefs(int removedStructIndex = -1)
    {
        int o2;
        if (removedStructIndex == -1)
        {
            int num = checked(GStructArr.Length - 1);
            o2 = 0;
            while (o2 <= num)
            {
                if (LateBinding.LateIndexGet(GStructArr, new object[1]
                    {
                        o2
                    }, null) != null)
                    checked
                    {
                        ++o2;
                    }
                else
                    break;
            }
        }
        else
            o2 = removedStructIndex;

        if (o2 == GStructArr.Length)
            return;
        try
        {
            foreach (GFFList gffList in GGffListArr)
            {
                if (gffList != null)
                {
                    int index1 = checked(gffList.structIndices.Count - 1);
                    while (index1 >= 0)
                    {
                        if (ObjectType.ObjTst(gffList.structIndices[index1], o2, false) > 0)
                        {
                            ArrayList structIndices = gffList.structIndices;
                            ArrayList arrayList = structIndices;
                            int index2 = index1;
                            int index3 = index2;
                            object obj = ObjectType.SubObj(structIndices[index2], 1);
                            arrayList[index3] = obj;
                        }

                        checked
                        {
                            index1 += -1;
                        }
                    }
                }
            }
        }
        finally
        {
        }

        CleanupStructArrayAfterDelete();
        int num1 = checked(GStructArr.Length - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
            GFF_Field[] fields = ((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
            {
                num2
            }, null)).fields;
            int index = 0;
            while (index < fields.Length)
            {
                GFF_Field gffField1 = fields[index];
                if (gffField1.Type == GFFField.GFF_Struct && ObjectType.ObjTst(gffField1.value, o2, false) > 0)
                {
                    GFF_Field gffField2 = gffField1;
                    gffField2.value = ObjectType.SubObj(gffField2.value, 1);
                }

                checked
                {
                    ++index;
                }
            }

            checked
            {
                ++num2;
            }
        }
    }

    private void CleanupStructArrayAfterDelete()
    {
        bool flag = false;
        int num1 = checked(GStructArr.Length - 2);
        int num2 = 0;
        while (num2 <= num1)
        {
            if (LateBinding.LateIndexGet(GStructArr, new object[1]
                {
                    num2
                }, null) == null || flag)
            {
                LateBinding.LateIndexSet(GStructArr, new object[2]
                {
                    num2,
                    RuntimeHelpers.GetObjectValue(LateBinding.LateIndexGet(GStructArr, new object[1]
                    {
                        checked(num2 + 1)
                    }, null))
                }, null);
                flag = true;
            }

            checked
            {
                ++num2;
            }
        }

        Array instance = Array.CreateInstance(typeof(GffStruct), checked(GStructArr.Length - 1));
        Array.Copy(GStructArr, instance, checked(GStructArr.Length - 1));
        GStructArr = instance;
    }

    private void ScanStructForLists(GffStruct @struct)
    {
        GFF_Field[] fields = @struct.fields;
        int index1 = 0;
        while (index1 < fields.Length)
        {
            GFF_Field gffField = fields[index1];
            if (gffField.Type == GFFField.GFF_Struct)
                ScanStructForLists((GffStruct)gffField.value);
            else if (gffField.Type == GFFField.GFF_List)
            {
                int num = checked(((GFFList)gffField.value).structIndices.Count - 1);
                int index2 = 0;
                while (index2 <= num)
                {
                    ScanStructForLists((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
                    {
                        RuntimeHelpers.GetObjectValue(((GFFList)gffField.value).structIndices[index2])
                    }, null));
                    checked
                    {
                        ++index2;
                    }
                }

                ClearListElements((GFFList)gffField.value);
            }

            checked
            {
                ++index1;
            }
        }
    }

    public int GetListItemCount(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        object listNode = GetListNode(Path);
        return listNode == null ? -1 : ((GFFList)listNode).structIndices.Count;
    }

    public int GetStructFieldCount(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        return IntegerType.FromObject(LateBinding.LateGet(LateBinding.LateIndexGet(GStructArr, new object[1]
        {
            RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct))
        }, null), null, "fieldCount", new object[0], null, null));
    }

    public int GetStructFieldType(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        return FindListElement(GetListNode(Path)).type;
    }

    public GffStruct GetStruct(string Path)
    {
        Path = Strings.Replace(Path, "(", ".");
        Path = Strings.Replace(Path, ")", "");
        _nodeSearchPath = Strings.Split(Path, ".");
        _nodeSearchLevel = 0;
        return FindListElement(GetListNode(Path));
    }

    public void AddFieldToStruct(string Path, string Label, int Type, object Value)
    {
        GffStruct gffStruct = StringType.StrCmp(Path, "", false) != 0 ? GetStruct(Path) : _rootGffStruct;
        gffStruct.fields = (GFF_Field[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct.fields,
            new GFF_Field[checked(gffStruct.fieldCount + 1)]);
        checked
        {
            ++gffStruct.fieldCount;
        }

        gffStruct.fields[checked(gffStruct.fieldCount - 1)] = new GFF_Field()
        {
            label = Label,
            Type = (GFFField)Type,
            value = RuntimeHelpers.GetObjectValue(Value)
        };
    }

    public void AddKtInfoToGff()
    {
        if (!VerifyNodeExists("KTInfoVersion"))
            //AddKtcesFieldToRootGffStruct("KTInfoVersion", Application.ProductVersion);
            AddKtcesFieldToRootGffStruct("KTInfoVersion", null);
        else
            //SetNodeValue("KTInfoVersion", Application.ProductVersion);
            SetNodeValue("KTInfoVersion", null);
        if (!VerifyNodeExists("KTInfoDate"))
            AddKtcesFieldToRootGffStruct("KTInfoDate",
                DateAndTime.Now.ToLongDateString() + " " + DateAndTime.Now.ToLongTimeString());
        else
            SetNodeValue("KTInfoDate", DateAndTime.Now.ToLongDateString() + " " + DateAndTime.Now.ToLongTimeString());
        if (!VerifyNodeExists("KTGameVerIndex"))
            AddKtIntegerFieldToRootGffStruct("KTGameVerIndex", KotorVersionIndex);
        else
            SetNodeValue("KTGameVerIndex", KotorVersionIndex);
    }

    public void AddKtcesFieldToRootGffStruct(string label, string value)
    {
        _rootGffStruct.fields =
            (GFF_Field[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_rootGffStruct.fields,
                new GFF_Field[checked(_rootGffStruct.fieldCount + 1)]);
        checked
        {
            ++_rootGffStruct.fieldCount;
        }

        _rootGffStruct.fields[checked(_rootGffStruct.fieldCount - 1)] = new GFF_Field()
        {
            label = label,
            Type = GFFField.GFF_CExoString,
            value = value
        };
    }

    public void AddKtIntegerFieldToRootGffStruct(string label, int value)
    {
        _rootGffStruct.fields =
            (GFF_Field[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_rootGffStruct.fields,
                new GFF_Field[checked(_rootGffStruct.fieldCount + 1)]);
        checked
        {
            ++_rootGffStruct.fieldCount;
        }

        _rootGffStruct.fields[checked(_rootGffStruct.fieldCount - 1)] = new GFF_Field()
        {
            label = label,
            Type = GFFField.GFF_int,
            value = value
        };
    }

    public void AddSimpleField(string label, GFFField FieldType, object value)
    {
        _rootGffStruct.fields =
            (GFF_Field[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_rootGffStruct.fields,
                new GFF_Field[checked(_rootGffStruct.fieldCount + 1)]);
        checked
        {
            ++_rootGffStruct.fieldCount;
        }

        _rootGffStruct.fields[checked(_rootGffStruct.fieldCount - 1)] = new GFF_Field()
        {
            label = label,
            Type = FieldType,
            value = RuntimeHelpers.GetObjectValue(value)
        };
    }

    public void CreateList(string path, string Label)
    {
        int num;
        if (StringType.StrCmp(path, "", false) == 0)
        {
            num = 0;
        }
        else
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            string[] strArray = Strings.Split(path, ".");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchPath =
                (string[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_nodeSearchPath,
                    new string[checked(strArray.Length - 2 + 1)]);
            _nodeSearchLevel = 0;
            num = IntegerType.FromObject(
                ((GFFList)((GFF_Field)FindNode(_rootGffStruct)).value).structIndices[
                    IntegerType.FromString(strArray[checked(strArray.Length - 1)])]);
        }

        GffStruct gffStruct = (GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
        {
            num
        }, null);
        gffStruct.fields = (GFF_Field[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct.fields,
            new GFF_Field[checked(gffStruct.fields.Length + 1)]);
        checked
        {
            ++gffStruct.fieldCount;
        }

        GFFList fieldValue = new GFFList(0);
        gffStruct.fields[checked(gffStruct.fields.Length - 1)] = new GFF_Field(GFFField.GFF_List, Label, fieldValue);
        GGffListArr.Add(fieldValue);
    }

    public void AddKtNode()
    {
        /*GFF_Field gffField = new GFF_Field(GFFField.GFF_CResRef, "KTInfoMaj", Application.ProductVersion);*/
        GFF_Field gffField = new GFF_Field(GFFField.GFF_CResRef, "KTInfoMaj", null);
        GFF_Field[] fields = ((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
        {
            0
        }, null)).fields;
        GFF_Field[] gffFieldArray =
            (GFF_Field[])Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(fields,
                new GFF_Field[checked(fields.Length + 1)]);
        gffFieldArray[checked(gffFieldArray.Length - 1)] = gffField;
        ((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
        {
            0
        }, null)).fields = gffFieldArray;
    }

    public void CreateEnglishCExoLocSubStringEntry(string path, string Value)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(path);
        nodeValue.StringCount = 1;
        nodeValue.StringRef = -1;
        nodeValue.subStringArr = (object[])Array.CreateInstance(typeof(object), 1);
        nodeValue.subStringArr[0] = new GFFExoLocSubString()
        {
            StringID = 0,
            StringLength = Value.Length,
            value = Value
        };
        nodeValue.size = checked(16 + Value.Length);
    }

    public void SetEnglishCExoLocSubStringEntry(string path, string Value)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(path);
        nodeValue.subStringArr[0] = new GFFExoLocSubString()
        {
            StringID = 0,
            StringLength = Value.Length,
            value = Value
        };
        nodeValue.size = checked(16 + Value.Length);
    }

    public void CreateCExoLocSubStringEntry(string path, string Value, int languageId = 0)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(path);
        nodeValue.StringCount = 1;
        nodeValue.StringRef = -1;
        nodeValue.subStringArr = (object[])Array.CreateInstance(typeof(object), 1);
        nodeValue.subStringArr[0] = new GFFExoLocSubString()
        {
            StringID = languageId,
            StringLength = Value.Length,
            value = Value
        };
        nodeValue.size = checked(16 + Value.Length);
    }

    public void SetCExoLocSubStringEntry(string path, string Value, int languageId = 0)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(path);
        nodeValue.subStringArr[0] = new GFFExoLocSubString()
        {
            StringID = languageId,
            StringLength = Value.Length,
            value = Value
        };
        nodeValue.size = checked(16 + Value.Length);
    }

    public void CreateRootStruct()
    {
        GStructArr = Array.CreateInstance(typeof(object), 1);
        _rootGffStruct.fields = (GFF_Field[])Array.CreateInstance(typeof(GFF_Field), 0);
        LateBinding.LateIndexSet(GStructArr, new object[2]
        {
            0,
            _rootGffStruct
        }, null);
    }

    public void WriteFile(string path, string filetype)
    {
        FileStream output = new FileStream(path, FileMode.Create);
        BinaryWriter binaryWriter = new BinaryWriter(output);
        Hashtable hashtable = new Hashtable();
        int num1 = 0;
        AddKtInfoToGff();
        int num2 = checked(GStructArr.Length * 12);
        binaryWriter.Write((Strings.UCase(Strings.Trim(filetype)) + " V3.2").ToCharArray());
        int num3 = 0;
        int num4 = 0;
        int num5 = checked(GStructArr.Length - 1);
        int num6 = 0;
        while (num6 <= num5)
        {
            GFF_Field[] fields = ((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
            {
                num6
            }, null)).fields;
            int index = 0;
            while (index < fields.Length)
            {
                GFF_Field gffField = fields[index];
                checked
                {
                    ++num3;
                }

                if (hashtable.ContainsKey(gffField.label))
                {
                    gffField.labelIndex = IntegerType.FromObject(hashtable[gffField.label]);
                }
                else
                {
                    hashtable.Add(gffField.label, num4);
                    gffField.labelIndex = num4;
                    checked
                    {
                        ++num4;
                    }
                }

                checked
                {
                    ++index;
                }
            }

            checked
            {
                ++num6;
            }
        }

        int num7 = checked(num3 * 12);
        int num8 = checked(hashtable.Count * 16);
        int num9 = 0;
        int num10 = checked(GStructArr.Length - 1);
        int num11 = 0;
        int num12 = 0;
        while (num11 <= num10)
        {
            GFF_Field[] fields = ((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
            {
                num11
            }, null)).fields;
            int index = 0;
            while (index < fields.Length)
            {
                GFF_Field gffField = fields[index];
                if (gffField.Type >= GFFField.GFF_dword64)
                {
                    int num13 = 0;
                    checked
                    {
                        ++num13;
                    }

                    switch (gffField.Type)
                    {
                        case GFFField.GFF_dword64:
                        case GFFField.GFF_int64:
                        case GFFField.GFF_double:
                            checked
                            {
                                num9 += 8;
                            }

                            break;
                        case GFFField.GFF_float:
                            checked
                            {
                                num9 += 4;
                            }

                            break;
                        case GFFField.GFF_CExoString:
                            checked
                            {
                                num9 += 4 + StringType.FromObject(gffField.value).Length;
                            }

                            break;
                        case GFFField.GFF_CResRef:
                            checked
                            {
                                num9 += 1 + StringType.FromObject(gffField.value).Length;
                            }

                            break;
                        case GFFField.GFF_CExoLocString:
                            checked
                            {
                                num9 += ((GFFExoLocString)gffField.value).size + 4;
                            }

                            break;
                        case GFFField.GFF_Void:
                            checked
                            {
                                num9 += 4 + ((GffVoid)gffField.value).Size;
                            }

                            break;
                        case GFFField.GFF_Struct:
                            break;
                        case GFFField.GFF_List:
                            checked
                            {
                                num12 += ((GFFList)gffField.value).structIndices.Count * 4 + 4;
                            }

                            break;
                        case GFFField.GFF_Type16:
                            checked
                            {
                                num9 += 16;
                            }

                            break;
                        case GFFField.GFF_Type17:
                            checked
                            {
                                num9 += 12;
                            }

                            break;
                        default:
                            Console.WriteLine("Unknown Field type: " + StringType.FromInteger((int)gffField.Type));
                            break;
                    }
                }

                checked
                {
                    ++index;
                }
            }

            checked
            {
                ++num11;
            }
        }

        int num14 = checked(GStructArr.Length - 1);
        int num15 = 0;
        int num16 = 0;
        while (num15 <= num14)
        {
            if (((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
                {
                    num15
                }, null)).fieldCount > 1)
                checked
                {
                    num16 += ((GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
                    {
                        num15
                    }, null)).fieldCount;
                }

            checked
            {
                ++num15;
            }
        }

        int offset1 = 56;
        int num17 = checked(56 + num2);
        int offset2 = num17;
        int num18 = checked(num17 + num7);
        int offset3 = num18;
        int num19 = checked(num18 + num8);
        int offset4 = num19;
        int num20 = checked(num19 + num9);
        int offset5 = num20;
        int num21 = checked(num20 + num16 * 4);
        int offset6 = num21;
        binaryWriter.Seek(8, SeekOrigin.Begin);
        binaryWriter.Write(56);
        binaryWriter.Write(GStructArr.Length);
        binaryWriter.Write(num17);
        binaryWriter.Write(checked((int)Math.Round(num7 / 12.0)));
        binaryWriter.Write(num18);
        binaryWriter.Write(checked((int)Math.Round(num8 / 16.0)));
        binaryWriter.Write(num19);
        binaryWriter.Write(num9);
        binaryWriter.Write(num20);
        binaryWriter.Write(checked(num16 * 4));
        binaryWriter.Write(num21);
        binaryWriter.Write(num12);
        int num22 = checked(GStructArr.Length - 1);
        int num23 = 0;
        while (num23 <= num22)
        {
            GffStruct gffStruct = (GffStruct)LateBinding.LateIndexGet(GStructArr, new object[1]
            {
                num23
            }, null);
            gffStruct.DataOrDataOffset = gffStruct.fieldCount != 1 ? checked(offset5 - num20) : num1;
            binaryWriter.Seek(offset1, SeekOrigin.Begin);
            binaryWriter.Write(gffStruct.type);
            binaryWriter.Write(gffStruct.DataOrDataOffset);
            binaryWriter.Write(gffStruct.fieldCount);
            offset1 = checked((int)output.Position);
            GFF_Field[] fields = gffStruct.fields;
            int index1 = 0;
            while (index1 < fields.Length)
            {
                GFF_Field gffField1 = fields[index1];
                if (gffStruct.fieldCount > 1)
                {
                    binaryWriter.Seek(offset5, SeekOrigin.Begin);
                    binaryWriter.Write(num1);
                    offset5 = checked((int)output.Position);
                }

                switch (gffField1.Type)
                {
                    case GFFField.GFF_byte:
                    case GFFField.GFF_char:
                    case GFFField.GFF_word:
                    case GFFField.GFF_short:
                    case GFFField.GFF_dword:
                    case GFFField.GFF_int:
                    case GFFField.GFF_float:
                    case GFFField.GFF_Struct:
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        if (gffField1.Type < GFFField.GFF_int)
                            binaryWriter.Write(Convert.ToUInt32(RuntimeHelpers.GetObjectValue(gffField1.value)));
                        else if (gffField1.Type == GFFField.GFF_int)
                            binaryWriter.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(gffField1.value)));
                        else if (gffField1.Type == GFFField.GFF_float)
                        {
                            binaryWriter.Write(Convert.ToSingle(RuntimeHelpers.GetObjectValue(gffField1.value)));
                        }
                        else
                        {
                            BinaryWriter o = binaryWriter;
                            object[] objArray1 = new object[1];
                            object[] objArray2 = objArray1;
                            GFF_Field gffField2 = gffField1;
                            object objectValue = RuntimeHelpers.GetObjectValue(gffField2.value);
                            objArray2[0] = objectValue;
                            object[] objArray3 = objArray1;
                            object[] args = objArray3;
                            bool[] flagArray = new bool[1] { true };
                            bool[] copyBack = flagArray;
                            LateBinding.LateCall(o, null, "Write", args, null, copyBack);
                            if (flagArray[0])
                                gffField2.value = RuntimeHelpers.GetObjectValue(objArray3[0]);
                        }

                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_dword64:
                    case GFFField.GFF_int64:
                    case GFFField.GFF_double:
                    case GFFField.GFF_CResRef:
                        gffField1.DataOffset = checked(offset4 - num19);
                        binaryWriter.Seek(offset4, SeekOrigin.Begin);
                        BinaryWriter o1 = binaryWriter;
                        object[] objArray4 = new object[1];
                        object[] objArray5 = objArray4;
                        GFF_Field gffField3 = gffField1;
                        object objectValue1 = RuntimeHelpers.GetObjectValue(gffField3.value);
                        objArray5[0] = objectValue1;
                        object[] objArray6 = objArray4;
                        object[] args1 = objArray6;
                        bool[] flagArray1 = new bool[1] { true };
                        bool[] copyBack1 = flagArray1;
                        LateBinding.LateCall(o1, null, "Write", args1, null, copyBack1);
                        if (flagArray1[0])
                            gffField3.value = RuntimeHelpers.GetObjectValue(objArray6[0]);
                        offset4 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_CExoString:
                        gffField1.DataOffset = checked(offset4 - num19);
                        binaryWriter.Seek(offset4, SeekOrigin.Begin);
                        binaryWriter.Write(StringType.FromObject(gffField1.value).Length);
                        Encoding encoding = Encoding.GetEncoding(1252);
                        object[] objArray7 = new object[1];
                        object[] objArray8 = objArray7;
                        GFF_Field gffField4 = gffField1;
                        object objectValue2 = RuntimeHelpers.GetObjectValue(gffField4.value);
                        objArray8[0] = objectValue2;
                        object[] objArray9 = objArray7;
                        object[] args2 = objArray9;
                        bool[] flagArray2 = new bool[1] { true };
                        bool[] copyBack2 = flagArray2;
                        object obj = LateBinding.LateGet(encoding, null, "GetBytes", args2, null, copyBack2);
                        if (flagArray2[0])
                            gffField4.value = RuntimeHelpers.GetObjectValue(objArray9[0]);
                        byte[] buffer = (byte[])obj;
                        binaryWriter.Write(buffer);
                        offset4 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_CExoLocString:
                        gffField1.DataOffset = checked(offset4 - num19);
                        binaryWriter.Seek(offset4, SeekOrigin.Begin);
                        GFFExoLocString gffExoLocString = (GFFExoLocString)gffField1.value;
                        binaryWriter.Write(gffExoLocString.size);
                        binaryWriter.Write(gffExoLocString.StringRef);
                        binaryWriter.Write(gffExoLocString.StringCount);
                        object[] subStringArr = gffExoLocString.subStringArr;
                        int index2 = 0;
                        while (index2 < subStringArr.Length)
                        {
                            GFFExoLocSubString gffExoLocSubString = (GFFExoLocSubString)subStringArr[index2];
                            binaryWriter.Write(gffExoLocSubString.StringID);
                            binaryWriter.Write(gffExoLocSubString.StringLength);
                            byte[] bytes = Encoding.GetEncoding(1252).GetBytes(gffExoLocSubString.value);
                            binaryWriter.Write(bytes);
                            checked
                            {
                                ++index2;
                            }
                        }

                        offset4 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_Void:
                        gffField1.DataOffset = checked(offset4 - num19);
                        binaryWriter.Seek(offset4, SeekOrigin.Begin);
                        binaryWriter.Write(((GffVoid)gffField1.value).Size);
                        binaryWriter.Write(((GffVoid)gffField1.value).Bytes);
                        offset4 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_List:
                        gffField1.DataOffset = checked(offset6 - num21);
                        binaryWriter.Seek(offset6, SeekOrigin.Begin);
                        binaryWriter.Write(((GFFList)gffField1.value).structIndices.Count);
                        try
                        {
                            foreach (object structIndex in ((GFFList)gffField1.value).structIndices)
                            {
                                int num24 = IntegerType.FromObject(structIndex);
                                binaryWriter.Write(num24);
                            }
                        }
                        finally
                        {
                        }

                        offset6 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_Type16:
                        gffField1.DataOffset = checked(offset4 - num19);
                        binaryWriter.Seek(offset4, SeekOrigin.Begin);
                        binaryWriter.Write(((GFFType16)gffField1.value).f1);
                        binaryWriter.Write(((GFFType16)gffField1.value).f2);
                        binaryWriter.Write(((GFFType16)gffField1.value).f3);
                        binaryWriter.Write(((GFFType16)gffField1.value).f4);
                        offset4 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                    case GFFField.GFF_Type17:
                        gffField1.DataOffset = checked(offset4 - num19);
                        binaryWriter.Seek(offset4, SeekOrigin.Begin);
                        binaryWriter.Write(((GFFType17)gffField1.value).f1);
                        binaryWriter.Write(((GFFType17)gffField1.value).f2);
                        binaryWriter.Write(((GFFType17)gffField1.value).f3);
                        offset4 = checked((int)output.Position);
                        binaryWriter.Seek(offset2, SeekOrigin.Begin);
                        binaryWriter.Write((int)gffField1.Type);
                        binaryWriter.Write(gffField1.labelIndex);
                        binaryWriter.Write(gffField1.DataOffset);
                        offset2 = checked((int)output.Position);
                        checked
                        {
                            ++num1;
                        }

                        break;
                }

                checked
                {
                    ++index1;
                }
            }

            checked
            {
                ++num23;
            }
        }

        char[] chArray = new char[16];
        binaryWriter.Seek(offset3, SeekOrigin.Begin);
        int num25 = checked(hashtable.Count - 1);
        int o2 = 0;
        while (o2 <= num25)
        {
            string key1 = null;
            try
            {
                foreach (object key2 in hashtable.Keys)
                {
                    key1 = StringType.FromObject(key2);
                    if (ObjectType.ObjTst(hashtable[key1], o2, false) == 0)
                        break;
                }
            }
            finally
            {
            }

            Array.Clear(chArray, 0, 16);
            Array.Copy(key1.ToCharArray(), chArray, key1.Length);
            binaryWriter.Write(chArray);
            checked
            {
                ++o2;
            }
        }

        binaryWriter.Close();
    }

    public void SetTextBoxToNodeValue(TextBox tb, string NodePath)
    {
        object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(NodePath));
        if (objectValue == null)
            return;
        tb.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue));
    }

    public string GetCExoLocStringNodeValue(string NodePath)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(NodePath);
        if (nodeValue == null)
            return "(GFF Path not found: " + NodePath + ")";
        if (nodeValue.StringRef != -1)
            return _dialogTlk.GetString(nodeValue.StringRef);
        string str = null;
        return nodeValue.StringCount > 0 ? ((GFFExoLocSubString)nodeValue.subStringArr[0]).value : str;
    }

    public void SetNumericUpDownToNodeValue(NumericUpDown nud, string NodePath, float ScaleFactor = 0.0f)
    {
        object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(NodePath));
        if (objectValue != null)
            nud.Value = DecimalType.FromObject(objectValue);
        if (objectValue == null)
            return;
        if (ScaleFactor == 0.0)
            nud.Value = DecimalType.FromObject(objectValue);
        else
            nud.Value = DecimalType.FromObject(ObjectType.MulObj(objectValue, ScaleFactor));
    }

    public void SetNumericUpDownToUIntNodeValue(
        NumericUpDown nud,
        string NodePath,
        float ScaleFactor = 0.0f)
    {
        object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(NodePath));
        if (objectValue == null)
            return;
        if (ScaleFactor == 0.0)
            nud.Value = new Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)));
        else
            nud.Value = new Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) * ScaleFactor);
    }

    public void FillComboBoxFrom2Da(
        ComboBox cmbx,
        string colName,
        string twoDaName,
        ChitinKey ChitinKey,
        clsDialogTlk DialogTlk,
        string kotOrPath)
    {
        int resIdForResRef = ChitinKey.FindResIdForResRef(twoDaName, 2017);
        Cls2Da cls2Da = new Cls2Da(GetBiffResource(kotOrPath + "\\" + ChitinKey.BiffList[resIdForResRef >> 20].Filename,
            resIdForResRef).Data);
        if (DialogTlk != null)
        {
            int rowsUpperBound = cls2Da.RowsUpperBound;
            int rowNumber = 0;
            while (rowNumber <= rowsUpperBound)
            {
                object indiceData = cls2Da.GetIndiceData(rowNumber, colName);
                if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)))
                    cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)));
                else
                    cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData));
                checked
                {
                    ++rowNumber;
                }
            }
        }
        else
        {
            int rowsUpperBound = cls2Da.RowsUpperBound;
            int rowNumber = 0;
            while (rowNumber <= rowsUpperBound)
            {
                cmbx.Items.Add(cls2Da.GetIndiceData(rowNumber, colName));
                checked
                {
                    ++rowNumber;
                }
            }
        }
    }

    public bool SyncComboBox(ComboBox cmbx, string NodePath)
    {
        object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(NodePath));
        bool flag = false;
        if (objectValue != null)
        {
            if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) > checked(cmbx.Items.Count - 1))
            {
                cmbx.BackColor = Color.Tomato;
                cmbx.SelectedIndex = -1;
                flag = false;
            }
            else
            {
                cmbx.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue));
                flag = true;
            }
        }

        return flag;
    }

    public void SetTextBoxFrom2Da(
        TextBox txtbx,
        int rowNumber,
        string colName,
        string twoDaName,
        ChitinKey ChitinKey,
        clsDialogTlk DialogTlk,
        string kotOrPath)
    {
        int resIdForResRef = ChitinKey.FindResIdForResRef(twoDaName, 2017);
        Cls2Da cls2Da = new Cls2Da(GetBiffResource(kotOrPath + "\\" + ChitinKey.BiffList[resIdForResRef >> 20].Filename,
            resIdForResRef).Data);
        if (DialogTlk != null)
        {
            object indiceData = cls2Da.GetIndiceData(rowNumber, colName);
            txtbx.Text = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData))
                ? StringType.FromInteger(0)
                : DialogTlk.GetString(IntegerType.FromObject(indiceData));
        }
        else
            txtbx.Text = cls2Da.GetIndiceData(rowNumber, colName);
    }

    public void SetTextBoxFromCExoLocStringNodeValue(
        TextBox tb,
        string NodePath,
        clsDialogTlk DialogTlk)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(NodePath);
        if (nodeValue == null)
            tb.Text = "(GFF Path not found: " + NodePath + ")";
        else if (nodeValue.StringRef != -1)
        {
            tb.Text = DialogTlk.GetString(nodeValue.StringRef);
        }
        else
        {
            if (nodeValue.StringCount <= 0)
                return;
            tb.Text = ((GFFExoLocSubString)nodeValue.subStringArr[0]).value;
        }
    }

    public void SetTextBoxFromCExoLocStringNodeValue(TextBox tb, string NodePath)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(NodePath);
        if (nodeValue.StringRef != -1)
        {
            tb.Text = _dialogTlk.GetString(nodeValue.StringRef);
        }
        else
        {
            if (nodeValue.StringCount <= 0)
                return;
            tb.Text = ((GFFExoLocSubString)nodeValue.subStringArr[0]).value;
        }
    }

    public object GetCExoLocStringLanguage(string NodePath)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(NodePath);
        if (nodeValue.StringRef != -1)
            return -1;
        object obj = null;
        return nodeValue.StringCount > 0 ? ((GFFExoLocSubString)nodeValue.subStringArr[0]).StringID : obj;
    }

    public void SetCExoLocStringNodeValueFromTextBox(TextBox tb, string NodePath, int languageId = 0)
    {
        GFFExoLocString nodeValue = (GFFExoLocString)GetNodeValue(NodePath);
        if (nodeValue.StringRef == -1)
        {
            if (nodeValue.StringCount == 0)
                CreateCExoLocSubStringEntry(NodePath, tb.Text, languageId);
            else
                SetCExoLocSubStringEntry(NodePath, tb.Text, languageId);
        }
        else
            CreateCExoLocSubStringEntry(NodePath, tb.Text, languageId);
    }

    public void SetNodeValueFromTextBox(TextBox tb, string NodePath) => SetNodeValue(NodePath, tb.Text);

    public void SetUInt16NodeValueFromTextBox(TextBox tb, string NodePath) =>
        SetNodeValue(NodePath, Convert.ToUInt16(tb.Text));

    public void SetUInt32NodeValueFromTextBox(TextBox tb, string NodePath) =>
        SetNodeValue(NodePath, Convert.ToUInt32(tb.Text));

    public void SetNodeValueFromComboBox(ComboBox Cmbx, string NodePath) => SetNodeValue(NodePath, Cmbx.SelectedIndex);

    public void SetNodeValueFromNumericUpDown(
        NumericUpDown nud,
        string NodePath,
        float ScaleFactor = 0.0f)
    {
        if (ScaleFactor == 0.0)
            SetNodeValue(NodePath, nud.Value);
        else
            SetNodeValue(NodePath, (float)(Convert.ToSingle(nud.Value) / (double)ScaleFactor));
    }

    public void SetUInt16NodeValueFromNumericUpDown(
        NumericUpDown nud,
        string NodePath,
        float ScaleFactor = 0.0f)
    {
        if (ScaleFactor == 0.0)
            SetNodeValue(NodePath, Convert.ToUInt16(nud.Value));
        else
            SetNodeValue(NodePath, Convert.ToUInt16(Convert.ToSingle(nud.Value) / ScaleFactor));
    }

    public void SetUInt32NodeValueFromNumericUpDown(
        NumericUpDown nud,
        string NodePath,
        float ScaleFactor = 0.0f)
    {
        if (ScaleFactor == 0.0)
            SetNodeValue(NodePath, Convert.ToUInt32(nud.Value));
        else
            SetNodeValue(NodePath, Convert.ToUInt32(Convert.ToSingle(nud.Value) / ScaleFactor));
    }

    private BiffVarRsrcEntry GetBiffResource(string biffPath, int resourceId) =>
        new BIFFArchive(new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
            .GetBiffResource(resourceId);

    private void PrintMsg(string msg, bool indented)
    {
        if (indented)
            _gStringbuilder.Append(Strings.Space(checked(_gTabLevel * 3)));
        _gStringbuilder.Append(msg);
    }
}