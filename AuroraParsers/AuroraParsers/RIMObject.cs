using System.Diagnostics;

namespace AuroraParsers.AuroraParsers;

public class RimObject
{

    public struct _RIMHEader
    {
        public char[] FileType;                 //Char 4
        public char[] FileVersion;              //Char 4
        public uint Unknown_1;
        public uint EntryCount;
        public uint OffsetToKeyList;
        public byte[] Reserved;                 //Byte 64
    }

    public struct _RIMKey
    {
        public char[] ResRef;             //Char 16 NULL terminated
        public ushort ResType;
        public ushort ResID;              //Resource ID
        public ushort Reserved;
        public uint Offset;
        public uint Length;
    }

    public struct _RIMResource
    {
        public char[] ResRef;             //Char 16 NULL terminated
        public ushort ResType;
        public uint Length;
        public byte[] Bytes;
    }

    private AuroraFile _file;
    private BinaryReader _reader;
    private byte[] _byteBuffer;

    private _RIMHEader _header = new();
    public readonly List<_RIMKey> Keys = new();


    public RimObject(AuroraFile file)
    {
        _file = file;
    }

    public void Read()
    {
        _file.Open();
        _reader = _file.GetReader();

        _header.FileType = _reader.ReadChars(4);
        _header.FileVersion = _reader.ReadChars(4);
        _header.Unknown_1 = _reader.ReadUInt32();
        _header.EntryCount = _reader.ReadUInt32();
        _header.OffsetToKeyList = _reader.ReadUInt32();
        _header.Reserved = _reader.ReadBytes(100); //Reserved bytes

        _reader.BaseStream.Position = _header.OffsetToKeyList;

        for (var i = 0; i != _header.EntryCount; i++)
        {

            var key = new _RIMKey
            {
                ResRef = _reader.ReadChars(16),
                ResType = _reader.ReadUInt16(),
                ResID = _reader.ReadUInt16(),
                Reserved = _reader.ReadUInt16(),
                Offset = _reader.ReadUInt32(),
                Length = _reader.ReadUInt32()
            };
            Keys.Add(key);

            Debug.WriteLine(new string(key.ResRef));

        }

        _file.Close();
    }

    public byte[] GetRawResource(_RIMKey _key)
    {
        _file.Open();
        _reader = _file.GetReader();
        _reader.BaseStream.Position = _key.Offset;
        byte[] bytes = _reader.ReadBytes((int)_key.Length);
        _file.Close();

        return bytes;
    }

    public _RIMKey GetResourceByKey(string key, int resourceType)
    {

        Debug.WriteLine("Searching: " + _file.GetFilename());
        foreach (_RIMKey rimKey in Keys)
        {
            //Debug.WriteLine("Resource Name: " + new string(_key.ResRef));
            if (new string(rimKey.ResRef).Replace("\0", string.Empty) == key && rimKey.ResType == (ushort)resourceType)
            {

                return rimKey;
            }
        }
        return new _RIMKey();
    }

    public AuroraFile GetFile()
    {
        return _file;
    }

}