using AuroraParsers.AuroraParsers.Biff;
using AuroraParsers.AuroraParsers.Chitin;

namespace AuroraParsers.AuroraParsers;

public sealed class VResourceContext
{
    public KeyObject KeyObject { get; set; }
    public List<BiffObject> BiffObjects { get; set; }
}