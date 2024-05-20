using System.Collections.Generic;
using kotor_tool.API.AuroraParsers.Biff;
using KotorDotnet.AuroraParsers.Biff;
using KotorDotnet.AuroraParsers.Chitin;
using OdysseyStudio.Server.Domain.AuroraParsers.Chitin;

namespace kotor_tool.API.AuroraParsers;

public sealed class VResourceContext
{
    public KeyObject KeyObject { get; set; }
    public List<BiffObject> BiffObjects { get; set; }    
}