using System.Collections.Generic;
using System.IO;
using KotorDotnet.AuroraParsers.Biff;
using KotorDotnet.AuroraParsers.Chitin;
using OdysseyStudio.Server.Domain.AuroraParsers.Chitin;

namespace kotor_tool.API.AuroraParsers.Biff;

public sealed class BiffObject
{
    //Not used in spec

    AuroraFile _file;
    BinaryReader _reader;
    BiffHeader _header = new();
    private readonly List<VResourceHeader> _variableResourceList = new();

    

    public BiffObject(AuroraFile file)
    {
        _file = file;
    }

    public void Read()
    {

        _file.Open();
        _reader = _file.GetReader();

        _header.FileType = _reader.ReadChars(4);
        _header.FileVersion = _reader.ReadChars(4);
        _header.VariableResourceCount = _reader.ReadUInt32();
        _header.FixedResourceCount = _reader.ReadUInt32();
        _header.VariableTableOffset = _reader.ReadUInt32();

        _reader.BaseStream.Position = _header.VariableTableOffset;
        for(int i = 0; i!=_header.VariableResourceCount; i++)
        {
            var res = new VResourceHeader
            {
                ID = _reader.ReadUInt32(),
                Offset = _reader.ReadUInt32(),
                FileSize = _reader.ReadUInt32(),
                ResourceType = _reader.ReadUInt32()
            };
            _variableResourceList.Add(res);
        }

        _file.Close();

    }

    public VResourceHeader FindFileById(uint id)
    {
        System.Diagnostics.Debug.Write("Finding: "+id);
        foreach(VResourceHeader res in _variableResourceList)
        {
            if(res.ID == id)
            {
                return res;
            }
        }

        return new VResourceHeader();
    }

    public AuroraFile ExtractVResource(VResourceHeader fileHeader, KeyTable key)
    {
        byte[] bytes = { 0 };
        _file.Open();
        _reader = _file.GetReader();
        if (fileHeader.Offset != null)
        {
            _reader.BaseStream.Position = fileHeader.Offset;
            bytes = _reader.ReadBytes((int)fileHeader.FileSize);

            _file.Close();
        }

        return new AuroraFile(bytes, new string(key.ResRef), key.ResourceType);

    }

    public AuroraFile ExtractFile (KeyObject keyObject, string filename, uint restype)
    {
        byte[] bytes = { 0 };

        KeyTable key = keyObject.FindFileKey(filename, restype);

        var fileHeader = FindFileById(key.ResId);
        _file.Open();
        _reader = _file.GetReader();
        if (fileHeader.Offset != null)
        {
            _reader.BaseStream.Position = fileHeader.Offset;
            bytes = _reader.ReadBytes((int)fileHeader.FileSize);

            _file.Close();
        }

        return new AuroraFile(bytes, new string(key.ResRef), key.ResourceType);

    }

    public string GetFilename()
    {
        return _file.GetFilename();
    }

    public List<VResourceHeader> GetResources()
    {
        return _variableResourceList;
    }

    public override string ToString()
    {
        return $"{nameof(_file)}: {_file}, {nameof(_reader)}: {_reader}, {nameof(_header)}: {_header}, {nameof(_variableResourceList)}: {_variableResourceList}";
    }
}