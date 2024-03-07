using System.Buffers;
using System.Collections;
using System.Text;
using Kotortool_Legacy.Domain.Interfaces;

namespace Kotortool_Legacy.API;

public sealed class RimKeyEntryOffsetSupplier 
{
    /*public RimKeyEntryOffsetSupplier(IReadOnlyList<byte> byteLoad, int index)
    {
        index = checked((int)Math.Round(byteLoad[checked(OffKeyList + index * 32 + 28)] +
                                        byteLoad[checked(OffKeyList + index * 32 + 29)] * 256.0 +
                                        byteLoad[checked(OffKeyList + index * 32 + 30)] * 65536.0 +
                                        byteLoad[checked(OffKeyList + index * 32 + 31)] * 16777216.0));
    }*/
}

public sealed class EntryCountSupplier(byte[] inData) 
{
    
   // private readonly SoftReference<byte[]> _bytesReference = new(inData);

    /*public int Invoke()
    {
        if (!_bytesReference.TryGetTarget(out var data)) return 0;
           
        var round = checked((int)Math.Round(
            data[12] + data[13] * 256.0 + data[14] * 65536.0 + data[15] * 16777216.0));
            
        return round;
    }*/

    /*public Func<int> ToDelegate()
    {
        return Invoke;
    }*/
}

public sealed class ClsRim : 
    IDisposable, 
    IAsyncDisposable, 
    IAsyncEnumerable<RimKeyEntry>, 
    IAsyncEnumerator<RimKeyEntry>,
    IOwnsMany<RimKeyEntry>, 
    IResourceData
{
        
    public readonly int EntryCount; // Constant Offset
    public readonly int OffKeyList; // Constant Offset

    public readonly ArrayList KeyEntryList; // OwnedEntries

    private readonly IMemoryOwner<byte> _data; // IResourceData
    private IEnumerable<RimKeyEntry> KeyEntries => MemoryOwner.Memory.Span.ToArray();

    public IMemoryOwner<RimKeyEntry> MemoryOwner { get; set; }

    public IMemoryOwner<byte> Data { get; set; }

    /*
     *
     *  Primary Constructor
     *
     */
    public ClsRim(byte[] inData)
    {
        var asciiEncoding = new ASCIIEncoding();
        var stringBuilder = new StringBuilder();


        //_data = inData;
        var _ownedData = MemoryPool<byte>.Shared.Rent(inData.Length);
            

        EntryCount = checked((int)Math.Round(_data.Memory.Span[12] + _data.Memory.Span[13] * 256.0 +
                                             _data.Memory.Span[14] * 65536.0 + _data.Memory.Span[15] * 16777216.0));
        OffKeyList = checked((int)Math.Round(_data.Memory.Span[16] + _data.Memory.Span[17] * 256.0 +
                                             _data.Memory.Span[18] * 65536.0 + _data.Memory.Span[19] * 16777216.0));


        KeyEntryList = new ArrayList(EntryCount);


        /*var num1 = checked(EntryCount - 1);
        var index = 0;
        while (index <= num1)
        {
            stringBuilder.Append(asciiEncoding.GetString(_data, checked(OffKeyList + index * 32), 16));
            var num2 = 0;
            while (_data[checked(OffKeyList + num2 + index * 32)] != 0)
            {
                checked
                {
                    ++num2;
                }

                if (num2 > 15)
                    break;
            }

            stringBuilder.Length = num2;
            var resourceName = stringBuilder.ToString();
            stringBuilder.Length = 0;

            var resType = checked((short)Math.Round(_data[checked(OffKeyList + index * 32 + 16)] +
                                                    _data[checked(OffKeyList + index * 32 + 17)] * 256.0));

            var resourceId = checked((short)Math.Round(_data[checked(OffKeyList + index * 32 + 18)] +
                                                       _data[checked(OffKeyList + index * 32 + 19)] * 256.0));

            var offset = checked((int)Math.Round(_data[checked(OffKeyList + index * 32 + 24)] +
                                                 _data[checked(OffKeyList + index * 32 + 25)] * 256.0 +
                                                 _data[checked(OffKeyList + index * 32 + 26)] * 65536.0 +
                                                 _data[checked(OffKeyList + index * 32 + 27)] * 16777216.0));

            var length = checked((int)Math.Round(_data[checked(OffKeyList + index * 32 + 28)] +
                                                 _data[checked(OffKeyList + index * 32 + 29)] * 256.0 +
                                                 _data[checked(OffKeyList + index * 32 + 30)] * 65536.0 +
                                                 _data[checked(OffKeyList + index * 32 + 31)] * 16777216.0));

            KeyEntryList.Add(new RimKeyEntry(resourceName, resType, resourceId, offset, length, index));
            checked
            {
                ++index;
            }
        }*/
    }


    /*
     *
     *  Factory Method
     *
     */
    public static ClsRim CreateInstance(string filePath)
    {
        return CreateInstance(File.ReadAllBytes(filePath));
    }


    /*
     *
     *  Factory Method
     *
     */
    public static ClsRim CreateInstance(byte[] inData)
    {
        return new ClsRim(inData);
    }

    public byte[] GetRimResource(int index)
    {
        var keyEntry = (RimKeyEntry)KeyEntryList[index];
        var destinationArray = new byte[checked(keyEntry._Length - 1 + 1)];

        //Array.Copy(_data, keyEntry._Offset, destinationArray, 0, keyEntry._Length);

        _data.Memory.CopyTo(destinationArray);
        return destinationArray;
    }

    public void Dispose()
    {
        MemoryOwner.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        MemoryOwner.Dispose();
    }

    public IAsyncEnumerator<RimKeyEntry> GetAsyncEnumerator(CancellationToken cancellationToken = new())
    {
        //var asyncEnumerable = KeyEntries.ToAsyncEnumerable();
        //return asyncEnumerable.GetAsyncEnumerator(cancellationToken);
        return null;
    }

    public bool MoveNext()
    {
        return KeyEntries.GetEnumerator().MoveNext();
    }

    public void Reset()
    {
        KeyEntries.GetEnumerator().Reset();
    }

    public async ValueTask<bool> MoveNextAsync()
    {
        /*return await KeyEntries
            .ToAsyncEnumerable()
            .GetAsyncEnumerator()
            .MoveNextAsync();*/
        return true;
    }

    public RimKeyEntry Current => KeyEntries.GetEnumerator().Current;
}