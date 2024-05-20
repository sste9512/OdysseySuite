using System;

namespace KotorDotnet.AuroraParsers.Biff;

public struct VResourceHeader
{
    public UInt32 ID;
    public UInt32 Offset;
    public UInt32 FileSize;
    public UInt32 ResourceType;
}