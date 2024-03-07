namespace Kotortool_Legacy.API;

public sealed class BiffVarRsrcEntryInfo
{
    public int ResId;
    public int Offset;
    public int FileSize;
    public int ResourceType;

    public BiffVarRsrcEntryInfo(int resId, int offset, int fileSize, int resourceType)
    {
        this.ResId = resId;
        this.Offset = offset;
        this.FileSize = fileSize;
        this.ResourceType = resourceType;
    }
}