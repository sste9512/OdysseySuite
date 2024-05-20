using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace kotor_tool.API.AuroraParsers
{
    public class AuroraFile
    {
        public enum ResourceTypes
        {
            Na = 0x000F,
            Bmp = 1,
            Tga = 3,
            Wav = 4,
            Plt = 6,
            Ini = 7,
            Txt = 10,
            Mdl = 2002,
            Nss = 2009,
            Ncs = 2010,
            Are = 2012,
            Set = 2013,
            Ifo = 2014,
            Bic = 2015,
            Wok = 2016,
            _2da = 2017,
            Txi = 2022,
            Git = 2023,
            Uti = 2025,
            Utc = 2027,
            Dlg = 2029,
            Itp = 2030,
            Utt = 2032,
            Dds = 2033,
            Uts = 2035,
            Ltr = 2036,
            Gff = 2037,
            Fac = 2038,
            Ute = 2040,
            Utd = 2042,
            Utp = 2045,
            Dtf = 2045,
            Gic = 2046,
            Gui = 2047,
            Utm = 2051,
            Dwk = 2052,
            Pwk = 2053,
            Jrl = 2056,
            Sav = 2057,
            Utw = 2058,
            Ssf = 2060,
            Hak = 2061,
            Nwm = 2062,
            Bik = 2063,
            Ptm = 2065,
            Ptt = 2066,

            Lyt = 3000,
            Vis = 3001,
            Rim = 3002,
            Pth = 3003,
            Lip = 3004,
            Bwm = 3005,
            Txb = 3006,
            Tpc = 3007,
            Mdx = 3008,
            Rsv = 3009,
            Sig = 3010,
            Xbx = 3011,

            Erf = 9997,
            Bif = 9998,
            Key = 9999
        }


        private FileStream _fileStream;
        private MemoryStream _memoryStream;
        private BinaryReader _reader;
        private StreamReader _streamReader;
        private byte[] _bytes;

        private string _name = string.Empty;
        private string _ext = string.Empty;
        private string _path = null;
        private Encoding _encoding = Encoding.ASCII;


        public bool IsText = false;

        public AuroraFile(string path)
        {
            _ext = Path.GetExtension(path);
            _name = Path.GetFileNameWithoutExtension(path);
            _path = path;
        }

        public AuroraFile(byte[] bytes, string name, int restype)
        {
            _bytes = bytes;
            _ext = "." + ((ResourceTypes)restype);
            _name = name;

            Debug.WriteLine(_ext);
        }


        public string GetFilename()
        {
            return _name;
        }

        public string GetExt()
        {
            return _ext;
        }

        public string GetPath()
        {
            return _path;
        }

        public void Open()
        {
            if (_path != null)
            {
                _fileStream = new FileStream(GetPath(), FileMode.Open);
                if (IsText)
                    _streamReader = new StreamReader(_fileStream, _encoding);
                else
                    _reader = new BinaryReader(_fileStream, _encoding);
            }
            else
            {
                _memoryStream = new MemoryStream(_bytes);
                _reader = new BinaryReader(_memoryStream, _encoding);
            }
        }

        public void SetEncoding(Encoding encoding)
        {
            _encoding = encoding;
        }

        public void Close()
        {
            if (_path != null)
            {
                _fileStream.Dispose();
                if (IsText)
                    _streamReader.Dispose();
                else
                    _reader.Dispose();
            }
            else
            {
                _memoryStream.Dispose();
                _reader.Dispose();
            }
        }

        public FileStream GetFileStream()
        {
            return _fileStream;
        }

        public MemoryStream GetMemoryStream()
        {
            return _memoryStream;
        }

        public BinaryReader GetReader()
        {
            return _reader;
        }

        public StreamReader GetStreamReader()
        {
            return _streamReader;
        }

        public byte[] GetContents()
        {
            return _bytes;
        }

        public void Export(string exportDir)
        {
            if (_bytes != null)
            {
                FileStream fs = new FileStream(Path.Combine(exportDir, GetFilename() + GetExt()), FileMode.Create,
                    FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(_bytes);

                bw.Close();
                fs.Close();
            }
        }

        public void Export(string exportDir, string filename)
        {
            if (_bytes != null)
            {
                FileStream fs = new FileStream(Path.Combine(exportDir, filename + GetExt()), FileMode.Create,
                    FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(_bytes);

                bw.Close();
                fs.Close();
            }
        }

        public void Dispose()
        {
            _bytes = null;
            _fileStream = null;
            _memoryStream = null;
            _reader = null;
        }

        public static void ReadValue(BinaryReader stream, out uint value)
        {
            value = stream.ReadUInt32();
        }

        public static void ReadValue(BinaryReader stream, out float value)
        {
            value = stream.ReadSingle();
        }

        /*public static void ReadArray(BinaryReader stream,
                      UInt32 offset, UInt32 count,  out values)//std::vector<T>
        {


        }*/

        public static void ReadArray(BinaryReader stream,
            uint offset, uint count, ref uint[] values) //vector<UInt32>
        {
            long pos = stream.BaseStream.Position;
            stream.BaseStream.Position = offset;

            //values.resize(count);
            for (uint i = 0; i < count; i++)
            {
                uint val;

                ReadValue(stream, out val);
                Debug.WriteLine("ReadValue: " + val);
                values[i] = val;
            }

            stream.BaseStream.Position = pos;
        }

        public static void ReadArray(BinaryReader stream, uint offset, uint count, ref float[] values) //vector<float>
        {
            long pos = stream.BaseStream.Position;
            stream.BaseStream.Position = offset;

            //values.resize(count);
            for (uint i = 0; i < count; i++)
                ReadValue(stream, out values[i]);

            stream.BaseStream.Position = pos;
        }

        //Gets the Array Offset & Item Count
        public static void ReadArrayDef(BinaryReader stream, out uint offset, out uint count)
        {
            offset = stream.ReadUInt32();

            uint usedCount = stream.ReadUInt32();
            uint allocatedCount = stream.ReadUInt32();

            if (usedCount != allocatedCount)
                throw new Exception("Model::readArrayDef(): usedCount != allocatedCount (" + usedCount + ", " +
                                    allocatedCount + ")");

            count = usedCount;
        }

        public static void ReadStrings(BinaryReader stream, uint[] offsets, uint offset, out string[] strings)
        {
            long pos = stream.BaseStream.Position;

            strings = new string[offsets.Length];

            Debug.WriteLine("Reading Strings");

            for (int i = 0; i != offsets.Length; i++)
            {
                stream.BaseStream.Position = offset + offsets[i];

                string tmpName = "";
                char c;

                while ((int)(c = stream.ReadChar()) != 0)
                    tmpName = tmpName + c;

                strings[i] = tmpName;
                //Debug.WriteLine(tmpName);
                //strings.push_back(Common::readString(mdl, Common::kEncodingASCII));
            }

            stream.BaseStream.Position = pos;
        }

        public override string ToString()
        {
            return
                $"{nameof(_name)}: {_name}, {nameof(_ext)}: {_ext}, {nameof(_path)}: {_path}, {nameof(_encoding)}: {_encoding}, {nameof(IsText)}: {IsText}";
        }
    }
}