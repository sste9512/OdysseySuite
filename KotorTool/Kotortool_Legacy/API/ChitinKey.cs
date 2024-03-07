using System.Buffers;
using System.Collections;
using System.Text;
using Kotortool_Legacy.Domain.Interfaces;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public struct ChitinKeyHeader
{
    public int BifCount;
    public int KeyCount;
    public int FileTableOff;
    public int KeyTableOff;
    public long ByteSum;
    public long ByteLength;
}
    
public class ChitinKey : IOwnsMany<BiffEntry>, IEnumerable<BiffEntry>, IDisposable
{
    private FileStream _keyFileStream;
    private MemoryStream _memoryStream;
    private BinaryReader _binaryReader;

    public ChitinKeyHeader ChitinKeyHeader { get; set; } = new();
        
    private int _bifCount;
    private int _keyCount;
    private int _fileTableOff;
    private int _keyTableOff;
    public long Lsum;
    public readonly long Llength;
        
    public IMemoryOwner<BiffEntry> MemoryOwner { get; set; }
        
    public BiffEntry[] BiffList;
    private Hashtable _hashtableBiff;
    private Hashtable _hashTableResourceReferencesWithId;
        
    private string _lastRequestedBifNameHash;

    public Hashtable BiffListInfo;
    public List<Exception> Exceptions { get; set; } = new();

    public ChitinKey(string keyPath)
    {
        _hashtableBiff = new Hashtable();
        BiffListInfo = new Hashtable();
        _keyFileStream = new FileStream(keyPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 570000);
        //var numArray = new byte[checked((int)(_keyFileStream.Length - 1L) + 1)];
        Llength = _keyFileStream.Length;
        _binaryReader = new BinaryReader(_keyFileStream, Encoding.ASCII);
        var buffer = _binaryReader.ReadBytes(checked((int)_keyFileStream.Length));
        _binaryReader.Close();
        
        _memoryStream = new MemoryStream(buffer);
        _binaryReader = new BinaryReader(_memoryStream, Encoding.ASCII);
        _memoryStream.Seek(0L, SeekOrigin.Begin);
           
            
        ResolveLsumFromMemory();
        //_memoryStream.Seek(8L, SeekOrigin.Begin);
        _memoryStream.JumpTo(8L);
       
        PopulateHeaders();
        PopulateBiffEntries();
    }

    private void PopulateBiffEntries()
    {
        BiffList = ArrayPool<BiffEntry>.Shared.Rent(_bifCount);
        //BiffList = new BiffEntry[_bifCount];
        var upperBounds = checked(_bifCount - 1);
        int index = 0;
        while (index <= upperBounds)
        {
            BiffList[index] = new BiffEntry(index, _memoryStream, checked(_fileTableOff + 12 * index));
            BiffListInfo.Add(BiffList[index].BiFname, BiffList[index]);
            if (_hashtableBiff.ContainsKey(BiffList[index].Filename))
            {
                Exceptions.Add(new Exception("Your chitin.key file appears to contain multiple entries of the same BIF archive.\nYou may want to reinstall KotOR to fix this.Questionable chitin.key file"));
            }
            else
                _hashtableBiff.Add(BiffList[index].Filename, BiffList[index].FileLength);

            checked
            {
                ++index;
            }
        }
    }

    public override string ToString()
    {
        return $"{nameof(_bifCount)}: {_bifCount}, {nameof(_keyCount)}: {_keyCount}, {nameof(_fileTableOff)}: {_fileTableOff}, {nameof(_keyTableOff)}: {_keyTableOff}, {nameof(Lsum)}: {Lsum}, {nameof(Llength)}: {Llength}";
    }

    private void PopulateHeaders()
    {
        ChitinKeyHeader = new ChitinKeyHeader
        {
            BifCount = _binaryReader.ReadInt32(),
            KeyCount = _binaryReader.ReadInt32(),
            FileTableOff = _binaryReader.ReadInt32(),
            KeyTableOff = _binaryReader.ReadInt32(),
            ByteSum = 0,
            ByteLength = 0
        };
        /*_bifCount = _binaryReader.ReadInt32();
        _keyCount = _binaryReader.ReadInt32();
        _fileTableOff = _binaryReader.ReadInt32();
        _keyTableOff = _binaryReader.ReadInt32();*/
    }

    private void ResolveLsumFromMemory()
    {
        var upperBounds = checked(_memoryStream.Length - 1L);
        long index = 0;
        while (index <= upperBounds)
        {
            checked
            {
                Lsum += _memoryStream.ReadByte();
            }

            checked
            {
                ++index;
            }
        }
    }

