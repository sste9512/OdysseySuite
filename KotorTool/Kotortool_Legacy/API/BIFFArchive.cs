using System.Buffers;
using Kotortool_Legacy.Domain.Interfaces;

namespace Kotortool_Legacy.API;

public class BIFFArchive : IOwnsMany<BiffVarRsrcEntryInfo>
{
    public int VarResCnt;
    private int _fixedResCnt;
    private int _varResEntryOff;
    private int _fixedResEntryOff;
    private readonly FileStream _fileStream;
    private string _signature;
    private string _version;

    public IMemoryOwner<BiffVarRsrcEntryInfo> MemoryOwner { get; set; }
    public BIFFArchive()
    {
    }

    public BIFFArchive(FileStream fileStream)
    {
        _fileStream = fileStream;
        ReadBiffHeader(_fileStream);
    }

    private void ReadBiffHeader(FileStream fileStream)
    {
        var binaryReader = new BinaryReader(fileStream);
        _signature = new string(binaryReader.ReadChars(4));
        _version = new string(binaryReader.ReadChars(4));
        VarResCnt = binaryReader.ReadInt32();
        _fixedResCnt = binaryReader.ReadInt32();
        _varResEntryOff = binaryReader.ReadInt32();
    }

    public BiffVarRsrcEntryInfo GetBiffResourceInfo(int offset)
    {
        var binaryReader = new BinaryReader(_fileStream);
        _fileStream.Seek(checked(_varResEntryOff + 16 * offset), SeekOrigin.Begin);
        return new BiffVarRsrcEntryInfo(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32(),
            binaryReader.ReadInt32());
    }

    public static BiffVarRsrcEntryInfo[] GetBiffResourceInfoList(string biffPath)
    {
        var input = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var binaryReader = new BinaryReader(input);
        binaryReader.ReadChars(8);
        int length = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        int num1 = binaryReader.ReadInt32();
        BiffVarRsrcEntryInfo[] instance =
            new BiffVarRsrcEntryInfo[length];
        int num2 = checked(length - 1);
        int index = 0;
        while (index <= num2)
        {
            input.Seek(checked(num1 + 16 * index), SeekOrigin.Begin);
            instance[index] = new BiffVarRsrcEntryInfo(binaryReader.ReadInt32(), binaryReader.ReadInt32(),
                binaryReader.ReadInt32(), binaryReader.ReadInt32());
            checked
            {
                ++index;
            }
        }

        return instance;
    }

    public BiffVarRsrcEntry GetBiffResource(int offset)
    {
        BinaryReader binaryReader = new BinaryReader(_fileStream);
        BiffVarRsrcEntry biffResource = new BiffVarRsrcEntry();
        BiffVarRsrcEntryInfo biffResourceInfo = GetBiffResourceInfo(offset);
        _fileStream.Seek(biffResourceInfo.Offset, SeekOrigin.Begin);
        biffResource.Data = binaryReader.ReadBytes(biffResourceInfo.FileSize);
        return biffResource;
    }

    public static BiffVarRsrcEntry GetBIFFResource(string biffPath, int resourceId) =>
        new BIFFArchive(new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
            .GetBiffResource(resourceId);

    public int ResCount => VarResCnt;
   
}