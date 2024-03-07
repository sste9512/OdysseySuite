using Kotortool_Legacy.API.AuroraParsers.Biff;
using Kotortool_Legacy.API.AuroraParsers.Chitin;

namespace Kotortool_Legacy.API.AuroraParsers;

public sealed class VResourceContext
{
    public KeyObject KeyObject { get; set; }
    public List<BiffObject> BiffObjects { get; set; }    
}