    public Hashtable GetBifFileHash(string bifName)
    {
        if (_hashTableResourceReferencesWithId == null || StringType.StrCmp(_lastRequestedBifNameHash, bifName, false) != 0)
        {
            var stringBuilder = new StringBuilder();
            _hashTableResourceReferencesWithId = new Hashtable();
            int upperBound = BiffList.GetUpperBound(0);
            int index1 = 0;
            int num1 = 0;
            bool flag = false;
            while (index1 <= upperBound)
            {
                if (StringType.StrCmp(BiffList[index1].BiFname.ToLower(), bifName.ToLower(), false) == 0)
                {
                    num1 = index1;
                    flag = true;
                    break;
                }

                checked
                {
                    ++index1;
                }
            }

            if (!flag)
                return null;
            _lastRequestedBifNameHash = bifName;
            int num2 = checked(_keyCount - 1);
            int num3 = 0;
            while (num3 <= num2)
            {
                _memoryStream.Seek(checked(_keyTableOff + 22 * num3), SeekOrigin.Begin);
                stringBuilder.Length = 0;
                stringBuilder.Append(_binaryReader.ReadChars(16));
                int index2 = 15;
                while (Strings.Asc(stringBuilder[index2]) == 0)
                {
                    checked
                    {
                        index2 += -1;
                    }

                    if (index2 < 0)
                        break;
                }

                stringBuilder.Length = checked(index2 + 1);
                var str = stringBuilder.ToString();
                var int32 = Convert.ToInt32(_binaryReader.ReadUInt16());
                var fileExtensionValue = _binaryReader.ReadInt32();
                if (fileExtensionValue >> 20 == num1)
                {
                    _hashTableResourceReferencesWithId.Add(str + "." + ResourceIdentification.FindResourceTypeForId(int32), fileExtensionValue & 1048575);
                }
                    
                checked
                {
                    ++num3;
                }
            }
        }

        return _hashTableResourceReferencesWithId;
    }

    public int FindResIdForResRef(string resourceReference, int resourceType)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int num1 = checked(_keyCount - 1);
        int num2 = 0;
        while (num2 <= num1)
        {
            _memoryStream.Seek(checked(_keyTableOff + 22 * num2), SeekOrigin.Begin);
            stringBuilder.Length = 0;
            stringBuilder.Append(_binaryReader.ReadChars(16));
            int index = 15;
            while (Strings.Asc(stringBuilder[index]) == 0)
            {
                checked
                {
                    index += -1;
                }

                if (index < 0)
                    break;
            }

            stringBuilder.Length = checked(index + 1);
            if (StringType.StrCmp(Strings.LCase(resourceReference), Strings.LCase(stringBuilder.ToString()), false) == 0 && Convert.ToInt32(_binaryReader.ReadUInt16()) == resourceType)
                return _binaryReader.ReadInt32();
            checked
            {
                ++num2;
            }
        }

        return -1;
    }

    public IEnumerable<KeyEntry> YieldKeysForResourceType(short resourceType)
    {
        var stringBuilder = new StringBuilder();
        var upperBound = checked(_keyCount - 1);
        var i = 0;
        while (i <= upperBound)
        {
            _memoryStream.Seek(checked(_keyTableOff + 22 * i), SeekOrigin.Begin);
            stringBuilder.Length = 0;
            stringBuilder.Append(_binaryReader.ReadChars(16));
            int index = 15;
            while (Strings.Asc(stringBuilder[index]) == 0)
            {
                checked
                {
                    index += -1;
                }

                if (index < 0)
                    break;
            }

            stringBuilder.Length = checked(index + 1);
            // If next read value is equal to resource type return new key entry
            if (_binaryReader.ReadInt16() == resourceType)
            {
                yield return new KeyEntry(stringBuilder.ToString(), resourceType, _binaryReader.ReadInt32());
            }
               
            checked
            {
                ++i;
            }
        }
    }
    
    
    public ArrayList GetKeysForResourceType(short resourceType)
    {
        var keysforResourceType = new ArrayList();
        var stringBuilder = new StringBuilder();
        var upperBound = checked(_keyCount - 1);
        var i = 0;
        while (i <= upperBound)
        {
            _memoryStream.Seek(checked(_keyTableOff + 22 * i), SeekOrigin.Begin);
            stringBuilder.Length = 0;
            stringBuilder.Append(_binaryReader.ReadChars(16));
            int index = 15;
            while (Strings.Asc(stringBuilder[index]) == 0)
            {
                checked
                {
                    index += -1;
                }

                if (index < 0)
                    break;
            }

            stringBuilder.Length = checked(index + 1);
            if (_binaryReader.ReadInt16() == resourceType)
            {
                keysforResourceType.Add(new KeyEntry(stringBuilder.ToString(), resourceType, _binaryReader.ReadInt32()));
            }
               
            checked
            {
                ++i;
            }
        }

        return keysforResourceType;
    }


    public IEnumerator<BiffEntry> GetEnumerator()
    {
        return BiffList.GetEnumerator() as IEnumerator<BiffEntry>;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Dispose()
    {
        _keyFileStream?.Dispose();
        _memoryStream?.Dispose();
        _binaryReader?.Dispose();
        ArrayPool<BiffEntry>.Shared.Return(BiffList);
        MemoryOwner?.Dispose();
    }
}