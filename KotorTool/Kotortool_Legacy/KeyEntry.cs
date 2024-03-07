using System.Text;

namespace Kotortool_Legacy;

[Serializable]
public sealed class KeyEntry
{
    public int Index;
    public string ResRef;
    public short ResourceType;
    public int ResId;

    public object text => ResRef;

    public KeyEntry(string sResRef, short iResourceType, int iResId)
    {
        ResRef = sResRef;
        ResourceType = iResourceType;
        ResId = iResId;
    }

    public KeyEntry(int index, FileStream fs, int offset)
    {
        BinaryReader binaryReader = new BinaryReader(fs, Encoding.ASCII);
        char[] chArray1 = new char[16];
        Index = index;
        fs.Seek(offset, SeekOrigin.Begin);

        char[] chArray2 = binaryReader.ReadChars(16);


        int index1 = 0;
        while (chArray2[index1] != char.MinValue)
        {
            checked
            {
                ++index1;
            }

            if (index1 > 15)
                break;
        }

        ResRef = new StringBuilder(new string(chArray2))
        {
            Length = index1
        }.ToString();
        ResourceType = binaryReader.ReadInt16();
        ResId = binaryReader.ReadInt32();
    }

    public KeyEntry(int index, byte[] data, int offset)
    {
        byte[] numArray = new byte[16];
        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
        this.Index = index;
        StringBuilder stringBuilder = new StringBuilder(asciiEncoding.GetString(data, offset, 16));
        int index1 = 0;
        while (stringBuilder[index1] != char.MinValue)
        {
            checked
            {
                ++index1;
            }

            if (index1 > 15)
                break;
        }

        stringBuilder.Length = index1;
        ResRef = stringBuilder.ToString();
        ResourceType = GetInt16FromArray(data, checked(offset + 16));
        ResId = GetInt32FromArray(data, checked(offset + 18));
    }

    private short GetInt16FromArray(byte[] Arr, int offset) =>
        checked((short)Math.Round(Arr[offset] + Arr[checked(offset + 1)] * 256.0));

    private int GetInt32FromArray(byte[] Arr, int offset) => checked((int)Math.Round(Arr[offset] +
        Arr[checked(offset + 1)] * 256.0 + Arr[checked(offset + 2)] * 65536.0 +
        Arr[checked(offset + 3)] * 16777216.0));

    public KeyEntry ShallowClone()
    {
        return MemberwiseClone() as KeyEntry;
    }

    public override string ToString()
    {
        return
            $"{nameof(Index)}: {Index}, {nameof(ResRef)}: {ResRef}, {nameof(ResourceType)}: {ResourceType}, {nameof(ResId)}: {ResId}";
    }
}