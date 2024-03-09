namespace AuroraParsers.AuroraParsers.Chitin;

public sealed class KeyObject
{
    private AuroraFile _file;
    private BinaryReader _reader;
    private KeyHeader _header;
    private List<KeyTable> _keysList;

    public KeyObject(AuroraFile file)
    {
        _file = file;
        _header = new KeyHeader();
        _keysList = new List<KeyTable>();
    }

    public void Read()
    {
        _file.Open();
        _reader = _file.GetReader();


        _header.FileType = _reader.ReadChars(4);
        _header.FileVersion = _reader.ReadChars(4);
        _header.BifCount = _reader.ReadUInt32();
        _header.KeyCount = _reader.ReadUInt32();
        _header.OffsetToFileTable = _reader.ReadUInt32();
        _header.OffsetToKeyTable = _reader.ReadUInt32();
        _header.BuildYear = _reader.ReadUInt32();
        _header.BuildDay = _reader.ReadUInt32();
        _header.Reserved = _reader.ReadBytes(32);

        _reader.BaseStream.Position = _header.OffsetToKeyTable;

        for (var i = 0; i != _header.KeyCount; i++)
        {
            var key = new KeyTable
            {
                ResRef = _reader.ReadChars(16),
                ResourceType = _reader.ReadUInt16(),
                ResId = _reader.ReadUInt32()
            };

            _keysList.Add(key);
        }


        _file.Close();
    }


    public KeyTable FindFileKey(string resRef, uint resourceType)
    {
        System.Diagnostics.Debug.WriteLine("Searching for: " + resRef);

        foreach (var key in _keysList)
        {
            if (!new string(key.ResRef).Replace("\0", string.Empty).Equals(resRef) ||
                key.ResourceType != resourceType) continue;

            System.Diagnostics.Debug.WriteLine("Found: " + new string(key.ResRef));
            return key;
        }

        return _keysList[0];

    }

    public override string ToString()
    {
        return $"{nameof(_file)}: {_file}, {nameof(_reader)}: {_reader}, {nameof(_header)}: {_header}, {nameof(_keysList)}: {_keysList}";
    }
}