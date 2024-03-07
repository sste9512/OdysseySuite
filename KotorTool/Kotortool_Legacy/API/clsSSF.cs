using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class ClsSsf()
{
    private readonly int[] _mRefArray = new int[41];
    private readonly Options _currentSettings = UserSettings.GetSettings();
    private readonly clsDialogTlk _gClsDialogTlk;
        
    private UserSettings _usetting = new();

    public ClsSsf(int KotorVerIndex)
        : this()
    {
        _gClsDialogTlk = new clsDialogTlk(_currentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
    }

    public ClsSsf(clsDialogTlk DialogTlk)
        : this()
    {
        _gClsDialogTlk = DialogTlk;
    }

    public ClsSsf(FileStream fs, int kotorVerIndex)
        : this(kotorVerIndex)
    {
        BinaryReader binaryReader = new BinaryReader(fs);
        binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
        int index = 0;
        do
        {
            _mRefArray[index] = binaryReader.ReadInt32();
            checked
            {
                ++index;
            }
        } while (index <= 39);

        binaryReader.Close();
    }

    public ClsSsf(FileStream fs, clsDialogTlk DialogTlk)
        : this(DialogTlk)
    {
        BinaryReader binaryReader = new BinaryReader(fs);
        binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
        int index = 0;
        do
        {
            _mRefArray[index] = binaryReader.ReadInt32();
            checked
            {
                ++index;
            }
        } while (index <= 39);

        binaryReader.Close();
    }

    public ClsSsf(byte[] data, int kotorVerIndex)
        : this(kotorVerIndex)
    {
        BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
        binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
        int index = 0;
        do
        {
            _mRefArray[index] = binaryReader.ReadInt32();
            checked
            {
                ++index;
            }
        } while (index <= 39);
    }

    public ClsSsf(byte[] data, clsDialogTlk DialogTlk)
        : this(DialogTlk)
    {
        BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
        binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
        int index = 0;
        do
        {
            _mRefArray[index] = binaryReader.ReadInt32();
            checked
            {
                ++index;
            }
        } while (index <= 39);
    }

    public int get_RefArray(object index) =>
        BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, false) >= 0,
            ObjectType.ObjTst(index, 39, false) <= 0))
            ? _mRefArray[IntegerType.FromObject(index)]
            : -999;

    public void set_RefArray(object index, int Value)
    {
        if (!BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, false) >= 0,
                ObjectType.ObjTst(index, 39, false) <= 0)))
            return;
        _mRefArray[IntegerType.FromObject(index)] = Value;
    }

    public string get_RefArrayString(object index)
    {
        if (!BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, false) >= 0,
                ObjectType.ObjTst(index, 39, false) <= 0)))
            return "Invalid clsSSF array index!";
        return _mRefArray[IntegerType.FromObject(index)] != -1
            ? _gClsDialogTlk.GetString(_mRefArray[IntegerType.FromObject(index)])
            : string.Empty;
    }

    public string get_RefArraySoundResRef(object index) => _mRefArray[IntegerType.FromObject(index)] != -1
        ? _gClsDialogTlk.GetSoundResRef(_mRefArray[IntegerType.FromObject(index)])
        : string.Empty;

    public void WriteFile(string filepath)
    {
        var binaryWriter = new BinaryWriter(new FileStream(filepath, FileMode.Create));
        binaryWriter.Write("SSF V1.1".ToCharArray());
        binaryWriter.Write(12);
        var index = 0;
        do
        {
            binaryWriter.Write(_mRefArray[index]);
            checked
            {
                ++index;
            }
        } while (index <= 39);

        binaryWriter.Close();
    }
}