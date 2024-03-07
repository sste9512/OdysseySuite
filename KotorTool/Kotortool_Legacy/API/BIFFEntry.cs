using System.Buffers;
using Kotortool_Legacy.Domain.Interfaces;

namespace Kotortool_Legacy.API;

public class BiffEntry : IOwnsMany<BIFFArchive>
{
    public int Index;
    public int FileLength;
    public int StringOffset;
    public int StringLength;
    public int Location;
    public string Filename;
    public string BiFname;
    private IMemoryOwner<BiffVarRsrcEntryInfo> _memoryOwner;

    public string FilePath { get; set; }
    
    public IMemoryOwner<BIFFArchive> MemoryOwner { get; set; }
    
    public BiffVarRsrcEntry YieldBiffResource(int resourceId)
    {
        var resourceEntry = YieldBiffArchive()
            .GetBiffResource(resourceId);
        
        return resourceEntry;
    }

    /*public IEnumerable<BiffVarRsrcEntryInfo> YieldAllEntries()
    {
        var archive = YieldBiffArchive();
        for(var i = 0; i != archive.VarResCnt; i++)
        {
            yield return new BiffVarRsrcEntryInfo();
            /*{
                ID: this.reader.ReadUInt32(),
                Offset: this.reader.ReadUInt32(),
                FileSize: this.reader.ReadUInt32(),
                ResType: this.reader.ReadUInt32()
            };#1#
        }
    }*/

    public BIFFArchive YieldBiffArchive()
    {
        using (var fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
        {
            return new BIFFArchive(fileStream);
        }
    }
    
    public Guid Id { get; set; } = Guid.NewGuid();

    
    public BiffEntry(int index, FileStream fileStream, int offset)
    {
        var binaryReader = new BinaryReader(fileStream);
        this.Index = index;
        fileStream.Seek(offset, SeekOrigin.Begin);
           
        FileLength = binaryReader.ReadInt32();
        StringOffset = binaryReader.ReadInt32();
        StringLength = binaryReader.ReadInt16();
        Location = binaryReader.ReadInt16();
           
        fileStream.Seek(StringOffset, SeekOrigin.Begin);
          
        Filename = new string(binaryReader.ReadChars(checked(StringLength - 1)));
            
        if (Filename.StartsWith(@"\\"))
            Filename = Filename.Substring(1);
            
        Filename = Filename.Replace(@"\\", "\\").Replace(":", "\\");
        BiFname = Filename.Replace("data\\", string.Empty).Replace(".bif", string.Empty);
    }

    public BiffEntry(int index, MemoryStream memoryStream, int offset)
    {
        BinaryReader binaryReader = new BinaryReader(memoryStream);
        this.Index = index;
        memoryStream.Seek(offset, SeekOrigin.Begin);
            
        FileLength = binaryReader.ReadInt32();
        StringOffset = binaryReader.ReadInt32();
        StringLength = binaryReader.ReadInt16();
        Location = binaryReader.ReadInt16();
            
        memoryStream.Seek(StringOffset, SeekOrigin.Begin);
            
        Filename = new string(binaryReader.ReadChars(checked(StringLength - 1)));
           
        if (Filename.StartsWith("\\\\"))
            Filename = Filename.Substring(1);
            
        Filename = Filename.Replace("\\\\", "\\").Replace(":", "\\");
        BiFname = Filename.Replace("data\\", "").Replace(".bif", "");
    }


   
}